using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace video_portal.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string CommentText { get; set; }

        public User User;
        public int UserId { get; set; }

        public Video Video;
        public int VideoId { get; set; }

    };
}
