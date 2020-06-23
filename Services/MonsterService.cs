using Contracts;
using Data;
using Data.Entities;
using Models.MonsterModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using System.Security.Policy;

namespace Services
{
    public class MonsterService : IMonsterService
    {
        private readonly Guid _userId;
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();
        public MonsterService(Guid userId)
        {
            _userId = userId;
        }
        public bool Create(MonsterCreateModel model)
        {
            var entity = new Monster()
            {
                OwnerId = _userId,
                MonsterName = model.MonsterName,
                Size = model.Size,
                Type = model.Type,
                Alignment = model.Alignment,
                ArmorClass = model.ArmorClass,
                ArmorType = model.ArmorType,
                HitPointEquation = model.HitPointEquation,
                HitPoints = model.HitPoints,
                Speed = model.Speed,
                Strength = model.Strength,
                Dexterity = model.Dexterity,
                Constitution = model.Constitution,
                Intelligence = model.Intelligence,
                Wisdom = model.Wisdom,
                SavingThrows = model.SavingThrows,
                Skills = model.Skills,
                Vulnerabilities = model.Vulnerabilities,
                Resistances = model.Resistances,
                DamageImmunities = model.DamageImmunities,
                ConditionImmunities = model.ConditionImmunities,
                Senses = model.Senses,
                Languages = model.Languages,
                ChallengeRating = model.ChallengeRating,
                Traits = model.Traits,
                Actions = model.Actions,
                HasReactions = model.HasReactions,
                HasLegendary = model.HasLegendary,
                HasLair = model.HasLair,
                Reactions = model.Reactions,
                LegendaryActions = model.LegendaryActions,
                LairActions = model.LairActions,
                Comments = null,
                IsDeleted = false,
                DateCreated = DateTime.Now,
                LastUpdated = DateTime.Now
            };
            _ctx.Monsters.Add(entity);

            return _ctx.SaveChanges() == 1;
        }

        public bool Delete(int MonsterId)
        {
            var entity = _ctx.Monsters.Single(e => e.MonsterId == MonsterId);
            if (entity != null) entity.IsDeleted = true;

            return _ctx.SaveChanges() == 1;
        }

        public IEnumerable<MonsterListItem> GetAllMonsters()
        {
            string userId = _userId.ToString();
            var userName = _ctx.Users.Single(u => u.Id == userId).UserName;
            var monsterList = _ctx.Monsters
                .Where(e => e.OwnerId == _userId && e.IsDeleted == false)
                .Select(e => new MonsterListItem
                {
                    MonsterId = e.MonsterId,
                    MonsterName = e.MonsterName,
                    Creator = userName,
                    Type = e.Type.ToString(),
                    ChallengeRating = e.ChallengeRating,
                    HasLegendary = e.HasLegendary
                }).ToList();

            return monsterList;
        }

        public MonsterDetailModel GetMonsterById(int MonsterId)
        {
            var entity = _ctx.Monsters.Single(e => e.MonsterId == MonsterId);
            var model = new MonsterDetailModel
            {
                MonsterId = entity.MonsterId,
                Creator = _ctx.Users.Single(u => u.Id == entity.OwnerId.ToString()).UserName,
                MonsterName = entity.MonsterName,
                Size = entity.Size,
                Type = entity.Type,
                Alignment = entity.Alignment,
                ArmorClass = entity.ArmorClass,
                ArmorType = entity.ArmorType,
                HitPointEquation = entity.HitPointEquation,
                HitPoints = entity.HitPoints,
                Speed = entity.Speed,
                Strength = entity.Strength,
                Dexterity = entity.Dexterity,
                Constitution = entity.Constitution,
                Intelligence = entity.Intelligence,
                Wisdom = entity.Wisdom,
                Charisma = entity.Charisma,
                SavingThrows = entity.SavingThrows,
                Skills = entity.Skills,
                Vulnerabilities = entity.Vulnerabilities,
                Resistances = entity.Resistances,
                DamageImmunities = entity.DamageImmunities,
                ConditionImmunities = entity.ConditionImmunities,
                Senses = entity.Senses,
                Languages = entity.Languages,
                ChallengeRating = entity.ChallengeRating,
                Traits = entity.Traits,
                Actions = entity.Actions,
                Reactions = entity.Reactions,
                LegendaryActions = entity.LegendaryActions,
                LairActions = entity.LairActions,
                Comments = entity.Comments,
                DateCreated = entity.DateCreated,
                LastModified = entity.LastUpdated
            };
            return model;
        }

        public bool Update(MonsterUpdateModel model, int MonsterId)
        {
            var entity = _ctx.Monsters.Single(e => e.MonsterId == MonsterId);
            if (entity != null)
            {
                entity.MonsterName = model.MonsterName;
                entity.Size = model.Size;
                entity.Type = model.Type;
                entity.Alignment = model.Alignment;
                entity.ArmorClass = model.ArmorClass;
                entity.ArmorType = model.ArmorType;
                entity.HitPoints = model.HitPoints;
                entity.HitPointEquation = model.HitPointEquation;
                entity.Speed = model.Speed;
                entity.Strength = model.Strength;
                entity.Dexterity = model.Dexterity;
                entity.Constitution = model.Constitution;
                entity.Intelligence = model.Intelligence;
                entity.Wisdom = model.Wisdom;
                entity.Charisma = model.Charisma;
                entity.SavingThrows = model.SavingThrows;
                entity.Skills = model.Skills;
                entity.Vulnerabilities = model.Vulnerabilities;
                entity.Resistances = model.Resistances;
                entity.DamageImmunities = model.DamageImmunities;
                entity.ConditionImmunities = model.ConditionImmunities;
                entity.Senses = model.Senses;
                entity.Languages = model.Languages;
                entity.ChallengeRating = model.ChallengeRating;
                entity.Traits = model.Traits;
                entity.Actions = model.Actions;
                entity.HasReactions = model.HasReactions;
                entity.HasLegendary = model.HasLegendary;
                entity.HasLair = model.HasLair;
                entity.Reactions = model.Reactions;
                entity.LegendaryActions = model.LegendaryActions;
                entity.LairActions = model.LairActions;
                entity.LastUpdated = DateTime.Now;
            }

            return _ctx.SaveChanges() == 1;
        }
    }
}
