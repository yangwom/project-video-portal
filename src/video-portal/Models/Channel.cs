using System.ComponentModel.DataAnnotations;

namespace video_portal.Models
{
    public class Channel
    {
    public int ChannelId { get; set; }

    public string ChannelName { get; set; }

    public string? ChannelDescription { get; set; }

    public string Url { get; set;  }

    public ICollection<Video> Videos;
    public ICollection<User> Owers;
};
}
