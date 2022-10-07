namespace video_portal.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public ICollection<Channel> Channels { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
