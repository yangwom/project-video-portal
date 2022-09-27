using video_portal.Models;

namespace video_portal.Repository
{
    public interface IVideoPortalRepository
    {
        Video GetVideoById(int videoId);
        IEnumerable<Video> GetVideos();
        Channel GetChannelById(int channel);
        IEnumerable<Channel> GetChannels();
        IEnumerable<Video> GetVideosByChannelId(int channelId);
        IEnumerable<Comment> GetCommentsByVideoId(int videoId);
        void DeleteChannel(Channel channel);
        void AddVideoToChannel(Channel channel, Video video);
    }
}
