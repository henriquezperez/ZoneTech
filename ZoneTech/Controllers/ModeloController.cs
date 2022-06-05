using Microsoft.AspNetCore.Mvc;
using ZoneTech.Data;
using ZoneTech.Models;

namespace ZoneTech.Controllers
{
    public class ModeloController : Controller
    {
        
        private ApplicationDBContext db;
        private readonly ILogger<ModeloController> _logger;
        public ModeloController(ILogger<ModeloController> logger, ApplicationDBContext _db){
            _logger = logger;
            db = _db;
        }

         #region Modelo

        public ActionResult Modelo()
        {
            var list = from mdl in db.ModeloTBL
                       from mar in db.MarcaTBL
                       from ctgc in db.CategoriaTBL
                       where mdl.MarcaId == mar.MarcaId
                          && mdl.CategoriaId == ctgc.CategoriaId
                       select new
                       {
                           ID = mdl.ModeloId,
                           Nombre = mdl.Nombre,
                           MarcId = mdl.MarcaId,
                           CtgId = mdl.CategoriaId,
                           Marca = mar.Nombre,
                           Categor = ctgc.Nombre

                       };
            ViewBag.query = list;
            var marc = db.MarcaTBL.ToList();
            ViewBag.marca = marc;
            var ctg = db.CategoriaTBL.ToList();
            ViewBag.categoria = ctg;
            return View();
        }

        // GET: MarcaController/Details/5
        public ActionResult DetalleModelo(int id)
        {
            var query = db.ModeloTBL.Where(x => x.ModeloId.Equals(id)).FirstOrDefault();
            return View(query);
        }

        // GET: MarcaController/Create
        public ActionResult CrearModelo()
        {
            var marc = db.MarcaTBL.ToList();
            ViewBag.marca = marc;
            var ctg = db.CategoriaTBL.ToList();
            ViewBag.categoria = ctg;
            return View();
        }

        // POST: MarcaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearModelo(ModeloML pModeloML)
        {
            try
            {
                db.ModeloTBL.Add(pModeloML);
                int result = db.SaveChanges();
                return RedirectToAction("Modelo");
            }
            catch
            {
                ViewBag.marca = db.MarcaTBL.ToList();
                ViewBag.categoria = db.CategoriaTBL.ToList();
                return View("CrearModelo");
            }
        }

        // GET: MarcaController/Edit/5
        public ActionResult EditarModelo(int id)
        {
            var marc = db.MarcaTBL.ToList();
            ViewBag.marca = marc;
            var ctg = db.CategoriaTBL.ToList();
            ViewBag.categoria = ctg;
            var query = db.ModeloTBL.Where(x => x.ModeloId.Equals(id)).FirstOrDefault();
            return View(query);
        }

        // POST: MarcaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarModelo(int id, ModeloML pModeloML)
        {
            try
            {
                db.ModeloTBL.Update(pModeloML);
                int result = db.SaveChanges();
                return RedirectToAction("Modelo");
            }
            catch (Exception ex)
            {
                //ViewBag.Error = ex.Message;
                ViewBag.marca = db.MarcaTBL.ToList();
                ViewBag.categoria = db.CategoriaTBL.ToList();
                return View("EditarModelo");
            }
        }

        // GET: MarcaController/Delete/5
        public ActionResult EliminarModelo(int id)
        {
            ModeloML modl = new ModeloML();
            modl.ModeloId = id;
            var query = db.ModeloTBL.Where(x => x.ModeloId.Equals(id));
            if (query != null)
            {
                db.ModeloTBL.Remove(modl);
                int result = db.SaveChanges();
            }
            return RedirectToAction("Modelo");
        }

        #endregion

    }
}