using ZoneTech.Models;

namespace ZoneTech.Services
{
    public interface ICarrito
    {
        public void AddCarrito(CarritoML crt);
        public void UpdateCarrito(CarritoML crt);
        public void DelteCarrito(CarritoML crt);
        public List<CarritoML> GetAllCarrito();
        public CarritoML LoadInfoCarrito(CarritoML crt);
    
    }
}
