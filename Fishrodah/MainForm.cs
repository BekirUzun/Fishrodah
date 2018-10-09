using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishrodah
{
    public partial class MainForm : Form
    {
        Bot bot;
        List<Process> processes;
        Color red, green, blue, disabled;

        public MainForm()
        {
            InitializeComponent();

            red = Color.FromArgb(231, 76, 60);
            green = Color.FromArgb(39, 174, 96); 
            blue = Color.FromArgb(41, 128, 185);
            disabled = Color.FromArgb(127, 140, 141);

            processes = new List<Process>();
            bot = new Bot(this);

            LoadProcesses();
        }

        public void DisplayLog(string text)
        {
            logLabel.Invoke((MethodInvoker)(() => logLabel.Text += text + "\n"));
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (bot.IsRunning)
            {
                startBtn.BackColor = blue;
                reloadBtn.BackColor = green;
                startBtn.Text = "Start Bot";
                processesCB.Enabled = true;
                reloadBtn.Enabled = true;
                
                bot.Stop();
            }
            else
            {

                startBtn.BackColor = red;
                reloadBtn.BackColor = disabled;
                startBtn.Text = "Stop Bot";
                processesCB.Enabled = false;
                reloadBtn.Enabled = false;
                
                bot.Start();
            }

        }

        private void LoadProcesses()
        {
            processes.Clear();
            processesCB.Items.Clear();
            processesCB.ResetText();
            processesCB.SelectedItem = null;
            processesCB.SelectedIndex = -1;

            Process[] allProcesses = Process.GetProcesses();
            foreach (Process p in allProcesses)
            {
                if (p.MainWindowHandle == (IntPtr)0)
                    continue;

                if (p.ProcessName.ToLower().Contains("wow"))
                {
                    processes.Add(p);
                }
            }

            if (processes.Count == 0)
                return;


            processes.Sort((p1, p2) => p1.Id.CompareTo(p2.Id));


            foreach (Process p in processes)
            {
                processesCB.Items.Add("(" + p.Id + ") " + p.ProcessName);
            }

            processesCB.SelectedIndex = 0;
            processesCB.Enabled = true;
            //processesCB.PromptText = "Select a process...";


        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private void processesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (processesCB.SelectedIndex < 0 || processesCB.SelectedIndex >= processes.Count)
            {
                bot.SelectedProcess = null;
                startBtn.Enabled = false;
                return;
            }
            startBtn.Enabled = true;
            bot.SelectedProcess = processes[processesCB.SelectedIndex];
        }

        private void keyTB_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            bot.FishingKey = e.KeyCode;
            //settings.KeyToSend = (int)e.KeyCode;
            keyTB.Text = e.KeyData.ToString();
            startBtn.Enabled = true;
            startBtn.BackColor = blue;
            //base.OnKeyDown(e);
        }

    }
}
