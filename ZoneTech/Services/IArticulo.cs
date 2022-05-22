using ZoneTech.Models;

namespace ZoneTech.Services
{
    public interface IArticulo
    {
        public void AddArticulo(ArticuloML art);
        public void UpdateArticulo(ArticuloML art);
        public void DeleteArticulo(ArticuloML art);
        public List<ArticuloML> GetAllArticulosList();
        public ArticuloML LoadInfoArticulos(ArticuloML art);

    }
}
