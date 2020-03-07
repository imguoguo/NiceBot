using System.Collections.Generic;
using Newtonsoft.Json;

namespace NiceBot.Model.Message
{
    public class Text : ISendable
    {
        public string ChatId { get; set; }
        public string Body { get; set; }
        public string ParseMode { get; set; }
        public bool DisableWebPagePreview { get; set; }
        
        public Text()
        {
            ParseMode = "HTML";
        }
        
        public Types.Message Send(string token)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("chat_id", ChatId);
            parameters.Add("text", Body);
            parameters.Add("parse_mode", ParseMode);
            parameters.Add("disable_web_page_preview", DisableWebPagePreview.ToString());
            string res = Bot.CallMethod(token, "sendMessage", parameters);
            var result = JsonConvert.DeserializeObject<Types.Result<Types.Message>>(res);
            return result.result;
        }
    }
}