using Microsoft.AspNetCore.Mvc;
using ZoneTech.Models;

namespace ZoneTech.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Login()
        {

            return View();
        }

        public ActionResult Registrar()
        {
            return View();
        }
    }
}
