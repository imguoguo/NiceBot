using NiceBot.Model;
using NiceBot.Model.Message;
using NiceBot.Model.Types;

namespace NiceBot
{
    class Program
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            NLog.LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration("NLog.config");
            Bot testBot = new Bot("BOT_TOKEN:HERE");
            
            User botInfo = testBot.GetMe();
            Text testText = new Text();
            testText.Body = $"Hello World C#! I'm @{botInfo.username}!";
            testText.ChatId = "-1234567890";
            Logger.Info( $"Hello World C#! I'm @{botInfo.username}!");

            testBot.Commit(testText);
        }
    }
}