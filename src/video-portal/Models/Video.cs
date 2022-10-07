namespace video_portal.Models
{
    public class Video
    {
        public int VideoId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string Url { get; set; }
        public int ChannelId { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
