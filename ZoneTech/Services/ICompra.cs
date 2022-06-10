using ZoneTech.Models;

namespace ZoneTech.Services
{
    public interface ICompra
    {
        public void AddCompra(CompraML cmp);
        //  public void DeleteCompra(CompraML cmp);
        //  public void UpdateCompra(CompraML cmp);
        public List<CompraML> GetAllCompra();
        public CompraML LoadInfoCompra(CompraML id);

    }
}
