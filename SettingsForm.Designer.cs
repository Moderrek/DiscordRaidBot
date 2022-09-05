namespace DiscordRaidBot
{
    partial class SettingsForm
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
            this.panelMenuSettings = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUpgrade = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.lblTextChannelCount = new System.Windows.Forms.Label();
            this.lblVoiceChannelCount = new System.Windows.Forms.Label();
            this.lblServerInfoMembersCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblServerInfoName = new System.Windows.Forms.Label();
            this.pictureBoxServerInfo = new System.Windows.Forms.PictureBox();
            this.comboBoxGuildList = new System.Windows.Forms.ComboBox();
            this.btnChooseGuild = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panelMenuSettings.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuSettings
            // 
            this.panelMenuSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelMenuSettings.Controls.Add(this.panel2);
            this.panelMenuSettings.Controls.Add(this.comboBoxGuildList);
            this.panelMenuSettings.Controls.Add(this.btnChooseGuild);
            this.panelMenuSettings.Controls.Add(this.label8);
            this.panelMenuSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuSettings.Location = new System.Drawing.Point(0, 0);
            this.panelMenuSettings.Margin = new System.Windows.Forms.Padding(5);
            this.panelMenuSettings.Name = "panelMenuSettings";
            this.panelMenuSettings.Size = new System.Drawing.Size(668, 600);
            this.panelMenuSettings.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblUpgrade);
            this.panel2.Controls.Add(this.lblDescription);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelDate);
            this.panel2.Controls.Add(this.linkLabel);
            this.panel2.Controls.Add(this.lblTextChannelCount);
            this.panel2.Controls.Add(this.lblVoiceChannelCount);
            this.panel2.Controls.Add(this.lblServerInfoMembersCount);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblServerInfoName);
            this.panel2.Controls.Add(this.pictureBoxServerInfo);
            this.panel2.Location = new System.Drawing.Point(28, 159);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 326);
            this.panel2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(21, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Poziom serwera:";
            // 
            // lblUpgrade
            // 
            this.lblUpgrade.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUpgrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(250)))));
            this.lblUpgrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUpgrade.Location = new System.Drawing.Point(172, 132);
            this.lblUpgrade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUpgrade.Name = "lblUpgrade";
            this.lblUpgrade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUpgrade.Size = new System.Drawing.Size(154, 25);
            this.lblUpgrade.TabIndex = 19;
            this.lblUpgrade.Text = "0";
            this.lblUpgrade.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDescription.Location = new System.Drawing.Point(21, 168);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescription.Size = new System.Drawing.Size(305, 83);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "Opis";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(336, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Utworzony";
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(336, 80);
            this.labelDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(231, 26);
            this.labelDate.TabIndex = 16;
            this.labelDate.Text = "00-00-0000 00:00";
            this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel.LinkColor = System.Drawing.Color.White;
            this.linkLabel.Location = new System.Drawing.Point(21, 287);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(173, 30);
            this.linkLabel.TabIndex = 15;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Dołącz na serwer";
            this.linkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // lblTextChannelCount
            // 
            this.lblTextChannelCount.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTextChannelCount.ForeColor = System.Drawing.Color.White;
            this.lblTextChannelCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTextChannelCount.Location = new System.Drawing.Point(336, 121);
            this.lblTextChannelCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTextChannelCount.Name = "lblTextChannelCount";
            this.lblTextChannelCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTextChannelCount.Size = new System.Drawing.Size(231, 25);
            this.lblTextChannelCount.TabIndex = 14;
            this.lblTextChannelCount.Text = "0 kanałów tekstowych";
            // 
            // lblVoiceChannelCount
            // 
            this.lblVoiceChannelCount.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVoiceChannelCount.ForeColor = System.Drawing.Color.White;
            this.lblVoiceChannelCount.Location = new System.Drawing.Point(336, 157);
            this.lblVoiceChannelCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVoiceChannelCount.Name = "lblVoiceChannelCount";
            this.lblVoiceChannelCount.Size = new System.Drawing.Size(231, 25);
            this.lblVoiceChannelCount.TabIndex = 13;
            this.lblVoiceChannelCount.Text = "0 kanałów głosowych";
            // 
            // lblServerInfoMembersCount
            // 
            this.lblServerInfoMembersCount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServerInfoMembersCount.ForeColor = System.Drawing.Color.White;
            this.lblServerInfoMembersCount.Location = new System.Drawing.Point(109, 81);
            this.lblServerInfoMembersCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblServerInfoMembersCount.Name = "lblServerInfoMembersCount";
            this.lblServerInfoMembersCount.Size = new System.Drawing.Size(231, 40);
            this.lblServerInfoMembersCount.TabIndex = 12;
            this.lblServerInfoMembersCount.Text = "0 członków";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Informacje o serwerze";
            // 
            // lblServerInfoName
            // 
            this.lblServerInfoName.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServerInfoName.ForeColor = System.Drawing.Color.White;
            this.lblServerInfoName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblServerInfoName.Location = new System.Drawing.Point(109, 50);
            this.lblServerInfoName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblServerInfoName.Name = "lblServerInfoName";
            this.lblServerInfoName.Size = new System.Drawing.Size(231, 40);
            this.lblServerInfoName.TabIndex = 11;
            this.lblServerInfoName.Text = "Nazwa serwera";
            // 
            // pictureBoxServerInfo
            // 
            this.pictureBoxServerInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxServerInfo.Location = new System.Drawing.Point(21, 50);
            this.pictureBoxServerInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxServerInfo.Name = "pictureBoxServerInfo";
            this.pictureBoxServerInfo.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxServerInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxServerInfo.TabIndex = 11;
            this.pictureBoxServerInfo.TabStop = false;
            // 
            // comboBoxGuildList
            // 
            this.comboBoxGuildList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.comboBoxGuildList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGuildList.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGuildList.ForeColor = System.Drawing.Color.White;
            this.comboBoxGuildList.FormattingEnabled = true;
            this.comboBoxGuildList.Location = new System.Drawing.Point(28, 75);
            this.comboBoxGuildList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxGuildList.Name = "comboBoxGuildList";
            this.comboBoxGuildList.Size = new System.Drawing.Size(618, 45);
            this.comboBoxGuildList.TabIndex = 7;
            this.comboBoxGuildList.SelectedIndexChanged += new System.EventHandler(this.comboBoxGuildList_SelectedIndexChanged_1);
            // 
            // btnChooseGuild
            // 
            this.btnChooseGuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnChooseGuild.FlatAppearance.BorderSize = 0;
            this.btnChooseGuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseGuild.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChooseGuild.ForeColor = System.Drawing.Color.White;
            this.btnChooseGuild.Location = new System.Drawing.Point(28, 507);
            this.btnChooseGuild.Margin = new System.Windows.Forms.Padding(5);
            this.btnChooseGuild.Name = "btnChooseGuild";
            this.btnChooseGuild.Size = new System.Drawing.Size(293, 60);
            this.btnChooseGuild.TabIndex = 6;
            this.btnChooseGuild.Text = "Wybierz serwer";
            this.btnChooseGuild.UseVisualStyleBackColor = false;
            this.btnChooseGuild.Click += new System.EventHandler(this.btnChooseGuild_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 37);
            this.label8.TabIndex = 0;
            this.label8.Text = "Wybierz serwer";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(668, 600);
            this.Controls.Add(this.panelMenuSettings);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.panelMenuSettings.ResumeLayout(false);
            this.panelMenuSettings.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServerInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenuSettings;
        private Panel panel2;
        private Label lblServerInfoMembersCount;
        private Label label5;
        private Label lblServerInfoName;
        private PictureBox pictureBoxServerInfo;
        private ComboBox comboBoxGuildList;
        private Button btnChooseGuild;
        private Label label8;
        private Label lblVoiceChannelCount;
        private Label lblTextChannelCount;
        private LinkLabel linkLabel;
        private Label label2;
        private Label labelDate;
        private Label lblDescription;
        private Label label3;
        private Label lblUpgrade;
    }
}