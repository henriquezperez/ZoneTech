using ZoneTech.Models;

namespace ZoneTech.Services
{
    public interface IDetalleCompra
    {
        public void AddDetalleCompra(DetalleCompraML dtl);
       // public void DeleteDetalleCompra(DetalleCompraML dtl);
       // public void UpdateDetalleCompra(DetalleCompraML dtl);
        public List<DetalleCompraML> GetAllDetalleCompra();
        public DetalleCompraML LoadInfoDetalleCompra(DetalleCompraML dtl);
    }
}
