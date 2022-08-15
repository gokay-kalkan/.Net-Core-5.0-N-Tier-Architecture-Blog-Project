using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public int BlogRating { get; set; }

        public bool CommentStatus { get; set; }
        public bool CommentCheckStatus { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog  { get; set; }
    }
}
