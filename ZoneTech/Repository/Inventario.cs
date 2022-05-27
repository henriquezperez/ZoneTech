using ZoneTech.Data;
using ZoneTech.Models;
using ZoneTech.Services;

namespace ZoneTech.Repository
{
    public class Inventario : IInventario
    {
        private ApplicationDBContext app;

        public Inventario(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddInventario(InventarioML inv)
        {
            app.InventarioTBL.Add(inv);
            app.SaveChanges();
        }

        public void DeleteInventario(InventarioML inv)
        {
            app.InventarioTBL.Remove(inv);
            app.SaveChanges();
        }

        public List<InventarioML> GetAllInventario()
        {
            return app.InventarioTBL.ToList();
        }

        public InventarioML LoadInfoInventario(InventarioML inv)
        {
            throw new NotImplementedException();
        }

        public void UpdateInventario(InventarioML inv)
        {
            app.InventarioTBL.Update(inv);
            app.SaveChanges();
        }
    }
}
