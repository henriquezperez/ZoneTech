using ZoneTech.Models;

namespace ZoneTech.Services
{
    public interface IDetalleVenta
    {
        public void AddDetalleVenta(DetalleVentaML dtm);
       // public void UpdateDetalleVenta(DetalleVentaML dtm);
      //  public void DeleteDetalleVenta(DetalleVentaML dtm);
        public List<DetalleCompraML> GetAllDetalleVenta();
        public DetalleVentaML LoadInfoDetalleVenta(DetalleVentaML dtm);
    }
}
