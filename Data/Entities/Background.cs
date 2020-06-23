using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Enums;

namespace Data.Entities
{
    public class Background
    {
        [Key]
        public int BackgroundId { get; set; }
        [Required]
        public string BackgroundName { get; set; }
        [Required]
        public List<Skill> SkillProficiencies { get; set; }
    }
}
