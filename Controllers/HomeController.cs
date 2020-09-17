using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper_Project.Models;

namespace Dapper_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            return View();
        }
          
        public IActionResult Login(string username)
        {
            HttpContext.Response.Cookies.Append("username", username);
            //ViewBag.Name = username;
            //return View();

            return View("Index");
            
        }

        public IActionResult AddQuestion()
        {
            //ViewBag.PageName = "Add Question";
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
