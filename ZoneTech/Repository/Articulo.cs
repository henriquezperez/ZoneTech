using Microsoft.EntityFrameworkCore;
using ZoneTech.Data;
using ZoneTech.Models;
using ZoneTech.Services;

namespace ZoneTech.Repository
{
    public class Articulo : IArticulo
    {
        private ApplicationDBContext app;

        public Articulo(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddArticulo(ArticuloML art)
        {
            app.ArticuloTBL.Add(art);
            app.SaveChanges();
        }

        public void DeleteArticulo(ArticuloML art)
        {
            app.ArticuloTBL.Remove(art);
            app.SaveChanges();
        }

        public List<ArticuloML> GetAllArticulosList()
        {
            return app.ArticuloTBL.ToList();
        }

        public List<ArticuloML> LoadInfoArticulos(ArticuloML art)
        {
            var articulos = new List<ArticuloML>();

            var select = app.ArticuloTBL.AsQueryable();
            select = QuerySelect(select, art).Include(s => s.MarcaId).AsQueryable();
            select = QuerySelect(select, art).Include(s => s.ModeloId).AsQueryable();
            select = QuerySelect(select, art).Include(s => s.CategoriaId).AsQueryable();
            articulos = select.ToList();

            return articulos;
        }

        public void UpdateArticulo(ArticuloML art)
        {
            app.ArticuloTBL.Update(art);
            app.SaveChanges();
        }

        internal static IQueryable<ArticuloML> QuerySelect(IQueryable<ArticuloML> pQuery, ArticuloML pArticulo)
        {
            if (pArticulo.ArticuloId > 0)
                pQuery = pQuery.Where(s => s.ArticuloId == pArticulo.ArticuloId);
            if (pArticulo.MarcaId > 0)
                pQuery = pQuery.Where(s => s.MarcaId == pArticulo.MarcaId);
            if (pArticulo.CategoriaId > 0)
                pQuery = pQuery.Where(s => s.CategoriaId == pArticulo.CategoriaId);
            if (pArticulo.ModeloId > 0)
                pQuery = pQuery.Where(s => s.ModeloId == pArticulo.ModeloId);
            if (!string.IsNullOrWhiteSpace(pArticulo.Nombre))
                pQuery = pQuery.Where(s => s.Nombre.Contains(pArticulo.Nombre));
            if (!string.IsNullOrWhiteSpace(pArticulo.Descripcion))
                pQuery = pQuery.Where(s => s.Descripcion.Contains(pArticulo.Descripcion));
            if (pArticulo.Costo > 0)
                pQuery = pQuery.Where(s => s.Costo == pArticulo.Costo);
            if (pArticulo.Precio > 0)
                pQuery = pQuery.Where(s => s.Precio == pArticulo.Precio);
            if (pArticulo.EstadoId > 0)
                pQuery = pQuery.Where(s => s.EstadoId == pArticulo.EstadoId);
            pQuery = pQuery.OrderByDescending(s => s.ArticuloId).AsQueryable();
            return pQuery;
        }
    }
}
