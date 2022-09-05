namespace DiscordRaidBot
{
    partial class DiscordRaidBotForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscordRaidBotForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenuSettings = new System.Windows.Forms.Button();
            this.btnMenuLogs = new System.Windows.Forms.Button();
            this.btnMenuRaid = new System.Windows.Forms.Button();
            this.panelBotUser = new System.Windows.Forms.Panel();
            this.lblOnServerWorking = new System.Windows.Forms.Label();
            this.labelBotName = new System.Windows.Forms.Label();
            this.pictureBotAvatar = new System.Windows.Forms.PictureBox();
            this.labelBotStatus = new System.Windows.Forms.Label();
            this.btnBotDisable = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelBotUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBotAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Controls.Add(this.panelBotUser);
            this.panel1.Controls.Add(this.btnBotDisable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 600);
            this.panel1.TabIndex = 100000;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSize = true;
            this.panelMenu.Controls.Add(this.btnMenuSettings);
            this.panelMenu.Controls.Add(this.btnMenuLogs);
            this.panelMenu.Controls.Add(this.btnMenuRaid);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelMenu.Location = new System.Drawing.Point(0, 106);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(247, 442);
            this.panelMenu.TabIndex = 12;
            // 
            // btnMenuSettings
            // 
            this.btnMenuSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnMenuSettings.FlatAppearance.BorderSize = 0;
            this.btnMenuSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSettings.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuSettings.ForeColor = System.Drawing.Color.White;
            this.btnMenuSettings.Location = new System.Drawing.Point(3, 3);
            this.btnMenuSettings.Name = "btnMenuSettings";
            this.btnMenuSettings.Size = new System.Drawing.Size(244, 52);
            this.btnMenuSettings.TabIndex = 0;
            this.btnMenuSettings.Text = "Serwer";
            this.btnMenuSettings.UseVisualStyleBackColor = false;
            this.btnMenuSettings.Click += new System.EventHandler(this.btnMenuSettings_Click);
            // 
            // btnMenuLogs
            // 
            this.btnMenuLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnMenuLogs.FlatAppearance.BorderSize = 0;
            this.btnMenuLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuLogs.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuLogs.ForeColor = System.Drawing.Color.White;
            this.btnMenuLogs.Location = new System.Drawing.Point(3, 61);
            this.btnMenuLogs.Name = "btnMenuLogs";
            this.btnMenuLogs.Size = new System.Drawing.Size(244, 52);
            this.btnMenuLogs.TabIndex = 2;
            this.btnMenuLogs.Text = "Chat";
            this.btnMenuLogs.UseVisualStyleBackColor = false;
            this.btnMenuLogs.Click += new System.EventHandler(this.btnMenuLogs_Click);
            // 
            // btnMenuRaid
            // 
            this.btnMenuRaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMenuRaid.FlatAppearance.BorderSize = 0;
            this.btnMenuRaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRaid.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuRaid.ForeColor = System.Drawing.Color.White;
            this.btnMenuRaid.Location = new System.Drawing.Point(3, 119);
            this.btnMenuRaid.Name = "btnMenuRaid";
            this.btnMenuRaid.Size = new System.Drawing.Size(244, 52);
            this.btnMenuRaid.TabIndex = 1;
            this.btnMenuRaid.Text = "Bombardowanie";
            this.btnMenuRaid.UseVisualStyleBackColor = false;
            this.btnMenuRaid.Click += new System.EventHandler(this.btnMenuRaid_Click);
            // 
            // panelBotUser
            // 
            this.panelBotUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelBotUser.Controls.Add(this.lblOnServerWorking);
            this.panelBotUser.Controls.Add(this.labelBotName);
            this.panelBotUser.Controls.Add(this.pictureBotAvatar);
            this.panelBotUser.Controls.Add(this.labelBotStatus);
            this.panelBotUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotUser.Location = new System.Drawing.Point(0, 0);
            this.panelBotUser.Name = "panelBotUser";
            this.panelBotUser.Size = new System.Drawing.Size(247, 106);
            this.panelBotUser.TabIndex = 11;
            // 
            // lblOnServerWorking
            // 
            this.lblOnServerWorking.Font = new System.Drawing.Font("Yu Gothic UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOnServerWorking.ForeColor = System.Drawing.Color.White;
            this.lblOnServerWorking.Location = new System.Drawing.Point(77, 75);
            this.lblOnServerWorking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOnServerWorking.Name = "lblOnServerWorking";
            this.lblOnServerWorking.Size = new System.Drawing.Size(166, 30);
            this.lblOnServerWorking.TabIndex = 11;
            // 
            // labelBotName
            // 
            this.labelBotName.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBotName.ForeColor = System.Drawing.Color.White;
            this.labelBotName.Location = new System.Drawing.Point(77, 22);
            this.labelBotName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBotName.Name = "labelBotName";
            this.labelBotName.Size = new System.Drawing.Size(170, 30);
            this.labelBotName.TabIndex = 8;
            this.labelBotName.Text = "Discord Raid Bot";
            // 
            // pictureBotAvatar
            // 
            this.pictureBotAvatar.Location = new System.Drawing.Point(12, 22);
            this.pictureBotAvatar.Name = "pictureBotAvatar";
            this.pictureBotAvatar.Size = new System.Drawing.Size(60, 60);
            this.pictureBotAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBotAvatar.TabIndex = 10;
            this.pictureBotAvatar.TabStop = false;
            // 
            // labelBotStatus
            // 
            this.labelBotStatus.AutoSize = true;
            this.labelBotStatus.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBotStatus.ForeColor = System.Drawing.Color.LightGreen;
            this.labelBotStatus.Location = new System.Drawing.Point(77, 45);
            this.labelBotStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBotStatus.Name = "labelBotStatus";
            this.labelBotStatus.Size = new System.Drawing.Size(74, 30);
            this.labelBotStatus.TabIndex = 9;
            this.labelBotStatus.Text = "Online";
            // 
            // btnBotDisable
            // 
            this.btnBotDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBotDisable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBotDisable.FlatAppearance.BorderSize = 0;
            this.btnBotDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBotDisable.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBotDisable.ForeColor = System.Drawing.Color.White;
            this.btnBotDisable.Location = new System.Drawing.Point(0, 548);
            this.btnBotDisable.Name = "btnBotDisable";
            this.btnBotDisable.Size = new System.Drawing.Size(247, 52);
            this.btnBotDisable.TabIndex = 4;
            this.btnBotDisable.Text = "Wyłącz BOT\'a";
            this.btnBotDisable.UseVisualStyleBackColor = false;
            this.btnBotDisable.Click += new System.EventHandler(this.btnBotDisable_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(247, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(668, 600);
            this.panelChildForm.TabIndex = 100001;
            // 
            // DiscordRaidBotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(915, 600);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DiscordRaidBotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord Raid Bot";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelBotUser.ResumeLayout(false);
            this.panelBotUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBotAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label labelBotStatus;
        private Label labelBotName;
        private PictureBox pictureBotAvatar;
        private Panel panelBotUser;
        private FlowLayoutPanel panelMenu;
        private Button btnMenuSettings;
        private Button btnMenuLogs;
        private Button btnMenuRaid;
        private Button btnBotDisable;
        private Panel panelChildForm;
        private Label lblOnServerWorking;
    }
}