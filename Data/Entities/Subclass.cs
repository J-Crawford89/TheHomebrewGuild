using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Subclass
    {
        [Key]
        public int SubclassId { get; set; }
        [Required]
        public string SubclassName { get; set; }
        [Required]
        public Dictionary<string, string> Features { get; set; }
        [Required]
        [ForeignKey("CharacterClass")]
        public int CharacterClassId { get; set; }
        public virtual CharacterClass CharacterClass { get; set; }

    }
}
