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

        public IActionResult ControlAdmin(){
            return View();
        }
        //

        public IActionResult TipoClienteNuevo()
        {
            return View();
        }

        public IActionResult InsertTipoCliente(TipoClienteML est)
        {
            db.TipoClienteTBL.Add(est);
            db.SaveChanges();
            return RedirectToAction("TipoCliente");
        }
        
         //READ
        public IActionResult TipoCliente(){
            var lista = db.TipoClienteTBL.ToList();
            ViewBag.listado = lista;
            return View();
        }
        //UPDATE
        public IActionResult TipoClienteEditar(int id){
            var query = db.TipoClienteTBL.Where(x=>x.TipoClienteId.Equals(id)).FirstOrDefault(); //usar FirstOrDefault()
            return View(query);
        }

        public IActionResult TipoClienteActualizar(TipoClienteML est){
            db.TipoClienteTBL.Update(est);
            db.SaveChanges();
            return RedirectToAction("TipoCliente");
        }
        //DELETE
        public IActionResult TipoClienteEliminar(int id){
            TipoClienteML est = new TipoClienteML();
            est.TipoClienteId = id;
            var query = db.TipoClienteTBL.Where(x=>x.TipoClienteId.Equals(id));
            if(query != null){
                db.TipoClienteTBL.Remove(est);
                db.SaveChanges();
            }
            return RedirectToAction("TipoCliente");
        }

        //

        public IActionResult TipoUsuarionuevo()
        {
            var list = db.EstadoTBL.ToList();

            ViewBag.listEstado = list;

            return View();
        }

        public IActionResult InsertTipoUsuario(TipoUsuarioML est)
        {
            db.TipoUsuarioTBL.Add(est);
            db.SaveChanges();
            return RedirectToAction("TipoUsuario");
        }

        //READ
        public IActionResult TipoUsuario()
        {
            var lista = db.TipoUsuarioTBL.ToList();
            ViewBag.listado = lista;
            return View();
        }
        //UPDATE
        public IActionResult TipoUsuarioEditar(int id)
        {
            var query = db.TipoUsuarioTBL.Where(x => x.TipoUsuarioId.Equals(id)).FirstOrDefault(); //usar FirstOrDefault()
            return View(query);
        }

        public IActionResult TipoUsuarioActualizar(TipoUsuarioML est)
        {
            db.TipoUsuarioTBL.Update(est);
            db.SaveChanges();
            return RedirectToAction("TipoUsuario");
        }
        //DELETE
        public IActionResult TipoUsuarioEliminar(int id)
        {
            TipoUsuarioML est = new TipoUsuarioML();
            est.TipoUsuarioId = id;
            var query = db.TipoUsuarioTBL.Where(x => x.TipoUsuarioId.Equals(id));
            if (query != null)
            {
                db.TipoUsuarioTBL.Remove(est);
                db.SaveChanges();
            }
            return RedirectToAction("TipoUsuario");
        }

        //

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

        public IActionResult DepartamentoNuevo()
        {
            return View();
        }

        public IActionResult InsertDepartamento(DepartamentoML est)
        {
            db.DepartamentoTBL.Add(est);
            db.SaveChanges();
            return RedirectToAction("Departamento");
        }

        //READ
        public IActionResult Departamento()
        {
            var lista = db.DepartamentoTBL.ToList();
            ViewBag.listado = lista;
            return View();
        }
        //UPDATE
        public IActionResult DepartamentoEditar(int id)
        {
            var query = db.DepartamentoTBL.Where(x => x.DepartamentoId.Equals(id)).FirstOrDefault(); //usar FirstOrDefault()
            return View(query);
        }

        public IActionResult DepartamentoActualizar(DepartamentoML est)
        {
            db.DepartamentoTBL.Update(est);
            db.SaveChanges();
            return RedirectToAction("Departaemento");
        }
        //DELETE
        public IActionResult DepartamentoEliminar(int id)
        {
            DepartamentoML est = new DepartamentoML();
            est.DepartamentoId = id;
            var query = db.DepartamentoTBL.Where(x => x.DepartamentoId.Equals(id));
            if (query != null)
            {
                db.DepartamentoTBL.Remove(est);
                db.SaveChanges();
            }
            return RedirectToAction("Departamento");
        }

        /*Victor _________________________________________________________________________________________*/

        #region Victor

        #region Marca
        public ActionResult Marca()
        {
            var estd = db.EstadoTBL.ToList();
            ViewBag.estado = estd;
            return View(estd);
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

        #region Categoria

        public ActionResult Categoria()
        {
            var categ = db.CategoriaTBL.ToList();
            ViewBag.categoria = categ;
            return View(categ);
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
            var catg = db.CategoriaTBL.ToList();
            ViewBag.categoria = catg;
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
                ViewBag.categoria = db.CategoriaTBL.ToList();
                return View("CrearCategoria");
            }
        }

        // GET: MarcaController/Edit/5
        public ActionResult EditarCategoria(int id)
        {
            var query = db.CategoriaTBL.Where(x => x.CategoriaId.Equals(id)).FirstOrDefault();
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
                ViewBag.categoria = db.CategoriaTBL.ToList();
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

        #region Modelo

        public ActionResult Modelo()
        {
            var list = from mdl in db.ModeloTBL
                       from mar in db.MarcaTBL
                       from ctg in db.CategoriaTBL
                       where mdl.MarcaId == mar.MarcaId
                          && mdl.CategoriaId == ctg.CategoriaId
                       select new
                       {
                           ID = mdl.ModeloId,
                           Nombre = mdl.Nombre,
                           MarcId = mdl.MarcaId,
                           CtgId = mdl.CategoriaId,
                           Marca = mar.Nombre,
                           Categor = ctg.Nombre

                       };
            ViewBag.query = list;
            var marc = db.MarcaTBL.ToList();
            ViewBag.marca = marc;
            var modl = db.ModeloTBL.ToList();
            ViewBag.modelo = modl;
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
            var modl = db.ModeloTBL.ToList();
            ViewBag.modelo = modl;
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
                ViewBag.categoria = db.CategoriaTBL.ToList();
                return View("CrearModelo");
            }
        }

        // GET: MarcaController/Edit/5
        public ActionResult EditarModelo(int id)
        {
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

        #endregion

        /*Miguel _________________________________________________________________________________________*/

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
    }
}
