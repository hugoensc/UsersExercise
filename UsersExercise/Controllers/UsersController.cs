using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UsersExercise.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Index(string data, int age)
        {
            ViewData["id"] = data + " " + age;      
            return View();
        }
    }
}