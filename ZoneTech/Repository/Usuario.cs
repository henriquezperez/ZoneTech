using ZoneTech.Data;
using ZoneTech.Models;
using ZoneTech.Services;

namespace ZoneTech.Repository
{
    public class Usuario : IUsuario
    {
        private ApplicationDBContext app;

        public Usuario(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddUsuario(UsuarioML user)
        {
            app.UsuarioTBL.Add(user);
            app.SaveChanges();
        }

        public void DeleteUsuario(UsuarioML user)
        {
            app.UsuarioTBL.Remove(user);
            app.SaveChanges();
        }

        public List<UsuarioML> GetAllUsuarios()
        {
            return app.UsuarioTBL.ToList();
        }

        public UsuarioML GetUsuario(UsuarioML user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUsuario(UsuarioML user)
        {
            app.UsuarioTBL.Update(user);
            app.SaveChanges();
        }
    }
}
