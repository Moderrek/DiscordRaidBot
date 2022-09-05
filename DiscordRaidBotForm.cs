using Discord.WebSocket;

namespace DiscordRaidBot
{
    public partial class DiscordRaidBotForm : Form
    {

        public RaidBot raidBot;
        public ChatForm chatForm;

        public DiscordRaidBotForm()
        {
            InitializeComponent();

            panelBotUser.Visible = false;
            panelMenu.Visible = false;
            btnBotDisable.Visible = false;

            openChildForm(new TokenForm(this));
        }

        public void StartBot(string token)
        {
            raidBot = new RaidBot();
            Task task = raidBot.MainAsync(token, this);
        }

        private void btnBotDisable_Click(object sender, EventArgs e)
        {
            if(raidBot != null) {
                raidBot.disable();
            }
            else
            {
                Application.Exit();
            }
        }


        #region Panel Menu

        private Form activeForm = null;
        public int selectedGuildIndex = -1;
        public void setSelectedGuildIndex(int index)
        {
            selectedGuildIndex = index;
            if (chatForm == null)
            {
                chatForm = new ChatForm(this);
            }
            chatForm.clear(raidBot.getGuildByIndex(index).Name);
            lblOnServerWorking.Text = $"Operacja na {raidBot.getGuildByIndex(index).Name}";
            btnMenuLogs.Enabled = true;
            btnMenuRaid.Enabled = true;
        }

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                if(activeForm.Name == childForm.Name)
                {
                    return;
                }
                if (activeForm.Name == "ChatForm")
                {
                    activeForm.Hide();
                }
                else
                {
                    activeForm.Close();
                }
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void configurePanel()
        {
            openChildForm(new SettingsForm(this));

            labelBotName.Text = raidBot.getName();
            pictureBotAvatar.ImageLocation = raidBot.getAvatarUrl(60);
            panelBotUser.Visible = true;
            panelMenu.Visible = true;
            btnBotDisable.Visible = true;

            btnMenuLogs.Enabled = false;
            btnMenuRaid.Enabled = false;
        }
        #endregion

        private void btnMenuSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new SettingsForm(this));
        }

        private void btnMenuLogs_Click(object sender, EventArgs e)
        {
            openChildForm(chatForm);
        }

        private void btnMenuRaid_Click(object sender, EventArgs e)
        {
            openChildForm(new NukeForm(this));
        }
    }
}
