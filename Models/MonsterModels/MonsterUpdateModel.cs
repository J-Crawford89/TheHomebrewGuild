using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Data.Enums;

namespace Models.MonsterModels
{
    public class MonsterUpdateModel
    {
        public int MonsterId { get; set; }
        [Display(Name ="Name")]
        public string MonsterName { get; set; }
        public Size Size { get; set; }
        public MonsterType Type { get; set; }
        public Alignment Alignment { get; set; }
        [Display(Name ="Armor Class")]
        public int ArmorClass { get; set; }
        [Display(Name ="Armor Type")]
        public string ArmorType { get; set; }
        [Display(Name ="Hit Points")]
        public int HitPoints { get; set; }
        [Display(Name ="Hit Point Equation")]
        public string HitPointEquation { get; set; }
        public string Speed { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        [Display(Name ="Saving Throws")]
        public Dictionary<Ability, string> SavingThrows { get; set; }
        public Dictionary<Skill, string> Skills { get; set; }
        public List<string> Vulnerabilities { get; set; }
        public List<string> Resistances { get; set; }
        [Display(Name ="Damage Immunities")]
        public List<string> DamageImmunities { get; set; }
        [Display(Name ="Condition Immunities")]
        public List<string> ConditionImmunities { get; set; }
        public string Senses { get; set; }
        public string Languages { get; set; }
        [Display(Name ="Challenge Rating")]
        public string ChallengeRating { get; set; }
        public Dictionary<string, string> Traits { get; set; }
        public Dictionary<string, string> Actions { get; set; }
        [Display(Name ="Reactions")]
        public bool HasReactions { get; set; }
        [Display(Name ="Legendary Actions")]
        public bool HasLegendary { get; set; }
        [Display(Name ="Lair Actions")]
        public bool HasLair { get; set; }
        [Display(Name = "Reactions")]
        public Dictionary<string, string> Reactions { get; set; }
        [Display(Name = "Legendary Actions")]
        public Dictionary<string, string> LegendaryActions { get; set; }
        [Display(Name = "Lair Actions")]
        public Dictionary<string, string> LairActions { get; set; }
    }
}
