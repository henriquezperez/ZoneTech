using ZoneTech.Models;

namespace ZoneTech.Services
{
    public interface IEstado
    {
        public void AddEstado(EstadoML est);
        public void UpdateEstado(EstadoML est);
        public void DeleteEstado(EstadoML est);
        public List<EstadoML> GetAllEstadoList();
        public EstadoML LoadInformation(EstadoML est);

    }
}
