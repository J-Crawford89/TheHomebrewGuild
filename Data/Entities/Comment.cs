using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string Content { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? LastUpdated { get; set; }

    }
}
