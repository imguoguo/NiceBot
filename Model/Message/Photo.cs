namespace NiceBot.Model.Message
{
    public class Photo : ISendable
    {
        public Types.Message Send(string token)
        {
            return new Types.Message();
        }
    }
}