using ZoneTech.Data;
using ZoneTech.Models;
using ZoneTech.Services;

namespace ZoneTech.Repository
{
    public class Municipio : IMunicipio
    {
        private ApplicationDBContext app;

        public Municipio(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddMunicipio(MunicipioML mnl)
        {
            app.MunicipioTBL.Add(mnl);
            app.SaveChanges();
        }

        public void DeleteMunicipio(MunicipioML mnl)
        {
            app.MunicipioTBL.Remove(mnl);
            app.SaveChanges();
        }

        public List<MunicipioML> GetMunicipioML()
        {
            return app.MunicipioTBL.ToList();
        }

        public MunicipioML LoadInfo(MunicipioML mnl)
        {
            throw new NotImplementedException();
        }

        public void UpdateMunicipio(MunicipioML mnl)
        {
            app.MunicipioTBL.Update(mnl);
            app.SaveChanges();
        }
    }
}
