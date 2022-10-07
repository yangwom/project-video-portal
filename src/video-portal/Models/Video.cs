namespace video_portal.Models
{
    public class Video
    {
        public int VideoId;
        public string Title;
        public string? Description;
        public string Url;
        public int ChannelId;
        public Comment Comments;
    }
}
