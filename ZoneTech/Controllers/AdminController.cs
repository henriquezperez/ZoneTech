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

        public IActionResult ControlAdmin(){
            return View();
        }

        public IActionResult Usuarionuevo()
        {
            var list = db.TipoUsuarioTBL.ToList();

            ViewBag.listTipoUsuario = list;

            return View();
        }


        public IActionResult InsertUsuario(UsuarioML est)
        {
            db.UsuarioTBL.Add(est);
            db.SaveChanges();
            return RedirectToAction("Usuario");
        }

        //READ
        public IActionResult Usuario()
        {
            var lista = db.UsuarioTBL.ToList();
            ViewBag.listado = lista;
            return View();
        }
        //UPDATE
        public IActionResult UsuarioEditar(int id)
        {
            var query = db.UsuarioTBL.Where(x => x.UsuarioId.Equals(id)).FirstOrDefault(); //usar FirstOrDefault()
            return View(query);
        }

        public IActionResult UsuarioActualizar(UsuarioML est)
        {
            db.UsuarioTBL.Update(est);
            db.SaveChanges();
            return RedirectToAction("Usuario");
        }
        //DELETE
        public IActionResult UsuarioEliminar(int id)
        {
            UsuarioML est = new UsuarioML();
            est.UsuarioId = id;
            var query = db.UsuarioTBL.Where(x => x.UsuarioId.Equals(id));
            if (query != null)
            {
                db.UsuarioTBL.Remove(est);
                db.SaveChanges();
            }
            return RedirectToAction("Usuario");
        }


       
        //


        /*Victor _________________________________________________________________________________________*/

        #region Victor

      

       

       


        #region Cliente

        public ActionResult Cliente()
        {
            var list = from cl in db.ClienteTBL
                       from tpclc in db.TipoClienteTBL
                       from munic in db.MunicipioTBL
                       from userc in db.UsuarioTBL
                       where cl.TipoClienteId == tpclc.TipoClienteId
                          && cl.MunicipioId == munic.MunicipioId
                          && cl.UsuarioId == userc.UsuarioId
                       select new
                       {
                           ID = cl.ClienteId,
                           Nombre = cl.Nombres,
                           Apellidos = cl.Apellidos,
                           DUI = cl.DUI,
                           TipoCLId = cl.TipoClienteId,
                           TipoCL = tpclc.Nombre,
                           Resid = cl.Residencia,
                           MuniId = cl.MunicipioId,
                           NombMunicip = munic.Nombre,
                           UseId = cl.UsuarioId,
                           NombreUse = userc.Nombre

                       };
            ViewBag.query = list;
            var tpcl = db.TipoClienteTBL.ToList();
            ViewBag.tipocliente = tpcl;
            var muni = db.MunicipioTBL.ToList();
            ViewBag.municipios = muni;
            var users = db.UsuarioTBL.ToList();
            ViewBag.usua = users;
            return View();
        }

        // GET: MarcaController/Details/5
        public ActionResult DetalleCliente(int id)
        {
            var query = db.ClienteTBL.Where(x => x.ClienteId.Equals(id)).FirstOrDefault();
            return View(query);
        }

        // GET: MarcaController/Create
        public ActionResult CrearCliente()
        {
            var tpcl = db.TipoClienteTBL.ToList();
            ViewBag.tipocliente = tpcl;
            var muni = db.MunicipioTBL.ToList();
            ViewBag.municipios = muni;
            var users = db.UsuarioTBL.ToList();
            ViewBag.usua = users;
            return View();
        }

        // POST: MarcaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearCliente(ClienteML pClienteML)
        {
            try
            {
                db.ClienteTBL.Add(pClienteML);
                int result = db.SaveChanges();
                return RedirectToAction("Cliente");
            }
            catch
            {
                ViewBag.tipocliente = db.CategoriaTBL.ToList();
                ViewBag.municipios = db.MunicipioTBL.ToList();
                ViewBag.usua = db.UsuarioTBL.ToList();
                return View("CrearCliente");
            }
        }

        // GET: MarcaController/Edit/5
        public ActionResult EditarCliente(int id)
        {
            var query = db.ClienteTBL.Where(x => x.ClienteId.Equals(id)).FirstOrDefault();
            var tpcl = db.TipoClienteTBL.ToList();
            ViewBag.tipocliente = tpcl;
            var muni = db.MunicipioTBL.ToList();
            ViewBag.municipios = muni;
            var users = db.UsuarioTBL.ToList();
            ViewBag.usua = users;
            return View(query);
        }

        // POST: MarcaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarCliente(int id, ClienteML pClienteML)
        {
            try
            {
                db.ClienteTBL.Update(pClienteML);
                int result = db.SaveChanges();
                return RedirectToAction("Cliente");
            }
            catch (Exception ex)
            {
                //ViewBag.Error = ex.Message;
                ViewBag.categoria = db.CategoriaTBL.ToList();
                return View("EditarCliente");
            }
        }

        // GET: MarcaController/Delete/5
        public ActionResult EliminarCliente(int id)
        {
            ClienteML cln = new ClienteML();
            cln.ClienteId = id;
            var query = db.ClienteTBL.Where(x => x.ClienteId.Equals(id));
            if (query != null)
            {
                db.ClienteTBL.Remove(cln);
                int result = db.SaveChanges();
            }
            return RedirectToAction("Cliente");
        }

        #endregion


        #endregion

        /*Miguel _________________________________________________________________________________________*/

       
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
    }
}
