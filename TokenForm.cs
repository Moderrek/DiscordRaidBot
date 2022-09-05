using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordRaidBot
{
    public partial class TokenForm : Form
    {

        private DiscordRaidBotForm mainForm;
        private bool blocked = false;

        public TokenForm(DiscordRaidBotForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            btnStartBot.Enabled = false;
        }

        private void btnStartBot_Click(object sender, EventArgs e)
        {
            blocked = true;
            btnStartBot.Enabled = false;
            string token = textBoxBotToken.Text;
            mainForm.StartBot(token);
        }

        private void textBoxBotToken_TextChanged(object sender, EventArgs e)
        {
            if (blocked)
            {
                return;
            }

            string value = textBoxBotToken.Text;
            if (string.IsNullOrEmpty(value))
            {
                btnStartBot.Enabled = false;
            }
            else
            {
                btnStartBot.Enabled = true;
            }
        }
    }
}
