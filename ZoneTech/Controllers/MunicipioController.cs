using Microsoft.AspNetCore.Mvc;
using ZoneTech.Data;
using ZoneTech.Models;

namespace ZoneTech.Controllers
{
    public class MunicipioController : Controller
    {

        private ApplicationDBContext db;
        private readonly ILogger<MunicipioController> _logger;
        public MunicipioController(ILogger<MunicipioController> logger, ApplicationDBContext _db)
        {
            _logger = logger;
            db = _db;
        }


        #region Municipio

        public ActionResult Municipio()
        {
            var list = from mn in db.MunicipioTBL
                       from dep in db.DepartamentoTBL
                       where mn.DepartamentoId == dep.DepartamentoId
                       select new
                       {
                           ID = mn.MunicipioId,
                           Nombre = mn.Nombre,
                           DepartID = mn.DepartamentoId,
                           NombreDep = dep.Nombre

                       };
            ViewBag.query = list;
            var depart = db.DepartamentoTBL.ToList();
            ViewBag.departamento = depart;
            return View();
        }

        // GET: MarcaController/Details/5
        public ActionResult DetalleMunicipio(int id)
        {
            var query = db.MunicipioTBL.Where(x => x.MunicipioId.Equals(id)).FirstOrDefault();
            return View(query);
        }

        // GET: MarcaController/Create
        public ActionResult CrearMunicipio()
        {
            var depart = db.DepartamentoTBL.ToList();
            ViewBag.departamento = depart;
            return View();
        }

        // POST: MarcaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearMunicipio(MunicipioML pMunicipioML)
        {
            try
            {
                db.MunicipioTBL.Add(pMunicipioML);
                int result = db.SaveChanges();
                return RedirectToAction("Municipio");
            }
            catch
            {
                ViewBag.departamento = db.DepartamentoTBL.ToList();
                return View("CrearModelo");
            }
        }

        // GET: MarcaController/Edit/5
        public ActionResult EditarMunicipio(int id)
        {
            var query = db.MunicipioTBL.Where(x => x.MunicipioId.Equals(id)).FirstOrDefault();
            var depart = db.DepartamentoTBL.ToList();
            ViewBag.departamento = depart;
            return View(query);
        }

        // POST: MarcaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarMunicipio(int id, MunicipioML pMunicipioML)
        {
            try
            {
                db.MunicipioTBL.Update(pMunicipioML);
                int result = db.SaveChanges();
                return RedirectToAction("Municipio");
            }
            catch (Exception ex)
            {
                //ViewBag.Error = ex.Message;
                ViewBag.departamento = db.DepartamentoTBL.ToList();
                return View("EditarMunicipio");
            }
        }

        // GET: MarcaController/Delete/5
        public ActionResult EliminarMunicipio(int id)
        {
            MunicipioML mun = new MunicipioML();
            mun.MunicipioId = id;
            var query = db.MunicipioTBL.Where(x => x.MunicipioId.Equals(id));
            if (query != null)
            {
                db.MunicipioTBL.Remove(mun);
                int result = db.SaveChanges();
            }
            return RedirectToAction("Municipio");
        }

        #endregion

    }
}