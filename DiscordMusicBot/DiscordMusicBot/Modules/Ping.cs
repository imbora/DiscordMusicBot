﻿using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordMusicBot.Modules
{
    public class Ping : ModuleBase<SocketCommandContext>
    {
        [Command("Ping")]
        public async Task Pong()
        {
            await ReplyAsync("PONG!");
        }
    }
}
