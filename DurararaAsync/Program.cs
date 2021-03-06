﻿using System;
using System.Threading.Tasks;

using DrrrAsync;
using DrrrAsync.Objects;
using DrrrAsync.Extensions;

namespace DurararaAsync
{

    class Program
    {
        static async Task Main(string[] args)
        {
            Bot DrrrBot = new Bot { Name = "Welne Oren3", Icon = DrrrIcon.Kuromu2x };
            DrrrBot.RegisterCommands<TestModule>();

            await DrrrBot.Login();
            await DrrrBot.Connect("WIZARD TOWER");

            await Task.Delay(-1);

            Console.ReadKey();
        }
    }
}
