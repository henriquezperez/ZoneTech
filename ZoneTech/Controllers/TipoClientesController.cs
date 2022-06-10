using Microsoft.AspNetCore.Mvc;
using ZoneTech.Data;
using ZoneTech.Models;

namespace ZoneTech.Controllers
{
    public class TipoClientesController : Controller
    {

        private ApplicationDBContext db;
        private readonly ILogger<TipoClientesController> _logger;
        public TipoClientesController(ILogger<TipoClientesController> logger, ApplicationDBContext _db)
        {
            _logger = logger;
            db = _db;
        }

        public IActionResult TipoClienteNuevo()
        {
            return View();
        }

        public IActionResult InsertTipoCliente(TipoClienteML est)
        {
            db.TipoClienteTBL.Add(est);
            db.SaveChanges();
            return RedirectToAction("TipoClientes");
        }

        //READ
        public IActionResult TipoClientes()
        {
            var lista = db.TipoClienteTBL.ToList();
            ViewBag.listado = lista;
            return View();
        }
        //UPDATE
        public IActionResult TipoClienteEditar(int id)
        {
            var query = db.TipoClienteTBL.Where(x => x.TipoClienteId.Equals(id)).FirstOrDefault(); //usar FirstOrDefault()
            return View(query);
        }

        public IActionResult TipoClienteActualizar(TipoClienteML est)
        {
            db.TipoClienteTBL.Update(est);
            db.SaveChanges();
            return RedirectToAction("TipoClientes");
        }
        //DELETE
        public IActionResult TipoClienteEliminar(int id)
        {
            TipoClienteML est = new TipoClienteML();
            est.TipoClienteId = id;
            var query = db.TipoClienteTBL.Where(x => x.TipoClienteId.Equals(id));
            if (query != null)
            {
                db.TipoClienteTBL.Remove(est);
                db.SaveChanges();
            }
            return RedirectToAction("TipoClientes");
        }

    }

}