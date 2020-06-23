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
    public class Monster
    {
        [Key]
        public int MonsterId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string MonsterName { get; set; }
        [Required]
        public Size Size { get; set; }
        [Required]
        public MonsterType Type { get; set; }
        [Required]
        public Alignment Alignment { get; set; }
        [Required]
        public int ArmorClass { get; set; }
        public string ArmorType { get; set; }
        [Required]
        public int HitPoints { get; set; }
        public string HitPointEquation { get; set; }
        [Required]
        public string Speed { get; set; }
        [Required]
        public int Strength { get; set; }
        [Required]
        public int Dexterity { get; set; }
        [Required]
        public int Constitution { get; set; }
        [Required]
        public int Intelligence { get; set; }
        [Required]
        public int Wisdom { get; set; }
        [Required]
        public int Charisma { get; set; }
        public Dictionary<Ability, string> SavingThrows { get; set; }
        public Dictionary<Skill, string> Skills { get; set; }
        public List<string> Vulnerabilities { get; set; }
        public List<string> Resistances { get; set; }
        public List<string> DamageImmunities { get; set; }
        public List<string> ConditionImmunities { get; set; }
        public string Senses { get; set; }
        public string Languages { get; set; }
        [Required]
        public string ChallengeRating { get; set; }
        public Dictionary<string, string> Traits { get; set; }
        public Dictionary<string, string> Actions { get; set; }
        [Required]
        public bool HasReactions { get; set; }
        [Required]
        public bool HasLegendary { get; set; }
        [Required]
        public bool HasLair { get; set; }
        public Dictionary<string, string> Reactions { get; set; }
        public Dictionary<string, string> LegendaryActions { get; set; }
        public Dictionary<string, string> LairActions { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? LastUpdated { get; set; }

    }
}
