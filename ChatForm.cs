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
    public partial class ChatForm : Form
    {

        private DiscordRaidBotForm mainForm;
        public ChatForm(DiscordRaidBotForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            mainForm.raidBot._client.MessageReceived += MessageReceived;
        }

        private Task MessageReceived(SocketMessage msg)
        {
            
            if (msg.Author.IsBot)
            {
                return Task.CompletedTask;
            }
            try
            {
                mainForm.Invoke(new Action(delegate ()
                {
                    mainForm.chatForm.addMessage($"{msg.Author.Username} #{msg.Channel.Name}: {msg.ToString()}\n");
                }));
            }
            catch
            {

            }
            return Task.CompletedTask;
        }

        public void addMessage(string message)
        {
            richTextBox1.Text += message;
        }
        public void clear(string name)
        {
            richTextBox1.Text = "[INFO] Zmieniono serwer na " + name + "!\n";
        }

        public void UpdateChannelsList()
        {
            comboBox1.Items.Clear();
            foreach (SocketTextChannel textChannel in mainForm.raidBot.getGuildByIndex(mainForm.selectedGuildIndex).TextChannels)
            {
                comboBox1.Items.Add("#" + textChannel.Name);
            }
            
        }
        public List<SocketTextChannel> GetTextChannels()
        {
            List<SocketTextChannel> textChannels = new List<SocketTextChannel>();
            foreach (SocketTextChannel textChannel in mainForm.raidBot.getGuildByIndex(mainForm.selectedGuildIndex).TextChannels)
            {
                textChannels.Add(textChannel);
            }
            return textChannels;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = $"Napisz na #{GetTextChannels()[comboBox1.SelectedIndex]}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTextChannels()[comboBox1.SelectedIndex].SendMessageAsync(textBox1.Text);
            richTextBox1.Text += $"{mainForm.raidBot.getName()} [BOT] #{GetTextChannels()[comboBox1.SelectedIndex].Name}: {textBox1.Text}\n";
            textBox1.Text = "";
        }

        private void ChatForm_Shown(object sender, EventArgs e)
        {
            UpdateChannelsList();
            comboBox1.SelectedIndex = 0;
        }
    }
}
