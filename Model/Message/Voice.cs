namespace NiceBot.Model.Message
{
    public class Voice : ISendable
    {
        public Types.Message Send(string token)
        {
            return new Types.Message();
        }
    }
}