using ClassModels;

namespace LIAProv.Services
{
    public interface IVehicleReport<T>
    {
        Task<IEnumerable<T>> GetReports();
        Task<T> AddReport(VehicleReport vehicleReport);
    }
}