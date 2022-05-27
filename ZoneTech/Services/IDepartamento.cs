using ZoneTech.Models;

namespace ZoneTech.Services
{
    public interface IDepartamento
    {
        public void AddDepartamento(DepartamentoML dpm);
        public void UpdateDepartamento(DepartamentoML dpm);
        public void DeleteDepartamento(DepartamentoML dpm);
        public List<DepartamentoML> GetDepartamentoList();
        public  DepartamentoML LoadInfo(DepartamentoML dpm);

    }
}
