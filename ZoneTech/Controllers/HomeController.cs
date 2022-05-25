using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZoneTech.Data;
using ZoneTech.Models;

namespace ZoneTech.Controllers
{

    public class HomeController : Controller
    {
        List<VentaPreview> _ventaList;
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

        public IActionResult Carrito(){

            return View("");
        }

        public IActionResult Catalogo(){
            var list = db.CategoriaTBL.ToList();
            ViewBag.listCategorias = list;
            return View();
        }

        public IActionResult Producto(int id){
            var query = db.ArticuloTBL.Where(x=>x.CategoriaId == id).ToList();
            ViewBag.list = query;
            return View();
        }
        
    }

    public class VentaPreview{
        public int ArticuloId { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
    }
}