using ClassModels;
using LIAProv.Data;
using Microsoft.EntityFrameworkCore;

namespace LIAProv.Services
{
    public class VehicleReportRepo : IVehicleReport<VehicleReport>
    {
        private AppDbContext _appDbContext;
        public VehicleReportRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<VehicleReport> AddReport(VehicleReport vehicleReport)
        {
            var result = await _appDbContext.VehicleReports.AddAsync(vehicleReport);
            await _appDbContext.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<IEnumerable<VehicleReport>> GetReports()
        {
            return await _appDbContext.VehicleReports.ToListAsync();
        }
    } 
}
