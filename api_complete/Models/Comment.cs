using System.Globalization;

namespace api_complete.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public required string Text { get; set; }
        public int UserId { get; set; } //

        public Article? Article { get; set; }
        public required int ArticleId { get; set; }  
    }
}
