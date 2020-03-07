using System.Collections.Generic;
using NiceBot.Model.Message;
using Flurl.Http;
using NiceBot.Model.Types;
using Newtonsoft.Json;

namespace NiceBot.Model
{
    public class Bot
    {
        private readonly string _token;
        private static readonly string API = "https://api.telegram.org/";
        
        public static string CallMethod(string token, string method, IDictionary<string, string> parameters)
        {
            var task = 
                $"{API}/bot{token}/{method}".PostJsonAsync(parameters).ReceiveString();
            
            task.Wait();
            var result = task.Result;
            return result;
        }

        public User GetMe()
        { 
            string tmp = Bot.CallMethod(_token, "getMe", new Dictionary<string, string>());
            Result<User> res = JsonConvert.DeserializeObject<Result<User>>(tmp);
            return res.result;
        }
        
        public Bot(string token)
        { 
            _token = token;
        }

        public Types.Message Commit(ISendable sendableObject)
        {
            return sendableObject.Send(_token);
        }
    }
}