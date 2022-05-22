using ZoneTech.Models;

namespace ZoneTech.Services
{
    public interface IModelo
    {
        public void AddModelo(ModeloML mdl);
        public void UpdateModelo(ModeloML mdl);
        public void DeleteModelo(ModeloML mdl);
        public List<ModeloML> GetModelos();
        public ModeloML LoadInfoModelos(ModeloML mdl);

    }
}
