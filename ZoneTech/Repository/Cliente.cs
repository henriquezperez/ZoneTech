using ZoneTech.Data;
using ZoneTech.Models;
using ZoneTech.Services;

namespace ZoneTech.Repository
{
    public class Cliente : ICliente
    {
        private ApplicationDBContext app;

        public Cliente(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddCliente(ClienteML clt)
        {
            app.ClienteTBL.Add(clt);
            app.SaveChanges();
        }

        public void DeleteCliente(ClienteML clt)
        {
            app.ClienteTBL.Remove(clt);
            app.SaveChanges();
        }

        public List<ClienteML> GetClienteML()
        {
            return app.ClienteTBL.ToList();
        }

        public ClienteML LoadInfo(ClienteML clt)
        {
            throw new NotImplementedException();
        }

        public void UpdateCliente(ClienteML clt)
        {
            app.ClienteTBL.Update(clt);
            app.SaveChanges();
        }
    }
}
