using ZoneTech.Data;
using ZoneTech.Models;
using ZoneTech.Services;

namespace ZoneTech.Repository
{
    public class DetalleCompra : IDetalleCompra
    {
        private ApplicationDBContext app;

        public DetalleCompra(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddDetalleCompra(DetalleCompraML dtl)
        {
            app.DetalleCompraTBL.Add(dtl);
            app.SaveChanges();
        }

        public List<DetalleCompraML> GetAllDetalleCompra()
        {
            return app.DetalleCompraTBL.ToList();
        }

        public DetalleCompraML LoadInfoDetalleCompra(DetalleCompraML dtl)
        {
            throw new NotImplementedException();
        }
    }
}
