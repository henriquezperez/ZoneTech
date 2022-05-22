using ZoneTech.Models;

namespace ZoneTech.Services
{
    public interface ITipoCliente
    {
        public void AddTipoCliente(TipoClienteML tip);
        public void UpdateTipoCliente(TipoClienteML tip);
        public void DeleteTipoCliente(TipoClienteML tip);
        public List<TipoClienteML> GetAllTipoClienteList();
        public TipoClienteML LoadInfo(TipoClienteML tip);
    }
}
