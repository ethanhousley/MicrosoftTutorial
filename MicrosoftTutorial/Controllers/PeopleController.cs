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


        
 

    }
}
