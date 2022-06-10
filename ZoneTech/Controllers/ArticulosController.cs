using Microsoft.AspNetCore.Mvc;
using ZoneTech.Data;
using ZoneTech.Models;

namespace ZoneTech.Controllers
{
    public class ArticulosController : Controller
    {

        private ApplicationDBContext db;
        private readonly ILogger<ArticulosController> _logger;
        public ArticulosController(ILogger<ArticulosController> logger, ApplicationDBContext _db)
        {
            _logger = logger;
            db = _db;
        }

        public IActionResult Articulos()
        {
            var lista = db.ArticuloTBL.ToList();
            ViewBag.list = lista;
            return View();
        }

        public IActionResult InsertArticulo(ArticuloML art)
        {
            db.ArticuloTBL.Add(art);
            return View("Articulos");
        }

        public IActionResult DeleteArticulo(int id)
        {
            ArticuloML art = new ArticuloML();
            art.ArticuloId = id;
            db.ArticuloTBL.Remove(art);
            db.SaveChanges();
            return View();
        }

        public IActionResult Articulonuevo()
        {
            var list = db.MarcaTBL.ToList();
            var listCa = db.CategoriaTBL.ToList();
            var listMo = db.ModeloTBL.ToList();

            ViewBag.listMarca = list;
            ViewBag.listCategoria = listCa;
            ViewBag.listModelo = listMo;
            return View();
        }

    }
}