using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZoneTech.Data;
using ZoneTech.Models;

namespace ZoneTech.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDBContext db;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, ApplicationDBContext _db){
            _logger = logger;
            db = _db;
        }

        public IActionResult Index()
        {
            var cat = db.CategoriaTBL.ToList();
            ViewBag.categorias = cat;
            return View();
        }
 
    }
}