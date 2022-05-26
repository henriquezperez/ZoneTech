using Microsoft.AspNetCore.Mvc;
using ZoneTech.Data;
using ZoneTech.Models;

namespace ZoneTech.Controllers
{
    public class AdminController : Controller
    {
         private ApplicationDBContext db;
        private readonly ILogger<AdminController> _logger;
        public AdminController(ILogger<AdminController> logger, ApplicationDBContext _db){
            _logger = logger;
            db = _db;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Articulos(){
            var lista = db.ArticuloTBL.ToList();
            ViewBag.list = lista;
            return View();
        }

        public IActionResult InsertArticulo(ArticuloML art){
            db.ArticuloTBL.Add(art);
            return View("Articulos");
        }

        public IActionResult DeleteArticulo(int id){
            ArticuloML art = new ArticuloML();
            art.ArticuloId = id;
            db.ArticuloTBL.Remove(art);
            db.SaveChanges();
            return View();
        }

        public IActionResult Articulonuevo(){
            var list = db.MarcaTBL.ToList();
            var listCa = db.CategoriaTBL.ToList();
            var listMo = db.ModeloTBL.ToList();

            ViewBag.listMarca = list;
            ViewBag.listCategoria = listCa;
            ViewBag.listModelo = listMo;
            return View();
        }

        public IActionResult Inventario(){
            var list = from art in db.ArticuloTBL
                        from inv in db.InventarioTBL
                        where art.ArticuloId == inv.ArticuloId
                        select new{
                                ID = art.ArticuloId,
                                Nombre = art.Nombre,
                                Existencia = inv.Existencia
                        };
            ViewBag.query = list;
            return View();
        }
        //Create
        public IActionResult EstadoNuevo(EstadoML est){
            db.EstadoTBL.Add(est);
            db.SaveChanges();
            return View("Estado");
        }

        //READ
        public IActionResult Estado(){
            var lista = db.EstadoTBL.ToList();
            ViewBag.listado = lista;
            return View();
        }
        //UPDATE
        public IActionResult EstadoEditar(EstadoML est){
            db.EstadoTBL.Update(est);
            db.SaveChanges();
            return View();
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
            return View();
        }

        public IActionResult ControlAdmin(){
            return View();
        }
    }
}
