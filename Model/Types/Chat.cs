namespace NiceBot.Model.Types
{
    public class Chat
    {
        public string id;
        public string type;
        public string title;
        public string username;
        public string first_name;
        public string last_name;
        public bool all_members_are_administrators;
        public string description;
        public string invite_link;
        public Message pinned_message;
        public string sticker_set_name;
        public bool can_set_sticker_set;
    }
}