using ZoneTech.Models;

namespace ZoneTech.Services
{
    public interface ICliente
    {
        public void AddCliente(ClienteML clt);
        public void DeleteCliente(ClienteML clt);
        public void UpdateCliente(ClienteML clt);
        public List<ClienteML> GetClienteML();
        public ClienteML LoadInfo(ClienteML clt);

    }
}
