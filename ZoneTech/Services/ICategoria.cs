using ZoneTech.Models;

namespace ZoneTech.Services
{
    public interface ICategoria
    {
        public void AddCategoria(CategoriaML ctg);
        public void DeleteCategoria(CategoriaML ctg);
        public void UpdateCategoria(CategoriaML ctg);
        public List<CategoriaML> GetCategoriaML();
        public CategoriaML LoadInfoCategoria(CategoriaML ctg);

    }
}
