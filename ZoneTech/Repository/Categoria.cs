using ZoneTech.Data;
using ZoneTech.Models;
using ZoneTech.Services;

namespace ZoneTech.Repository
{
    public class Categoria : ICategoria
    {
        private ApplicationDBContext app;

        public Categoria(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddCategoria(CategoriaML ctg)
        {
            app.CategoriaTBL.Add(ctg);
            app.SaveChanges();
        }

        public void DeleteCategoria(CategoriaML ctg)
        {
            app.CategoriaTBL.Remove(ctg);
            app.SaveChanges();
        }

        public List<CategoriaML> GetCategoriaML()
        {
            return app.CategoriaTBL.ToList();
        }

        public CategoriaML LoadInfoCategoria(CategoriaML ctg)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategoria(CategoriaML ctg)
        {
            app.CategoriaTBL.Update(ctg);
            app.SaveChanges();
        }
    }
}
