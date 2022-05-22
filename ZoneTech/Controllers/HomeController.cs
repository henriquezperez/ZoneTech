using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZoneTech.Models;

namespace ZoneTech.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        
    }
}