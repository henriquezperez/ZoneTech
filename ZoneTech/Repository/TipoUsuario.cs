using ZoneTech.Data;
using ZoneTech.Models;
using ZoneTech.Services;

namespace ZoneTech.Repository
{
    public class TipoUsuario : ITipoUsuario
    {
        private ApplicationDBContext app;

        public TipoUsuario(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddTipoUsuario(TipoUsuarioML tip)
        {
            app.TipoUsuarioTBL.Add(tip);
            app.SaveChanges();
        }

        public void DeleteTipoUsuario(TipoUsuarioML tip)
        {
            app.TipoUsuarioTBL.Remove(tip);
            app.SaveChanges();
        }

        public List<TipoUsuarioML> GetAllTipoUsuarioList()
        {
            return app.TipoUsuarioTBL.ToList();
        }

        public TipoUsuarioML LoadInfo(TipoUsuarioML tip)
        {
            throw new NotImplementedException();
        }

        public void UpdateTipoUsuario(TipoUsuarioML tip)
        {
            app.TipoUsuarioTBL.Update(tip);
            app.SaveChanges();
        }
    }
}
