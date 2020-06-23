using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Reply
    {
        [Key]
        public int ReplyId { get; set; }
        [Required]
        public int OwnerId { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        [ForeignKey("Comment")]
        public int CommentId { get; set; }
        public virtual Comment  Comment { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? LastUpdated { get; set; }

    }
}
