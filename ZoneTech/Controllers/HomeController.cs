using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZoneTech.Data;
using ZoneTech.Models;

namespace ZoneTech.Controllers
{

    public class HomeController : Controller
    {
        List<VentaPreview> _ventaList;
        List<CarritoPreview> _carritoList;
        static int articuloId;
        string nombreArt;
        int cant;
        decimal precio;
        decimal subTotal;
        decimal total;

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
        
            ViewBag.list = _carritoList;
            return View();
        }

        public IActionResult Agregar(int id){
            
           //ArticuloML art = new ArticuloML();
           //var art = db.ArticuloTBL.Where(x=>x.ArticuloId.Equals(id));
            CarritoPreview car =  new CarritoPreview(){
                CarritoId = id,
                UsuarioId = 0,
                ArticuloId = id,
                Cantidad = 1,
                SubTotal = 0.35M,
            };

            var query = _carritoList.FirstOrDefault(x => x.ArticuloId.Equals(id));

            if (query != null)
            {
                for (int i = 0; i < _carritoList.Count; i++)
                {
                    if (_carritoList[i].ArticuloId == car.ArticuloId)
                    {
                        _carritoList[i].Cantidad += car.Cantidad;
                        _carritoList[i].SubTotal += car.SubTotal;
                    }
                }
            }
            else
            {
                _carritoList.Add(car);
            }

            return RedirectToAction("Carrito");
        }
        /*
        private void AgregarDetalleVenta(int id){
          var qry = db.ArticuloTBL.FirstOrDefault(x => x.ArticuloId.Equals(articuloId));

            articuloId = qry.ArticuloId;
            nombreArt =qry.Nombre;
            precio = qry.Precio;

            VentaPreview venta = new VentaPreview(){
                ArticuloId = articuloId,
                Nombre = nombreArt,
                Precio = precio,
                Cantidad = cant,
                SubTotal = subTotal
            };

            var query = _ventaList.FirstOrDefault(x => x.ArticuloId.Equals(venta.ArticuloId));

            if (query != null)
            {
                for (int i = 0; i < _ventaList.Count; i++)
                {
                    if (_ventaList[i].ArticuloId == venta.ArticuloId)
                    {
                        _ventaList[i].Cantidad += venta.Cantidad;
                        _ventaList[i].SubTotal += venta.SubTotal;
                    }
                }
            }
            else
            {
                _ventaList.Add(venta);
            }
           Carrito();
        }*/

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

       /*public IActionResult Agregar(int id){
           articuloId = v.ArticuloId;
            nombreArt = v.Nombre;
            precio = v.Precio;
            cant = Contador++;
           // var query = db.ArticuloTBL.Where(x=>x.CategoriaId == id).ToList();
            
           // AgregarDetalleVenta(id);
           // return View();
       } */
        
    }


    public class VentaPreview{
        public int ArticuloId { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
    }

    public class CarritoPreview{
        public int CarritoId { get; set; }
        public int UsuarioId { get; set; }
        public int ArticuloId { get; set; }

        public int Cantidad  { get; set; }

        public decimal SubTotal  { get; set; }

    }
}