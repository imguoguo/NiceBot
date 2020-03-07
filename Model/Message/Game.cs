namespace NiceBot.Model.Message
{
    public class Game : ISendable
    {
        public Types.Message Send(string token)
        {
            return new Types.Message();
        }
    }
}