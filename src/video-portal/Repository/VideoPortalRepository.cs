using video_portal.Models;

namespace video_portal.Repository
{
    public class VideoPortalRepository : IVideoPortalRepository
    {
        private readonly IVideoPortalContext _context;
        public VideoPortalRepository(IVideoPortalContext context)
        {
            _context = context;
        }
        public Video GetVideoById(int videoId)
        {
            var data = _context.Videos.Where(v => v.VideoId == videoId).First();

            return data;
        }
        public IEnumerable<Video> GetVideos()
        {
            var data = _context.Videos;

            return data;
        }
        public Channel GetChannelById(int channelId)
        {
            var data = _context.Channels.Where(c => c.ChannelId == channelId).First();
            return data;
        }
        public IEnumerable<Channel> GetChannels()
        {
            var data = _context.Channels;

            return data;
        }
        public IEnumerable<Video> GetVideosByChannelId(int channelId)
        {
            var data = _context.Videos.ToList().Where(v => v.ChannelId == channelId);

            return data;
        }
        public IEnumerable<Comment> GetCommentsByVideoId(int videoId)
        {
            var data = _context.Comments.ToList().Where(c => c.VideoId == videoId);
            return data;
        }
        public void DeleteChannel(Channel channel)
        {
            if (GetVideosByChannelId(channel.ChannelId) == null) throw new InvalidOperationException();
            var deleted = _context.Channels.Where(c => c.ChannelId == channel.ChannelId).First();
            _context.Channels.Remove(deleted);
            _context.SaveChanges();
        }
        public void AddVideoToChannel(Channel channel, Video video)
        {
            if (channel == null || video == null) throw new InvalidOperationException();
            var selectedChannel = _context.Channels.Where(ch => ch.ChannelId == channel.ChannelId).First();
            var selectedVideo = _context.Videos.Where(v => v.VideoId == video.VideoId).First();
            selectedVideo.ChannelId = channel.ChannelId;
            _context.Videos.Update(selectedVideo);
        }
    }
}
