namespace video_portal.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string CommentText { get; set; }
        public int UserId { get; set; }
        public User User;
        public int VideoId { get; set; }
        public Video Video;


    };
}
