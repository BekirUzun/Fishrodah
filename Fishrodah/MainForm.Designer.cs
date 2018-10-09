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
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.startBtn = new System.Windows.Forms.Button();
            this.logPanel = new System.Windows.Forms.Panel();
            this.logLabel = new FlatUI.FlatLabel();
            this.minimizeBtn = new FlatUI.FlatMini();
            this.closeBtn = new FlatUI.FlatClose();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.processPanel = new System.Windows.Forms.Panel();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.processesCB = new FlatUI.FlatComboBox();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.keyTB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flatSkin.SuspendLayout();
            this.logPanel.SuspendLayout();
            this.processPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flatSkin
            // 
            this.flatSkin.BackColor = System.Drawing.Color.White;
            this.flatSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
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
            this.flatSkin.Name = "flatSkin";
            this.flatSkin.Size = new System.Drawing.Size(435, 365);
            this.flatSkin.TabIndex = 0;
            this.flatSkin.Text = "Fishrodah";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(19, 161);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(38, 19);
            this.flatLabel2.TabIndex = 5;
            this.flatLabel2.Text = "Logs";
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.startBtn.Enabled = false;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(12, 51);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(175, 28);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start Bot";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // logPanel
            // 
            this.logPanel.AutoScroll = true;
            this.logPanel.BackColor = System.Drawing.Color.Transparent;
            this.logPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logPanel.Controls.Add(this.logLabel);
            this.logPanel.Location = new System.Drawing.Point(10, 171);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(416, 187);
            this.logPanel.TabIndex = 4;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.BackColor = System.Drawing.Color.Transparent;
            this.logLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.logLabel.ForeColor = System.Drawing.Color.White;
            this.logLabel.Location = new System.Drawing.Point(5, 15);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(0, 19);
            this.logLabel.TabIndex = 0;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.White;
            this.minimizeBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.minimizeBtn.Font = new System.Drawing.Font("Marlett", 12F);
            this.minimizeBtn.Location = new System.Drawing.Point(381, 12);
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
            this.closeBtn.Location = new System.Drawing.Point(405, 12);
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
            this.flatLabel1.Location = new System.Drawing.Point(20, 53);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(92, 19);
            this.flatLabel1.TabIndex = 0;
            this.flatLabel1.Text = "WoW Process";
            // 
            // processPanel
            // 
            this.processPanel.BackColor = System.Drawing.Color.Transparent;
            this.processPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processPanel.Controls.Add(this.reloadBtn);
            this.processPanel.Controls.Add(this.processesCB);
            this.processPanel.Location = new System.Drawing.Point(10, 64);
            this.processPanel.Name = "processPanel";
            this.processPanel.Size = new System.Drawing.Size(202, 94);
            this.processPanel.TabIndex = 1;
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.reloadBtn.FlatAppearance.BorderSize = 0;
            this.reloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reloadBtn.ForeColor = System.Drawing.Color.White;
            this.reloadBtn.Location = new System.Drawing.Point(12, 51);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(175, 28);
            this.reloadBtn.TabIndex = 1;
            this.reloadBtn.Text = "Reload List";
            this.reloadBtn.UseVisualStyleBackColor = false;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
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
            this.processesCB.Location = new System.Drawing.Point(12, 14);
            this.processesCB.Name = "processesCB";
            this.processesCB.Size = new System.Drawing.Size(175, 26);
            this.processesCB.TabIndex = 0;
            this.processesCB.SelectedIndexChanged += new System.EventHandler(this.processesCB_SelectedIndexChanged);
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(233, 53);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(124, 19);
            this.flatLabel3.TabIndex = 6;
            this.flatLabel3.Text = "Fishing Button Key";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Location = new System.Drawing.Point(224, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 94);
            this.panel1.TabIndex = 7;
            // 
            // keyTB
            // 
            this.keyTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.keyTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.keyTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.keyTB.Location = new System.Drawing.Point(5, 3);
            this.keyTB.Name = "keyTB";
            this.keyTB.ReadOnly = true;
            this.keyTB.Size = new System.Drawing.Size(165, 20);
            this.keyTB.TabIndex = 3;
            this.keyTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyTB_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.keyTB);
            this.panel2.Location = new System.Drawing.Point(12, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 26);
            this.panel2.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 365);
            this.Controls.Add(this.flatSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fishrodah";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.flatSkin.ResumeLayout(false);
            this.flatSkin.PerformLayout();
            this.logPanel.ResumeLayout(false);
            this.logPanel.PerformLayout();
            this.processPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin flatSkin;
        private FlatUI.FlatLabel flatLabel1;
        private System.Windows.Forms.Panel processPanel;
        private FlatUI.FlatMini minimizeBtn;
        private FlatUI.FlatClose closeBtn;
        private FlatUI.FlatComboBox processesCB;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel logPanel;
        private FlatUI.FlatLabel logLabel;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatLabel flatLabel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox keyTB;
        private System.Windows.Forms.Panel panel2;
    }
}