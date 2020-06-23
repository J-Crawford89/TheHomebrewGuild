using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Enums;

namespace Data.Entities
{
    public class Race
    {
        [Key]
        public int RaceId { get; set; }
        [Required]
        public string RaceName { get; set; }
        [Required]
        public Dictionary<Ability, string> AbilityScoreIncrease { get; set; }
        [Required]
        public Size Size { get; set; }
        [Required]
        public string Speed { get; set; }
        [Required]
        public bool HasDarkvision { get; set; }
        public virtual ICollection<Subrace> Subraces { get; set; }
        [Required]
        public Dictionary<string, string> Traits { get; set; }
    }
}
