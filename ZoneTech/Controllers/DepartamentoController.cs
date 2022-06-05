using Microsoft.AspNetCore.Mvc;
using ZoneTech.Data;
using ZoneTech.Models;

namespace ZoneTech.Controllers
{
    public class DepartamentoController : Controller
    {
        
        private ApplicationDBContext db;
        private readonly ILogger<DepartamentoController> _logger;
        public DepartamentoController(ILogger<DepartamentoController> logger, ApplicationDBContext _db){
            _logger = logger;
            db = _db;
        }

        
        public IActionResult DepartamentoNuevo()
        {
            return View();
        }

        public IActionResult InsertDepartamento(DepartamentoML est)
        {
            db.DepartamentoTBL.Add(est);
            db.SaveChanges();
            return RedirectToAction("Departamentos");
        }

        //READ
        public IActionResult Departamentos()
        {
            var lista = db.DepartamentoTBL.ToList();
            ViewBag.listado = lista;
            return View();
        }
        //UPDATE
        public IActionResult DepartamentoEditar(int id)
        {
            var query = db.DepartamentoTBL.Where(x => x.DepartamentoId.Equals(id)).FirstOrDefault(); //usar FirstOrDefault()
            return View(query);
        }

        public IActionResult DepartamentoActualizar(DepartamentoML est)
        {
            db.DepartamentoTBL.Update(est);
            db.SaveChanges();
            return RedirectToAction("Departamentos");
        }
        //DELETE
        public IActionResult DepartamentoEliminar(int id)
        {
            DepartamentoML est = new DepartamentoML();
            est.DepartamentoId = id;
            var query = db.DepartamentoTBL.Where(x => x.DepartamentoId.Equals(id));
            if (query != null)
            {
                db.DepartamentoTBL.Remove(est);
                db.SaveChanges();
            }
            return RedirectToAction("Departamentos");
        }

    }
}