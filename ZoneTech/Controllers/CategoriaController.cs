using Microsoft.AspNetCore.Mvc;
using ZoneTech.Data;
using ZoneTech.Models;

namespace ZoneTech.Controllers
{
    public class CategoriaController : Controller
    {

        private ApplicationDBContext db;
        private readonly ILogger<CategoriaController> _logger;
        private readonly IWebHostEnvironment _enviroment;
        public CategoriaController(ILogger<CategoriaController> logger, ApplicationDBContext _db)
        {
            _logger = logger;
            db = _db;
        }

        #region Categoria

        public ActionResult Categoria()
        {
            var lista = db.CategoriaTBL.ToList();
            ViewBag.list = lista;
            var estad = db.EstadoTBL.ToList();
            ViewBag.estado = estad;
            return View();
        }

        // GET: MarcaController/Details/5
        public ActionResult DetalleCategoria(int id)
        {
            var query = db.CategoriaTBL.Where(x => x.CategoriaId.Equals(id)).FirstOrDefault();
            return View(query);
        }

        // GET: MarcaController/Create
        public ActionResult CrearCategoria()
        {
            var est = db.EstadoTBL.ToList();
            ViewBag.estado = est;
            return View();
        }

        // POST: MarcaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearCategoria(CategoriaML pCategoriaML)
        {
            try
            {
                db.CategoriaTBL.Add(pCategoriaML);
                int result = db.SaveChanges();
                return RedirectToAction("Categoria");
            }
            catch
            {
                ViewBag.estado = db.EstadoTBL.ToList();
                return View("CrearCategoria");
            }
        }
        

       /* [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearCategoria(CategoriaML pCategoriaML)
        {
           // var fileName = System.IO.Path.Combine(_enviroment.ContentRootPath,"~/img/catalogo/categorias/",pCategoriaML.RutaImagen + (FileAccess.Read.Equals(".png")));

            //await pCategoriaML.RutaImagen.TryCopyTo(new System.IO.FileStream(fileName,System.IO.FileMode.Create));
           // var fileName = System.IO.Path.Combine(_enviroment.ContentRootPath,"~/img/catalogo/categorias/",pCategoriaML.RutaImagen);
           // pCategoriaML.RutaImagen = fileName.ToString();
          // var namear = pCategoriaML.RutaImagen.

            try
            {
                db.CategoriaTBL.Add(pCategoriaML);
                int result = db.SaveChanges();
                return RedirectToAction("Categoria");
            }
            catch
            {
                ViewBag.estado = db.EstadoTBL.ToList();
                return View("CrearCategoria");
            }
        }*/

        // GET: MarcaController/Edit/5
        public ActionResult EditarCategoria(int id)
        {
            var query = db.CategoriaTBL.Where(x => x.CategoriaId.Equals(id)).FirstOrDefault();
            var est = db.EstadoTBL.ToList();
            ViewBag.estado = est;
            return View(query);
        }

        // POST: MarcaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarCategoria(int id, CategoriaML pCategoriaML)
        {
            try
            {
                db.CategoriaTBL.Update(pCategoriaML);
                int result = db.SaveChanges();
                return RedirectToAction("Categoria");
            }
            catch (Exception ex)
            {
                //ViewBag.Error = ex.Message;
                ViewBag.estado = db.EstadoTBL.ToList();
                return View("EditarCategoria");
            }
        }

        // GET: MarcaController/Delete/5
        public ActionResult EliminarCategoria(int id)
        {
            CategoriaML catg = new CategoriaML();
            catg.CategoriaId = id;
            var query = db.CategoriaTBL.Where(x => x.CategoriaId.Equals(id));
            if (query != null)
            {
                db.CategoriaTBL.Remove(catg);
                int result = db.SaveChanges();
            }
            return RedirectToAction("Categoria");
        }

        #endregion

    }
}