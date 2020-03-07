namespace NiceBot.Model.Message
{
    public interface ISendable
    {
        public Types.Message Send(string token);
    }
}