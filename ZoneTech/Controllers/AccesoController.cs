using Microsoft.AspNetCore.Mvc;
using ZoneTech.Data;
using ZoneTech.Models;

namespace ZoneTech.Controllers
{
    public class AccesoController : Controller
    {
        private ApplicationDBContext db;
        private readonly ILogger<AccesoController> _logger;
        public AccesoController(ILogger<AccesoController> logger, ApplicationDBContext _db)
        {
            _logger = logger;
            db = _db;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UsuarioML user)
        {
            var log = db.UsuarioTBL.FirstOrDefault(x => x.Email == user.Email && x.Clave == user.Clave);

            if (log != null)
            {
                return View("PruebaDeAcceso");

            }
            else
            {
                return View("Denegado");
            }
            return View();
        }

        public ActionResult Registrar()
        {
            return View();
        }

        public ActionResult PruebaDeAcceso()
        {
            ViewBag.logi = 1;
            return View();
        }
        public ActionResult Denegado()
        {
            return View();
        }
    }
}
