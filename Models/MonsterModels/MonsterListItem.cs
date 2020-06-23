using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.MonsterModels
{
    public class MonsterListItem
    {
        public int MonsterId { get; set; }
        [Display(Name ="Name")]
        public string MonsterName { get; set; }
        public string Creator { get; set; }
        public string Type { get; set; }
        [Display(Name ="Challenge Rating")]
        public string ChallengeRating { get; set; }
        [Display(Name ="Legendary")]
        public bool HasLegendary { get; set; }
    }
}
