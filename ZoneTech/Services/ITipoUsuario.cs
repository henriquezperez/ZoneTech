using ZoneTech.Models;

namespace ZoneTech.Services
{
    public interface ITipoUsuario
    {
        public void AddTipoUsuario(TipoUsuarioML tip);
        public void UpdateTipoUsuario(TipoUsuarioML tip);
        public void DeleteTipoUsuario(TipoUsuarioML tip);
        public List<TipoUsuarioML> GetAllTipoUsuarioList();
        public TipoUsuarioML LoadInfo(TipoUsuarioML tip);

    }
}
