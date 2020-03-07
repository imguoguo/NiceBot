namespace NiceBot.Model.Types
{
    public class Message
    {
        public int message_id;
        public User from;
        public int date;
        public Chat chat;
        public User forward_from;
        public Chat forward_from_chat;
        public int forward_from_message_id;
        public string forward_signature;
        public string forward_sender_name;
        public int forward_date;
        public Message reply_to_message;
        public int edit_date;
        public string media_group_id;
        public string author_signature;
        public string text;
        // TODO entities caption_entities audio document animation game photo sticker video voice video_note contact location venue poll new_chat_members
        // TODO  new_chat_photo
        public string caption;
        public User left_chat_member;
        public string new_chat_title;
    }
}