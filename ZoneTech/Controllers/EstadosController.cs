using Microsoft.AspNetCore.Mvc;
using ZoneTech.Data;
using ZoneTech.Models;

namespace ZoneTech.Controllers
{
    public class EstadosController : Controller
    {
        private ApplicationDBContext db;
        private readonly ILogger<EstadosController> _logger;
        public EstadosController(ILogger<EstadosController> logger, ApplicationDBContext _db){
            _logger = logger;
            db = _db;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        /* Nathalie _____________________________________________________________________________*/
        //Create
        public IActionResult EstadoNuevo(){
            return View();
        }

        public IActionResult InsertEstado(EstadoML est){
            db.EstadoTBL.Add(est);
            db.SaveChanges();
            return RedirectToAction("Estado");
        }
        //Usar RedirectToAction para redireccionar
        //READ
        public IActionResult Estado(){
            var lista = db.EstadoTBL.ToList();
            ViewBag.listado = lista;
            return View();
        }
        //UPDATE
        public IActionResult EstadoEditar(int id){
            var query = db.EstadoTBL.Where(x=>x.EstadoId.Equals(id)).FirstOrDefault(); //usar FirstOrDefault()
            return View(query);
        }

        public IActionResult EstadoActualizar(EstadoML est){
            db.EstadoTBL.Update(est);
            db.SaveChanges();
            return RedirectToAction("Estado");
        }
        //DELETE
        public IActionResult EstadoEliminar(int id){
            EstadoML est = new EstadoML();
            est.EstadoId = id;
            var query = db.EstadoTBL.Where(x=>x.EstadoId.Equals(id));
            if(query != null){
                db.EstadoTBL.Remove(est);
                db.SaveChanges();
            }
            return RedirectToAction("Estado");
        }
    }
}