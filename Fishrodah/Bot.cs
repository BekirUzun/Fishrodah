using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Drawing;
using System.Globalization;
using System.Data;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using nucs.JsonSettings;

namespace Fishrodah
{
    public class Bot
    {
        public bool IsRunning { get; private set; }
        private MainForm form;
        private Process listener;
        public Process SelectedProcess;
        public int SelectedSpeaker;
        public Keys FishingKey;
        Point clickPoint;
        int fishCount;

        #region Structs
        internal struct INPUT
        {
            public UInt32 Type;
            public MOUSEKEYBDHARDWAREINPUT Data;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct MOUSEKEYBDHARDWAREINPUT
        {
            [FieldOffset(0)]
            public MOUSEINPUT Mouse;
        }

        internal struct MOUSEINPUT
        {
            public Int32 X;
            public Int32 Y;
            public UInt32 MouseData;
            public UInt32 Flags;
            public UInt32 Time;
            public IntPtr ExtraInfo;
        }

        public class HotkeyItem
        {
            public int KeyCode;
            public string KeyText;

            public HotkeyItem(string KeyText, Keys KeyCode)
            {
                this.KeyCode = (int)KeyCode;
                this.KeyText = KeyText;
            }

            public HotkeyItem(string KeyText, int KeyCode)
            {
                this.KeyCode = KeyCode;
                this.KeyText = KeyText;
            }

            public override string ToString()
            {
                return KeyText;
            }
        }
        #endregion

        #region External functions
        [DllImport("user32.dll")]
        static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

        [DllImport("user32.dll")]
        static extern bool ScreenToClient(IntPtr hWnd, ref Point lpPoint);

        [DllImport("user32.dll")]
        internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern IntPtr WindowFromPoint(int xPoint, int yPoint);

        [DllImport("User32.dll")]
        static extern IntPtr ChildWindowFromPoint(IntPtr hWndParent, Point p);

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        #endregion

        #region Constants
        const uint WM_CHAR = 0x102;
        const uint WM_PASTE = 0x0302;
        const uint WM_MOUSEMOVE = 0x200;
        const uint WM_SETCURSOR = 0x20;
        const uint WM_KEYDOWN = 0x100;
        const uint WM_KEYUP = 0x101;
        const int WM_SYSKEYDOWN = 0x0104;
        const int WM_SYSKEYUP = 0x0105;
        const int WM_LBUTTONDOWN = 0x0201;
        const int WM_LBUTTONUP = 0x0202;
        const int WM_LBUTTONDBLCLK = 0x203;
        const int WM_RBUTTONDOWN = 0x204;
        const int WM_RBUTTONUP = 0x205;
        const int WM_RBUTTONDBLCLK = 0x206;

        const int CLICKSPAM_HOTKEY_ID = 1;
        const int KEYSPAM_HOTKEY_ID = 2;
        #endregion

        public Bot(MainForm form)
        {
            this.IsRunning = false;
            clickPoint = new Point(0, 0);
            fishCount = 0;
            this.form = form;

            Process[] plist = Process.GetProcessesByName("Wow-64");
            if(plist.Length > 0)
                SelectedProcess = plist[0];

        }

        public void Start()
        {
            if (IsRunning || SelectedSpeaker < 1 || SelectedProcess == null)
            {
                return;
            }
            Log("Starting bot...");

            IsRunning = true;
            //RunListener();
            Task.Factory.StartNew(() => RunListener());
        }

        private void RunListener()
        {
            var startinfo = new ProcessStartInfo(@".\Listener.exe")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                Arguments = "-s " + SelectedSpeaker
            };
            listener = new Process { StartInfo = startinfo };

            listener.OutputDataReceived += DataRecieved;
            listener.ErrorDataReceived += DataRecieved;

            listener.Start();

            // Asynchronously read the standard output of the spawned process. 
            // This raises OutputDataReceived events for each line of output.
            listener.BeginOutputReadLine();

            listener.WaitForExit();
        }

        public void GetSpeakers()
        {
            var startinfo = new ProcessStartInfo(@".\Listener.exe")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                Arguments = " -l"
            };

            var proc = new Process { StartInfo = startinfo };
            proc.Start();

            proc.WaitForExit();
        }

        private void DataRecieved(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                EventHandler(e.Data);
            }
        }

        public void Stop()
        {
            if (listener.HasExited)
            {
                IsRunning = false;
                return;
            }
            Log("Stopping bot...");

            // set a flag that will abort the loop
            this.IsRunning = false;

            Process.Start(new ProcessStartInfo
            {
                FileName = "taskkill",
                Arguments = $"/im {listener.ProcessName}.exe /f /t",
                CreateNoWindow = true,
                UseShellExecute = false
            }).WaitForExit();

            Log("Bot stopped.");
        }

        private void EventHandler(string message)
        {

            string[] parts = message.Split(':');
            string action = parts[0];

            Debug.WriteLine(action);

            if (action.Contains("start"))
            {
                Log("Bot started.");

                Thread.Sleep(1000);
                SendKey();
                Log("Bobber thrown.");
                //SendClick(10, 10);
            }
            else if (action.Contains("bobber") && !action.Contains("no")) //TODO: Fix
            {
                string[] location = action.Split('=')[1].Split(',');
                clickPoint.X = int.Parse(location[0]);
                clickPoint.Y = int.Parse(location[1]);

                Log("Bobber found at " + clickPoint.X + "," + clickPoint.Y);
            }
            else if (action.Contains("catch"))
            {
                SendClick(clickPoint);
                Thread.Sleep(1000);
                SendKey();
                fishCount++;
                Log("Catched fish " + fishCount);
            }
            else if (action.Contains("timeout"))
            {
                Log("Fishing time out. Throwing another bobber.");
                SendKey();
            }
            else if (action.Contains("searchfail"))
            {
                float similarity = float.Parse(action.Split('=')[1].Replace('.', ','));
                Log("Bobber not found. Reduced similarity rate to " + similarity.ToString("0.0"));
            }
            else if (action.Contains("notfound"))
            {
                Log("Tried to catch fish but bobber is not found.");
                SendKey();
            }
            else if (action.Contains("critical"))
            {
                string errorMsg = action.Split(':')[1];
                Log("A critical error ocurred. " + errorMsg);
                Stop();
            }
            else if (action.Contains("end"))
            {
                Stop();
            }

            //form.UpdateLabel(message);
        }

        private int MakeLParam(int LoWord, int HiWord)
        {
            return (int)((HiWord << 16) | (LoWord & 0xFFFF));
        }

        private void SendClick(Point p)
        {
            Point oldPos = Cursor.Position;

            int clickPos = MakeLParam(p.X, p.Y);

            // set cursor on coords
            Cursor.Position = clickPoint;
            Thread.Sleep(10);

            //PostMessage(selectedProc.MainWindowHandle, WM_SETCURSOR, IntPtr.Zero, (IntPtr)clickPos);
            //PostMessage(selectedProc.MainWindowHandle, WM_MOUSEMOVE, IntPtr.Zero, (IntPtr)clickPos);
            SendMessage(SelectedProcess.MainWindowHandle, WM_LBUTTONDOWN, 0, (uint)clickPos);
            SendMessage(SelectedProcess.MainWindowHandle, WM_LBUTTONUP, 0, (uint)clickPos);

            Thread.Sleep(100);

            // restore mouse position 
            Cursor.Position = oldPos;            
        }

        private void SendKey()
        {
            //PostMessage(selectedProc.MainWindowHandle, WM_KEYDOWN, (IntPtr)settings.KeyToSend, IntPtr.Zero);
            //System.Threading.Thread.Sleep(5);
            //PostMessage(selectedProc.MainWindowHandle, WM_KEYUP, (IntPtr)settings.KeyToSend, IntPtr.Zero);
            if (SelectedProcess == null)
                return;

            PostMessage(SelectedProcess.MainWindowHandle, WM_KEYDOWN, (IntPtr)FishingKey, IntPtr.Zero); 
            //Thread.Sleep(5);
            PostMessage(SelectedProcess.MainWindowHandle, WM_KEYUP, (IntPtr)FishingKey, IntPtr.Zero);

        }

        private void Log(string message)
        {
            string logText = "[" + DateTime.Now.ToLongTimeString() + "]: " + message ;
            form.DisplayLog(logText);
            Debug.WriteLine(logText);
        }


    }
}
