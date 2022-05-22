using ZoneTech.Models;

namespace ZoneTech.Services
{
    public interface IUsuario
    {
        public void AddUsuario(UsuarioML user);
        public void DeleteUsuario(UsuarioML user);
        public void UpdateUsuario(UsuarioML user);
        public List<UsuarioML> GetAllUsuarios();
        public UsuarioML GetUsuario(UsuarioML user);

    }
}
