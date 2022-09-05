using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordRaidBot
{
    public partial class SettingsForm : Form
    {

        private DiscordRaidBotForm mainForm;
        public SettingsForm(DiscordRaidBotForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            List<string> guildNames = mainForm.raidBot.getGuildList();
            foreach(String s in guildNames)
            {
                comboBoxGuildList.Items.Add(s);
            }
            comboBoxGuildList.SelectedIndex = 0;
            //showGuildInfo(mainForm.raidBot.getGuildByIndex(0));
        }

        private async void showGuildInfo(SocketGuild guild)
        {
            pictureBoxServerInfo.ImageLocation = guild.IconUrl;
            lblDescription.Text = guild.Description;
            lblServerInfoName.Text = guild.Name;
            lblServerInfoMembersCount.Text = $"{guild.MemberCount} członków";
            lblVoiceChannelCount.Text = $"Najwyższa rola: {guild.Roles.First<SocketRole>().Name}";
            lblTextChannelCount.Text = $"{guild.TextChannels.Count- guild.VoiceChannels.Count} kanałów tekstowych";
            lblVoiceChannelCount.Text = $"{guild.VoiceChannels.Count} kanałów głosowych";
            labelDate.Text = guild.CreatedAt.ToString();
            lblUpgrade.Text = $"{guild.PremiumTier}, {guild.PremiumSubscriptionCount} ulepszeń".Replace("None", "0");

            linkLabel.Text = "Tworzę..";
            var invite = await guild.GetInvitesAsync();
            if (invite.Count > 0)
            {
                linkLabel.Text = invite.First().Url;
                linkLabel.Enabled = true;
            }
            else
            {
                linkLabel.Text = "Brak zaproszeń";
                linkLabel.Enabled = false;
            }
        }

        private void comboBoxGuildList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            showGuildInfo(mainForm.raidBot.getGuildByIndex(comboBoxGuildList.SelectedIndex));
        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl(linkLabel.Text);
        }

        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void btnChooseGuild_Click(object sender, EventArgs e)
        {
            mainForm.setSelectedGuildIndex(comboBoxGuildList.SelectedIndex);
            MessageBox.Show("Wybrano serwer " + mainForm.raidBot.getGuildByIndex(comboBoxGuildList.SelectedIndex).Name);
        }
    }
}
