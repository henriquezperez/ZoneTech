using ZoneTech.Data;
using ZoneTech.Models;
using ZoneTech.Services;

namespace ZoneTech.Repository
{
    public class Venta : IVenta
    {
        private ApplicationDBContext app;

        public Venta(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddVenta(VentaML vnt)
        {
            app.VentaTBL.Add(vnt);
            app.SaveChanges();
        }

        public List<VentaML> GetAllList()
        {
            return app.VentaTBL.ToList();
        }

        public VentaML LoadInfoVenta(VentaML vnt)
        {
            throw new NotImplementedException();
        }
    }
}
