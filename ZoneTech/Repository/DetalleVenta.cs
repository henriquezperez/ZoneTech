using ZoneTech.Data;
using ZoneTech.Models;
using ZoneTech.Services;

namespace ZoneTech.Repository
{
    public class DetalleVenta : IDetalleVenta
    {
        private ApplicationDBContext app;

        public DetalleVenta(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddDetalleVenta(DetalleVentaML dtm)
        {
            app.DetalleVentaTBL.Add(dtm);
            app.SaveChanges();
        }

        public List<DetalleVentaML> GetAllDetalleVenta()
        {
            return app.DetalleVentaTBL.ToList();
        }

        public DetalleVentaML LoadInfoDetalleVenta(DetalleVentaML dtm)
        {
            throw new NotImplementedException();
        }
    }
}
