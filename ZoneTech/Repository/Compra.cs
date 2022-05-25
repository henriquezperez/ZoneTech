using ZoneTech.Data;
using ZoneTech.Models;
using ZoneTech.Services;

namespace ZoneTech.Repository
{
    public class Compra : ICompra
    {
        private ApplicationDBContext app;

        public Compra(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddCompra(CompraML cmp)
        {
            app.CompraTBL.Add(cmp);
            app.SaveChanges();
        }

        public List<CompraML> GetAllCompra()
        {
            return app.CompraTBL.ToList();
        }

        public CompraML LoadInfoCompra(CompraML id)
        {
            throw new NotImplementedException();
        }
    }
}
