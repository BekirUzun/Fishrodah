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
using nucs.JsonSettings;

namespace Fishrodah
{
    public partial class MainForm : Form
    {
        Bot bot;
        List<Process> processes;
        Speakers speakers;
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
            speakers = JsonSettings.Load<Speakers>();

            if(bot.Settings.FishingKey != Keys.None)
            {
                keyTB.Text = bot.Settings.FishingKey.ToString();
                startBtn.Enabled = true;
                startBtn.BackColor = blue;
            }

            LoadProcesses();
            LoadSpeakers();
        }

        public void DisplayLog(string text)
        {
            logLabel.Invoke((MethodInvoker)(() => logLabel.Text += text + "\n"));
            logPanel.Invoke((MethodInvoker)(() => logPanel.VerticalScroll.Value = logPanel.VerticalScroll.Maximum));
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (bot.IsRunning)
            {
                startBtn.BackColor = blue;
                processRldBtn.BackColor = green;
                speakersRldBtn.BackColor = green;
                startBtn.Text = "Start Bot";
                processesCB.Enabled = true;
                processRldBtn.Enabled = true;
                speakersCB.Enabled = true;
                speakersRldBtn.Enabled = true;
                
                bot.Stop();
            }
            else
            {

                startBtn.BackColor = red;
                processRldBtn.BackColor = disabled;
                speakersRldBtn.BackColor = disabled;
                startBtn.Text = "Stop Bot";
                processesCB.Enabled = false;
                processRldBtn.Enabled = false;
                speakersCB.Enabled = false;
                speakersRldBtn.Enabled = false;

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

        private void LoadSpeakers()
        {
            if(speakers.DeviceList.Count == 0)
            {
                ReloadSpeakers();
                return;
            }

            int selectedIndex = 0;
            for(int i = 0; i < speakers.DeviceList.Count; i++)
            {
                speakersCB.Items.Add("(" + speakers.DeviceList[i].Index + ") " + speakers.DeviceList[i].Name);
                if (speakers.DeviceList[i].Index == bot.Settings.SelectedSpeaker)
                    selectedIndex = i;
            }

            speakersCB.SelectedIndex = selectedIndex;
            speakersCB.Enabled = true;
        }

        private void ReloadSpeakers()
        {
            //string sp = bot.GetSpeakers();

            bot.GetSpeakers();

            speakers = JsonSettings.Load<Speakers>();
            speakers.Save();

            speakersCB.Items.Clear();
            speakersCB.ResetText();
            speakersCB.SelectedItem = null;
            speakersCB.SelectedIndex = -1;

            if(speakers.DeviceList.Count > 0)
                LoadSpeakers();
        }

        private void speakersRldBtn_Click(object sender, EventArgs e)
        {
            ReloadSpeakers();
        }

        private void speakersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (speakersCB.SelectedIndex < 0 || speakersCB.SelectedIndex >= speakers.DeviceList.Count)
            {
                bot.Settings.SelectedSpeaker = -1;
                return;
            }
            bot.Settings.SelectedSpeaker = speakers.DeviceList[speakersCB.SelectedIndex].Index;
            bot.Settings.Save();
        }

        private void processRldBtn_Click(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private void processesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (processesCB.SelectedIndex < 0 || processesCB.SelectedIndex >= processes.Count)
            {
                bot.SelectedProcess = null;
                return;
            }
            bot.SelectedProcess = processes[processesCB.SelectedIndex];
        }

        private void keyTB_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            bot.Settings.FishingKey = e.KeyCode;
            keyTB.Text = e.KeyData.ToString();
            startBtn.Enabled = true;
            startBtn.BackColor = blue;

            bot.Settings.Save();
        }

    }
}
