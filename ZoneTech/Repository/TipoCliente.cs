using ZoneTech.Data;
using ZoneTech.Models;
using ZoneTech.Services;

namespace ZoneTech.Repository
{
    public class TipoCliente : ITipoCliente
    {
        private ApplicationDBContext app;

        public TipoCliente(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddTipoCliente(TipoClienteML tip)
        {
            app.TipoClienteTBL.Add(tip);
            app.SaveChanges();
        }

        public void DeleteTipoCliente(TipoClienteML tip)
        {
            app.TipoClienteTBL.Remove(tip);
            app.SaveChanges();
        }

        public List<TipoClienteML> GetAllTipoClienteList()
        {
            return app.TipoClienteTBL.ToList();
        }

        public TipoClienteML LoadInfo(TipoClienteML tip)
        {
            throw new NotImplementedException();
        }

        public void UpdateTipoCliente(TipoClienteML tip)
        {
            app.TipoClienteTBL.Update(tip);
            app.SaveChanges();
        }
    }
}
