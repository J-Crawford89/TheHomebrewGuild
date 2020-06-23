using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Data
{
    public class Enums
    {
        public enum MonsterType
        {
            Aberration,
            Beast,
            Celestial,
            Construct,
            Dragon,
            Elemental,
            Fey,
            Fiend,
            Giant,
            Humanoid,
            Monstrosity,
            Ooze,
            Plant,
            Undead
        }
        public enum Size
        {
            Tiny,
            Small,
            Medium,
            Large,
            Huge,
            Gargantuan
        }
        public enum Alignment
        {
            LG,
            NG,
            CG,
            LN,
            N,
            CN,
            LE,
            NE,
            CE,
            Unaligned
        }
        public enum Ability
        {
            Strength,
            Dexterity,
            Constitution,
            Intelligence,
            Wisdom,
            Charisma
        }
        public enum Skill
        {
            Acrobatics,
            AnimalHandling,
            Arcana,
            Athletics,
            Deception,
            History,
            Insight,
            Intimidation,
            Investigation,
            Medicine,
            Nature,
            Perception,
            Performance,
            Persuasion,
            Religion,
            SleightOfHand,
            Stealth,
            Survival
        }
        public enum School
        {
            Abjuration,
            Conjuration,
            Divination,
            Enchantment,
            Evocation,
            Illusion,
            Necromancy,
            Transmutation
        }
    }
}
