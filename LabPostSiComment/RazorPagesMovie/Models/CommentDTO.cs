using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class CommentDTO
    {
        [Key]
        public int CommentId { get; set; }
        public int PostPostId { get; set; }
        public string Text { get; set; }
        public virtual PostDTO Post { get; set; }
    }
}
