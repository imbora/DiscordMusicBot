using Newtonsoft.Json;
using DiscordMusicBot.Entities;
using System.IO;

namespace DiscordMusicBot.Services
{
    public class ConfigService
    {
        public Config GetConfig()
        {         
                var file = "Config.json";
                var data = File.ReadAllText(file);
                return JsonConvert.DeserializeObject<Config>(data);         
        }
    }
}
