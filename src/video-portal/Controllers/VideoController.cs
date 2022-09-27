using Microsoft.AspNetCore.Mvc;
using video_portal.Repository;

namespace video_portal.Controllers
{
    [ApiController]
    [Route("api")]
    public class VideoPortalController : Controller
    {
        private readonly IVideoPortalRepository _repository;
        public VideoPortalController(IVideoPortalRepository repository)
        {
            _repository = repository;
        }

        /// <summary> This function list a video</summary>
        /// <param name="id"> a video id</param>
        /// <returns> a video list</returns>
        [HttpGet("video/{id}")]
        public IActionResult GetVideo(int id)
        {
            var video = _repository.GetVideoById(id);
            if (video == null)
            {
                return NotFound();
            }
            return Ok(video);
        }

        /// <summary> This function return a list of videos</summary>
        /// <returns> a video list</returns>
        [HttpGet("video")]
        public IActionResult GetVideos()
        {
            return Ok(_repository.GetVideos());
        }

        /// <summary> This function return a channel</summary>
        /// <param name="id"> a channel id</param>
        /// <returns> a channel</returns>
        [HttpGet("channel/{id}")]
        public IActionResult GetChannel(int id)
        {
            return Ok(_repository.GetChannelById(id));
        }

        /// <summary> This function return a list of channels</summary>
        /// <returns> a channel list</returns>
        [HttpGet("channel")]
        public IActionResult GetChannels()
        {
            return Ok(_repository.GetChannels());
        }

        /// <summary> This function return a list of videos of channel</summary>
        /// <param name="id"> a channel id</param>
        /// <returns> a video list</returns>
        [HttpGet("channel/{id}/video")]
        public IActionResult GetVideosByChannel(int id)
        {
            return Ok(_repository.GetVideosByChannelId(id));
        }

        /// <summary> This function return a list of comments of video</summary>
        /// <param name="id"> a video id</param>
        /// <returns> a comment list</returns>
        [HttpGet("video/{id}/comment")]
        public IActionResult GetCommentsByVideo(int id)
        {
            return Ok(_repository.GetCommentsByVideoId(id));
        }

        /// <summary> This function deletes a channel</summary>
        /// <param name="id"> a channel id</param>
        /// <returns> a channel</returns>
        [HttpDelete("channel/{id}")]
        public IActionResult DeleteChannel(int id)
        {
            var channel = _repository.GetChannelById(id);
            if (channel == null)
            {
                return NotFound();
            }
            _repository.DeleteChannel(channel);
            return Ok(channel);
        }

        /// <summary> This function add a video to a channel</summary>
        /// <param name="channelId"> a channel id</param>
        /// <param name="videoId"> a video id</param>
        /// <returns> a video</returns>
        [HttpPost("channel/{channelId}/video/{videoId}")]
        public IActionResult AddVideoToChannel(int channelId, int videoId)
        {
            var channel = _repository.GetChannelById(channelId);
            if (channel == null)
            {
                return NotFound();
            }
            var video = _repository.GetVideoById(videoId);
            if (video == null)
            {
                return NotFound();
            }
            _repository.AddVideoToChannel(channel, video);
            return Ok(video);
        }
    }
}