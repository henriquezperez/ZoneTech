using ZoneTech.Models;

namespace ZoneTech.Services
{
    public interface IMunicipio
    {
        public void AddMunicipio(MunicipioML mnl);
        public void UpdateMunicipio(MunicipioML mnl);
        public void DeleteMunicipio(MunicipioML mnl);
        public List<MunicipioML> GetMunicipioML();
        public MunicipioML LoadInfo(MunicipioML mnl);
    }
}
