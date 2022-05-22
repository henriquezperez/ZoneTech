using ZoneTech.Models;

namespace ZoneTech.Services
{
    public interface IVenta
    {
        public void AddVenta(VentaML vnt);
        //public void UpdateVenta(VentaML vnt);
       // public void DeleteVenta(VentaML vnt);
        public List<VentaML> GetAllList();
        public VentaML LoadInfoVenta(VentaML vnt);
    }
}
