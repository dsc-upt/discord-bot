// See https://aka.ms/new-console-template for more information

using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

DiscordSocketClient _client;


    _client = new DiscordSocketClient();

    _client.Log += Log;

    //  You can assign your bot token to a string, and pass that in to connect.
    //  This is, however, insecure, particularly if you plan to have your code hosted in a public repository.
    var token = "OTIyNDEyMDIzOTE5Mjg0MjQ1.YcBFJA.93F1v6kaE3eevFDdnv__vx1rZkM";

    // Some alternative options would be to keep your token in an Environment Variable or a standalone file.
    // var token = Environment.GetEnvironmentVariable("NameOfYourEnvironmentVariable");
    // var token = File.ReadAllText("token.txt");
    // var token = JsonConvert.DeserializeObject<AConfigurationClass>(File.ReadAllText("config.json")).Token;

    await _client.LoginAsync(TokenType.Bot, token);
    await _client.StartAsync();

    // Block this task until the program is closed.
    await Task.Delay(-1);

Task Log(LogMessage msg)
{
    Console.WriteLine(msg.ToString());
    return Task.CompletedTask;
}
