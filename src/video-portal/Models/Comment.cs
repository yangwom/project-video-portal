using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace video_portal.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string CommentText { get; set; }

        [ForeignKey("UserId")]
        public string UserId;

        [ForeignKey("VideoId")]

        public string VideoId;

    };
}
