using video_portal.Models;

namespace video_portal.Repository
{
    public class VideoPortalRepository : IVideoPortalRepository
    {
        private readonly IVideoPortalContext _context;
        public VideoPortalRepository(IVideoPortalContext context)
        {
            throw new NotImplementedException();
        }
        public Video GetVideoById(int videoId)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Video> GetVideos()
        {
            throw new NotImplementedException();
        }
        public Channel GetChannelById(int channelId)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Channel> GetChannels()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Video> GetVideosByChannelId(int channelId)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Comment> GetCommentsByVideoId(int videoId)
        {
            throw new NotImplementedException();
        }
        public void DeleteChannel(Channel channel)
        {
            throw new NotImplementedException();
        }
        public void AddVideoToChannel(Channel channel, Video video)
        {
            throw new NotImplementedException();
        }
    }
}
