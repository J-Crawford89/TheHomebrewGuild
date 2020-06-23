using Data;
using Data.Entities;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using Models.MonsterModels;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Data.Enums;

namespace MVC.Controllers
{
    [Authorize]
    public class MonsterController : Controller
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();
        private MonsterService CreateMonsterService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());

            return new MonsterService(userId);
        }
        // GET: Monster
        [AllowAnonymous]
        public ActionResult Index()
        {
            var monsterService = CreateMonsterService();
            var model = monsterService.GetAllMonsters();

            return View(model);
        }
        // GET: Monster/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Monster/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MonsterCreateModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var monsterService = CreateMonsterService();
            if (monsterService.Create(model))
            {
                TempData["SaveResult"] = "Your Monster has been created!";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "There was an error creating your Monster.");
            return View(model);
        }
        // GET: Monster/Details/{id}
        [AllowAnonymous]
        public ActionResult Details(int id)
        {
            var monsterService = CreateMonsterService();
            var model = monsterService.GetMonsterById(id);

            return View(model);
        }
        // GET: Monster/Edit/{id}
        public ActionResult Edit(int id)
        {
            var monsterService = CreateMonsterService();
            var detail = monsterService.GetMonsterById(id);

            var model = new MonsterUpdateModel
            {
                MonsterId = detail.MonsterId,
                MonsterName = detail.MonsterName,
                Size = detail.Size,
                Type = detail.Type,
                Alignment = detail.Alignment,
                ArmorClass = detail.ArmorClass,
                ArmorType = detail.ArmorType,
                HitPoints = detail.HitPoints,
                HitPointEquation = detail.HitPointEquation,
                Speed = detail.Speed,
                Strength = detail.Strength,
                Dexterity = detail.Dexterity,
                Constitution = detail.Constitution,
                Intelligence = detail.Intelligence,
                Wisdom = detail.Wisdom,
                Charisma = detail.Charisma,
                SavingThrows = detail.SavingThrows,
                Skills = detail.Skills,
                Vulnerabilities = detail.Vulnerabilities,
                Resistances = detail.Resistances,
                DamageImmunities = detail.DamageImmunities,
                ConditionImmunities = detail.ConditionImmunities,
                Senses = detail.Senses,
                Languages = detail.Languages,
                ChallengeRating = detail.ChallengeRating,
                Traits = detail.Traits,
                Actions = detail.Actions,
                Reactions = detail.Reactions,
                LegendaryActions = detail.LegendaryActions,
                LairActions = detail.LairActions,
                HasReactions = false,
                HasLegendary = false,
                HasLair = false
            };
            if (detail.Reactions.Count() > 0)
                model.HasReactions = true;
            if (detail.LegendaryActions.Count() > 0)
                model.HasLegendary = true;
            if (detail.LairActions.Count() > 0)
                model.HasLair = true;

            return View(model);
        }

        // POST: Monster/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MonsterUpdateModel model, int id)
        {
            if (!ModelState.IsValid)
                return View(model);
            if (model.MonsterId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }
            var monsterService = CreateMonsterService();
            if (monsterService.Update(model, id))
            {
                TempData["SaveResult"] = "Your Monster was updated!";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "There was an error updating your Monster.");
            return View(model);
        }
        // POST: Monster/Delete/{id}

    }
}