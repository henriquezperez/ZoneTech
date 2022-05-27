using ZoneTech.Data;
using ZoneTech.Models;
using ZoneTech.Services;

namespace ZoneTech.Repository
{
    public class Carrito : ICarrito
    {
        private ApplicationDBContext app;

        public Carrito(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddCarrito(CarritoML crt)
        {
            app.CarritoTBL.Add(crt);
            app.SaveChanges();
        }

        public void DelteCarrito(CarritoML crt)
        {
            app.CarritoTBL.Remove(crt);
            app.SaveChanges();
        }

        public List<CarritoML> GetAllCarrito()
        {
            return app.CarritoTBL.ToList();
        }

        public CarritoML LoadInfoCarrito(CarritoML crt)
        {
            throw new NotImplementedException();
        }

        public void UpdateCarrito(CarritoML crt)
        {
            app.CarritoTBL.Update(crt);
            app.SaveChanges();
        }
    }
}
