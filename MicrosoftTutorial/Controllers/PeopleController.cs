using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicrosoftTutorial.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace MicrosoftTutorial.Controllers
{
    public class PeopleController : Controller
    {

        private readonly ConnectionDBClass _db;


        public PeopleController(ConnectionDBClass db)
        {
            _db = db;
        }

        

        public IActionResult Index()
        {
            var personList = _db.PrimaryUser.ToList();

            

            return View(personList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            _db.Add(person);
            _db.SaveChanges();
            return View(person);
        }

        public IActionResult Edit()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            _db.Entry(person).State = EntityState.Modified;
            _db.SaveChanges();
            return View(person);
        }


        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public  IActionResult Delete(Person person)
        {
            var person1 = _db.PrimaryUser.First(x => x.UserID == person.UserID);
            _db.PrimaryUser.Remove(person1);
            _db.SaveChanges();
            
            return View();
        }
        
 

    }
}
