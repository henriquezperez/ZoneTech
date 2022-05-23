using ZoneTech.Data;
using ZoneTech.Models;
using ZoneTech.Services;

namespace ZoneTech.Repository
{
    public class Estado : IEstado
    {
        private ApplicationDBContext app;

        public Estado(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddEstado(EstadoML est)
        {
            app.EstadoTBL.Add(est);
            app.SaveChanges();
        }

        public void DeleteEstado(EstadoML est)
        {
            app.EstadoTBL.Remove(est);
            app.SaveChanges();
        }

        public List<EstadoML> GetAllEstadoList()
        {
            return app.EstadoTBL.ToList();
        }

        public EstadoML LoadInformation(EstadoML est)
        {
            throw new NotImplementedException();
        }

        public void UpdateEstado(EstadoML est)
        {
            app.EstadoTBL.Update(est);
            app.SaveChanges();
        }
    }
}
