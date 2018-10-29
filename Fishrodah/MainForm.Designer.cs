namespace Fishrodah
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flatSkin = new FlatUI.FormSkin();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.speakersRldBtn = new System.Windows.Forms.Button();
            this.speakersCB = new FlatUI.FlatComboBox();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.keyTB = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.logPanel = new System.Windows.Forms.Panel();
            this.logLabel = new FlatUI.FlatLabel();
            this.minimizeBtn = new FlatUI.FlatMini();
            this.closeBtn = new FlatUI.FlatClose();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.processPanel = new System.Windows.Forms.Panel();
            this.processRldBtn = new System.Windows.Forms.Button();
            this.processesCB = new FlatUI.FlatComboBox();
            this.flatSkin.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.logPanel.SuspendLayout();
            this.processPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flatSkin
            // 
            this.flatSkin.BackColor = System.Drawing.Color.White;
            this.flatSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.flatSkin.Controls.Add(this.flatLabel4);
            this.flatSkin.Controls.Add(this.panel3);
            this.flatSkin.Controls.Add(this.flatLabel3);
            this.flatSkin.Controls.Add(this.panel1);
            this.flatSkin.Controls.Add(this.flatLabel2);
            this.flatSkin.Controls.Add(this.logPanel);
            this.flatSkin.Controls.Add(this.minimizeBtn);
            this.flatSkin.Controls.Add(this.closeBtn);
            this.flatSkin.Controls.Add(this.flatLabel1);
            this.flatSkin.Controls.Add(this.processPanel);
            this.flatSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.flatSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatSkin.HeaderMaximize = false;
            this.flatSkin.Location = new System.Drawing.Point(0, 0);
            this.flatSkin.Margin = new System.Windows.Forms.Padding(2);
            this.flatSkin.Name = "flatSkin";
            this.flatSkin.Size = new System.Drawing.Size(485, 305);
            this.flatSkin.TabIndex = 0;
            this.flatSkin.Text = "Fishrodah";
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(335, 50);
            this.flatLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(79, 13);
            this.flatLabel4.TabIndex = 8;
            this.flatLabel4.Text = "Sound Source";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.speakersRldBtn);
            this.panel3.Controls.Add(this.speakersCB);
            this.panel3.Location = new System.Drawing.Point(328, 59);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 77);
            this.panel3.TabIndex = 9;
            // 
            // speakersRldBtn
            // 
            this.speakersRldBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.speakersRldBtn.FlatAppearance.BorderSize = 0;
            this.speakersRldBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speakersRldBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.speakersRldBtn.ForeColor = System.Drawing.Color.White;
            this.speakersRldBtn.Location = new System.Drawing.Point(9, 41);
            this.speakersRldBtn.Margin = new System.Windows.Forms.Padding(10);
            this.speakersRldBtn.Name = "speakersRldBtn";
            this.speakersRldBtn.Size = new System.Drawing.Size(131, 23);
            this.speakersRldBtn.TabIndex = 1;
            this.speakersRldBtn.Text = "Reload List";
            this.speakersRldBtn.UseVisualStyleBackColor = false;
            this.speakersRldBtn.Click += new System.EventHandler(this.speakersRldBtn_Click);
            // 
            // speakersCB
            // 
            this.speakersCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.speakersCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speakersCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.speakersCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speakersCB.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.speakersCB.ForeColor = System.Drawing.Color.White;
            this.speakersCB.FormattingEnabled = true;
            this.speakersCB.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.speakersCB.ItemHeight = 20;
            this.speakersCB.Location = new System.Drawing.Point(9, 11);
            this.speakersCB.Margin = new System.Windows.Forms.Padding(2);
            this.speakersCB.Name = "speakersCB";
            this.speakersCB.Size = new System.Drawing.Size(132, 26);
            this.speakersCB.TabIndex = 0;
            this.speakersCB.SelectedIndexChanged += new System.EventHandler(this.speakersCB_SelectedIndexChanged);
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(175, 50);
            this.flatLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(104, 13);
            this.flatLabel3.TabIndex = 6;
            this.flatLabel3.Text = "Fishing Button Key";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Location = new System.Drawing.Point(168, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 77);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.keyTB);
            this.panel2.Location = new System.Drawing.Point(9, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 21);
            this.panel2.TabIndex = 3;
            // 
            // keyTB
            // 
            this.keyTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.keyTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.keyTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.keyTB.Location = new System.Drawing.Point(4, 2);
            this.keyTB.Margin = new System.Windows.Forms.Padding(2);
            this.keyTB.Name = "keyTB";
            this.keyTB.ReadOnly = true;
            this.keyTB.Size = new System.Drawing.Size(124, 16);
            this.keyTB.TabIndex = 3;
            this.keyTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyTB_KeyDown);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.startBtn.Enabled = false;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(9, 41);
            this.startBtn.Margin = new System.Windows.Forms.Padding(2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(131, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start Bot";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(14, 138);
            this.flatLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(31, 13);
            this.flatLabel2.TabIndex = 5;
            this.flatLabel2.Text = "Logs";
            // 
            // logPanel
            // 
            this.logPanel.AutoScroll = true;
            this.logPanel.BackColor = System.Drawing.Color.Transparent;
            this.logPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logPanel.Controls.Add(this.logLabel);
            this.logPanel.Location = new System.Drawing.Point(8, 146);
            this.logPanel.Margin = new System.Windows.Forms.Padding(2);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(472, 152);
            this.logPanel.TabIndex = 4;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.BackColor = System.Drawing.Color.Transparent;
            this.logLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.logLabel.ForeColor = System.Drawing.Color.White;
            this.logLabel.Location = new System.Drawing.Point(4, 12);
            this.logLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(0, 13);
            this.logLabel.TabIndex = 0;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.White;
            this.minimizeBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.minimizeBtn.Font = new System.Drawing.Font("Marlett", 12F);
            this.minimizeBtn.Location = new System.Drawing.Point(445, 10);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(18, 18);
            this.minimizeBtn.TabIndex = 3;
            this.minimizeBtn.Text = "flatMini1";
            this.minimizeBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.closeBtn.Font = new System.Drawing.Font("Marlett", 10F);
            this.closeBtn.Location = new System.Drawing.Point(463, 10);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(18, 18);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "flatClose1";
            this.closeBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(15, 50);
            this.flatLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(77, 13);
            this.flatLabel1.TabIndex = 0;
            this.flatLabel1.Text = "WoW Process";
            // 
            // processPanel
            // 
            this.processPanel.BackColor = System.Drawing.Color.Transparent;
            this.processPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processPanel.Controls.Add(this.processRldBtn);
            this.processPanel.Controls.Add(this.processesCB);
            this.processPanel.Location = new System.Drawing.Point(8, 59);
            this.processPanel.Margin = new System.Windows.Forms.Padding(2);
            this.processPanel.Name = "processPanel";
            this.processPanel.Size = new System.Drawing.Size(152, 77);
            this.processPanel.TabIndex = 1;
            // 
            // processRldBtn
            // 
            this.processRldBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.processRldBtn.FlatAppearance.BorderSize = 0;
            this.processRldBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processRldBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.processRldBtn.ForeColor = System.Drawing.Color.White;
            this.processRldBtn.Location = new System.Drawing.Point(9, 41);
            this.processRldBtn.Margin = new System.Windows.Forms.Padding(10);
            this.processRldBtn.Name = "processRldBtn";
            this.processRldBtn.Size = new System.Drawing.Size(131, 23);
            this.processRldBtn.TabIndex = 1;
            this.processRldBtn.Text = "Reload List";
            this.processRldBtn.UseVisualStyleBackColor = false;
            this.processRldBtn.Click += new System.EventHandler(this.processRldBtn_Click);
            // 
            // processesCB
            // 
            this.processesCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.processesCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processesCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.processesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processesCB.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.processesCB.ForeColor = System.Drawing.Color.White;
            this.processesCB.FormattingEnabled = true;
            this.processesCB.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.processesCB.ItemHeight = 20;
            this.processesCB.Location = new System.Drawing.Point(9, 11);
            this.processesCB.Margin = new System.Windows.Forms.Padding(2);
            this.processesCB.Name = "processesCB";
            this.processesCB.Size = new System.Drawing.Size(132, 26);
            this.processesCB.TabIndex = 0;
            this.processesCB.SelectedIndexChanged += new System.EventHandler(this.processesCB_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 305);
            this.Controls.Add(this.flatSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fishrodah";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.flatSkin.ResumeLayout(false);
            this.flatSkin.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.logPanel.ResumeLayout(false);
            this.logPanel.PerformLayout();
            this.processPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin flatSkin;
        private FlatUI.FlatLabel flatLabel1;
        private System.Windows.Forms.Panel processPanel;
        private FlatUI.FlatMini minimizeBtn;
        private FlatUI.FlatClose closeBtn;
        private FlatUI.FlatComboBox processesCB;
        private System.Windows.Forms.Button processRldBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel logPanel;
        private FlatUI.FlatLabel logLabel;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatLabel flatLabel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox keyTB;
        private System.Windows.Forms.Panel panel2;
        private FlatUI.FlatLabel flatLabel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button speakersRldBtn;
        private FlatUI.FlatComboBox speakersCB;
    }
}