﻿using CallRegisterWeb.Data;
using CallRegisterWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CallRegisterWeb.Controllers
{
    public class AgentController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AgentController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Agent> objAgentList = _db.Agents.ToList();
            return View(objAgentList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Agent obj)
        {
            if (ModelState.IsValid)
            {
                _db.Agents.Add(obj);
                _db.SaveChanges();
            }

            return RedirectToAction("Index", "Agent");
        }

        public IActionResult Edit(int? id)
        {
            if(id== null || id == 0)
            {
                return NotFound();
            }

            Agent? agentFromDb = _db.Agents.Find(id);
            if (agentFromDb == null)
            {
                return NotFound();
            }
            return View(agentFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Agent obj)
        {
            if (ModelState.IsValid)
            {
                _db.Agents.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index", "Agent");
            }

            
            return View();
        }
 
    }
}
