using ZoneTech.Data;
using ZoneTech.Models;
using ZoneTech.Services;

namespace ZoneTech.Repository
{
    public class Marca : IMarca
    {
        private ApplicationDBContext app;

        public Marca(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddMarca(MarcaML mrc)
        {
            app.MarcaTBL.Add(mrc);
            app.SaveChanges();
        }

        public void DeleteMarca(MarcaML mrc)
        {
            app.MarcaTBL.Remove(mrc);
            app.SaveChanges();
        }

        public List<MarcaML> GetMarcaML()
        {
            return app.MarcaTBL.ToList();
        }

        public MarcaML LoadInfo(MarcaML mrc)
        {
            throw new NotImplementedException();
        }

        public void UpdateMarca(MarcaML mrc)
        {
            app.MarcaTBL.Update(mrc);
            app.SaveChanges();
        }
    }
}
