using ZoneTech.Models;

namespace ZoneTech.Services
{
    public interface IMarca
    {
        public void AddMarca(MarcaML mrc);
        public void UpdateMarca(MarcaML mrc);
        public void DeleteMarca(MarcaML mrc);
        public List<MarcaML> GetMarcaML();
        public MarcaML LoadInfo(MarcaML mrc);
    }
}
