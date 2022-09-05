namespace DiscordRaidBot
{
    partial class NukeForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxDeleteChannels = new System.Windows.Forms.CheckBox();
            this.checkBoxFillServerChannels = new System.Windows.Forms.CheckBox();
            this.checkBoxSpam = new System.Windows.Forms.CheckBox();
            this.textBoxSpam = new System.Windows.Forms.TextBox();
            this.checkBoxWarn = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWarn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxChannelsFillName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(12, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "WYSADŹ!!!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxDeleteChannels
            // 
            this.checkBoxDeleteChannels.AutoSize = true;
            this.checkBoxDeleteChannels.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDeleteChannels.Location = new System.Drawing.Point(36, 52);
            this.checkBoxDeleteChannels.Name = "checkBoxDeleteChannels";
            this.checkBoxDeleteChannels.Size = new System.Drawing.Size(216, 29);
            this.checkBoxDeleteChannels.TabIndex = 1;
            this.checkBoxDeleteChannels.Text = "Usuń wszystkie kanały";
            this.checkBoxDeleteChannels.UseVisualStyleBackColor = true;
            this.checkBoxDeleteChannels.CheckedChanged += new System.EventHandler(this.checkBoxDeleteChannels_CheckedChanged);
            // 
            // checkBoxFillServerChannels
            // 
            this.checkBoxFillServerChannels.AutoSize = true;
            this.checkBoxFillServerChannels.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxFillServerChannels.Location = new System.Drawing.Point(300, 52);
            this.checkBoxFillServerChannels.Name = "checkBoxFillServerChannels";
            this.checkBoxFillServerChannels.Size = new System.Drawing.Size(231, 29);
            this.checkBoxFillServerChannels.TabIndex = 2;
            this.checkBoxFillServerChannels.Text = "Zapełń serwer kanałami";
            this.checkBoxFillServerChannels.UseVisualStyleBackColor = true;
            this.checkBoxFillServerChannels.CheckedChanged += new System.EventHandler(this.checkBoxFillServerChannels_CheckedChanged);
            // 
            // checkBoxSpam
            // 
            this.checkBoxSpam.AutoSize = true;
            this.checkBoxSpam.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSpam.Location = new System.Drawing.Point(36, 139);
            this.checkBoxSpam.Name = "checkBoxSpam";
            this.checkBoxSpam.Size = new System.Drawing.Size(200, 29);
            this.checkBoxSpam.TabIndex = 3;
            this.checkBoxSpam.Text = "Spamuj na kanałach";
            this.checkBoxSpam.UseVisualStyleBackColor = true;
            this.checkBoxSpam.CheckedChanged += new System.EventHandler(this.checkBoxSpam_CheckedChanged);
            // 
            // textBoxSpam
            // 
            this.textBoxSpam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBoxSpam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSpam.ForeColor = System.Drawing.Color.White;
            this.textBoxSpam.Location = new System.Drawing.Point(300, 191);
            this.textBoxSpam.Multiline = true;
            this.textBoxSpam.Name = "textBoxSpam";
            this.textBoxSpam.PlaceholderText = "@everyone BOMBARDOWANIE";
            this.textBoxSpam.Size = new System.Drawing.Size(332, 90);
            this.textBoxSpam.TabIndex = 4;
            // 
            // checkBoxWarn
            // 
            this.checkBoxWarn.AutoSize = true;
            this.checkBoxWarn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxWarn.Location = new System.Drawing.Point(36, 338);
            this.checkBoxWarn.Name = "checkBoxWarn";
            this.checkBoxWarn.Size = new System.Drawing.Size(161, 29);
            this.checkBoxWarn.TabIndex = 5;
            this.checkBoxWarn.Text = "Ostrzeż o ataku";
            this.checkBoxWarn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(300, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 75);
            this.label1.TabIndex = 6;
            this.label1.Text = "Przed spamowaniem stwórz jeden kanał na którym zostanie wysłana wiadomość\r\n";
            // 
            // textBoxWarn
            // 
            this.textBoxWarn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBoxWarn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWarn.ForeColor = System.Drawing.Color.White;
            this.textBoxWarn.Location = new System.Drawing.Point(300, 416);
            this.textBoxWarn.Multiline = true;
            this.textBoxWarn.Name = "textBoxWarn";
            this.textBoxWarn.PlaceholderText = "@everyone Uwaga!! Za chwilę spadnie bomba atomowa na NAZWA SERWERA";
            this.textBoxWarn.Size = new System.Drawing.Size(332, 90);
            this.textBoxWarn.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(300, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 56);
            this.label2.TabIndex = 8;
            this.label2.Text = "Każda linijka jest osobną wiadomościa";
            // 
            // textBoxChannelsFillName
            // 
            this.textBoxChannelsFillName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBoxChannelsFillName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChannelsFillName.ForeColor = System.Drawing.Color.White;
            this.textBoxChannelsFillName.Location = new System.Drawing.Point(300, 87);
            this.textBoxChannelsFillName.Name = "textBoxChannelsFillName";
            this.textBoxChannelsFillName.PlaceholderText = "#nazwa-kanału";
            this.textBoxChannelsFillName.Size = new System.Drawing.Size(332, 20);
            this.textBoxChannelsFillName.TabIndex = 9;
            // 
            // NukeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(668, 600);
            this.Controls.Add(this.textBoxChannelsFillName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWarn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxWarn);
            this.Controls.Add(this.textBoxSpam);
            this.Controls.Add(this.checkBoxSpam);
            this.Controls.Add(this.checkBoxFillServerChannels);
            this.Controls.Add(this.checkBoxDeleteChannels);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NukeForm";
            this.Text = "NukeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private CheckBox checkBoxDeleteChannels;
        private CheckBox checkBoxFillServerChannels;
        private CheckBox checkBoxSpam;
        private TextBox textBoxSpam;
        private CheckBox checkBoxWarn;
        private Label label1;
        private TextBox textBoxWarn;
        private Label label2;
        private TextBox textBoxChannelsFillName;
    }
}