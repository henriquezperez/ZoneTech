using Microsoft.AspNetCore.Mvc;
using ZoneTech.Data;
using ZoneTech.Models;

namespace ZoneTech.Controllers
{
    public class MarcaController : Controller
    {
        
        private ApplicationDBContext db;
        private readonly ILogger<MarcaController> _logger;
        public MarcaController(ILogger<MarcaController> logger, ApplicationDBContext _db){
            _logger = logger;
            db = _db;
        }

        #region Marca
        public ActionResult Marca()
        {
            var marcas = db.MarcaTBL.ToList();//->
            ViewBag.list = marcas;
            var estd = db.EstadoTBL.ToList();
            ViewBag.estado = estd;
            return View();
        }

        // GET: MarcaController/Details/5
        public ActionResult DetalleMarca(int id)
        {
            var query = db.MarcaTBL.Where(x => x.MarcaId.Equals(id)).FirstOrDefault();
            return View(query);
        }

        // GET: MarcaController/Create
        public ActionResult CrearMarca()
        {
            var estd = db.EstadoTBL.ToList();
            ViewBag.estado = estd;
            return View();
        }

        // POST: MarcaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearMarca(MarcaML pMarcaML)
        {
            try
            {
                db.MarcaTBL.Add(pMarcaML);
                int result = db.SaveChanges();
                return RedirectToAction("Marca");
            }
            catch
            {
                ViewBag.estado = db.EstadoTBL.ToList();
                return View("CrearMarca");
            }
        }

        // GET: MarcaController/Edit/5
        public ActionResult EditarMarca(int id)
        {
            var query = db.MarcaTBL.Where(x => x.MarcaId.Equals(id)).FirstOrDefault();
            var estd = db.EstadoTBL.ToList();
            ViewBag.estado = estd;
            return View(query);
        }

        // POST: MarcaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarMarca(int id, MarcaML pMarcaML)
        {
            try
            {
                db.MarcaTBL.Update(pMarcaML);
                int result = db.SaveChanges();
                return RedirectToAction("Marca");
            }
            catch (Exception ex)
            {
                //ViewBag.Error = ex.Message;
                ViewBag.estado = db.EstadoTBL.ToList();
                return View("EditarMarca");
            }
        }

        // GET: MarcaController/Delete/5
        public ActionResult EliminarMarca(int id)
        {
            MarcaML marc = new MarcaML();
            marc.MarcaId = id;
            var query = db.MarcaTBL.Where(x => x.MarcaId.Equals(id));
            if (query != null)
            {
                db.MarcaTBL.Remove(marc);
                int result = db.SaveChanges();
            }
            return RedirectToAction("Marca");
        }
        //Fin Marca
        #endregion

    }
}