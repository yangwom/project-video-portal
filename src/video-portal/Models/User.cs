namespace video_portal.Models
{
    public class User
    {
        public int UserId;
        public string Username;
        public string Email;
        public ICollection<Channel> Channels;
        public ICollection<Comment> Comments;
    }
}
