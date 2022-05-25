using ZoneTech.Data;
using ZoneTech.Models;
using ZoneTech.Services;

namespace ZoneTech.Repository
{
    public class Modelo : IModelo
    {
        private ApplicationDBContext app;

        public Modelo(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddModelo(ModeloML mdl)
        {
            app.ModeloTBL.Add(mdl);
            app.SaveChanges();
        }

        public void DeleteModelo(ModeloML mdl)
        {
            app.ModeloTBL.Remove(mdl);
            app.SaveChanges();
        }

        public List<ModeloML> GetModelos()
        {
            return app.ModeloTBL.ToList();
        }

        public ModeloML LoadInfoModelos(ModeloML mdl)
        {
            throw new NotImplementedException();
        }

        public void UpdateModelo(ModeloML mdl)
        {
            app.ModeloTBL.Update(mdl);
            app.SaveChanges();
        }
    }
}
