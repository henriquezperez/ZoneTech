using ZoneTech.Models;

namespace ZoneTech.Services
{
    public interface IInventario
    {
        public void AddInventario(InventarioML inv);
        public void UpdateInventario(InventarioML inv);
        public void DeleteInventario(InventarioML inv);
        public List<InventarioML> GetAllInventario();
        public InventarioML LoadInfoInventario(InventarioML inv);

    }
}
