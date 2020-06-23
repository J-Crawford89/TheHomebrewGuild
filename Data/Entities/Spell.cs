using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Enums;

namespace Data.Entities
{
    public class Spell
    {
        [Key]
        public int SpellId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string SpellName { get; set; }
        [Required]
        public int SpellLevel { get; set; }
        [Required]
        public School School { get; set; }
        [Required]
        public bool IsRitual { get; set; }
        [Required]
        public string CastingTime { get; set; }
        [Required]
        public string Range { get; set; }
        [Required]
        public bool HasVerbalComponent { get; set; }
        [Required]
        public bool HasSomaticComponent { get; set; }
        [Required]
        public bool HasMaterialComponent { get; set; }
        public string MaterialComponent { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public ICollection<CharacterClass> ClassSpellLists { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public bool IsDeleted { get; set; }
    }
}
