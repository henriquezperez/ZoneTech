using ZoneTech.Data;
using ZoneTech.Models;
using ZoneTech.Services;

namespace ZoneTech.Repository
{
    public class Departamento : IDepartamento
    {
        private ApplicationDBContext app;

        public Departamento(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddDepartamento(DepartamentoML dpm)
        {
            app.DepartamentoTBL.Add(dpm);
            app.SaveChanges();
        }

        public void DeleteDepartamento(DepartamentoML dpm)
        {
            app.DepartamentoTBL.Remove(dpm);
            app.SaveChanges();
        }

        public List<DepartamentoML> GetDepartamentoList()
        {
            return app.DepartamentoTBL.ToList();
        }

        public DepartamentoML LoadInfo(DepartamentoML dpm)
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartamento(DepartamentoML dpm)
        {
            app.DepartamentoTBL.Update(dpm);
            app.SaveChanges();
        }
    }
}
