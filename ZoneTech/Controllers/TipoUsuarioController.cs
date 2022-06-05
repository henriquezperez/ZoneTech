using Microsoft.AspNetCore.Mvc;
using ZoneTech.Data;
using ZoneTech.Models;

namespace ZoneTech.Controllers
{
    public class TipoUsuarioController : Controller
    {
        
        private ApplicationDBContext db;
        private readonly ILogger<TipoUsuarioController> _logger;
        public TipoUsuarioController(ILogger<TipoUsuarioController> logger, ApplicationDBContext _db){
            _logger = logger;
            db = _db;
        }

        public IActionResult TipoUsuarionuevo()
        {
            var list = db.EstadoTBL.ToList();

            ViewBag.listEstado = list;

            return View();
        }

        public IActionResult InsertTipoUsuario(TipoUsuarioML est)
        {
            db.TipoUsuarioTBL.Add(est);
            db.SaveChanges();
            return RedirectToAction("TipoUsuario");
        }

        //READ
        public IActionResult TipoUsuarios()
        {
            var lista = db.TipoUsuarioTBL.ToList();
            ViewBag.listado = lista;
            return View();
        }
        //UPDATE
        public IActionResult TipoUsuarioEditar(int id)
        {
            var query = db.TipoUsuarioTBL.Where(x => x.TipoUsuarioId.Equals(id)).FirstOrDefault(); //usar FirstOrDefault()
            return View(query);
        }

        public IActionResult TipoUsuarioActualizar(TipoUsuarioML est)
        {
            db.TipoUsuarioTBL.Update(est);
            db.SaveChanges();
            return RedirectToAction("TipoUsuario");
        }
        //DELETE
        public IActionResult TipoUsuarioEliminar(int id)
        {
            TipoUsuarioML est = new TipoUsuarioML();
            est.TipoUsuarioId = id;
            var query = db.TipoUsuarioTBL.Where(x => x.TipoUsuarioId.Equals(id));
            if (query != null)
            {
                db.TipoUsuarioTBL.Remove(est);
                db.SaveChanges();
            }
            return RedirectToAction("TipoUsuario");
        }

    }
}