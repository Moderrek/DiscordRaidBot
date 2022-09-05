using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordRaidBot
{
    public class RaidBot
    {
        public DiscordSocketClient _client;

        #region Configure
        public async Task MainAsync(string token, DiscordRaidBotForm callback)
        {
            var _config = new DiscordSocketConfig { MessageCacheSize = 100 };

            _client = new DiscordSocketClient(_config);
            _client.Log += Log;

            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

            _client.Ready += () =>
            {
                callback.Invoke(new Action(delegate ()
                {
                    callback.configurePanel();
                }));
                return Task.CompletedTask;
            };

            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
        #endregion

        #region Variables
        public string getName()
        {
            string username = _client.CurrentUser.Username;
            return username;
        }
        public string getAvatarUrl(ushort size)
        {
            string url = _client.CurrentUser.GetAvatarUrl(ImageFormat.Png, size);
            return url;
        }
        public List<string> getGuildList()
        {
            List<string> list = new List<string>(); 
            foreach(SocketGuild guild in _client.Guilds)
            {
                list.Add(guild.Name);
            }
            return list;
        }
        public SocketGuild getGuildByIndex(int index)
        {
            return _client.Guilds.ElementAt(index);
        }
        #endregion

        public void disable()
        {
            try
            {
                _client.LogoutAsync();
            }
            catch
            {

            }
            Application.Exit();
        }
    }
}
