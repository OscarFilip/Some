using ClassModels;
using LIAProv.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace LIAProv.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleReportController : ControllerBase
    { 
        private IVehicleReport<VehicleReport> _vehicleReport;
        
        public VehicleReportController(IVehicleReport<VehicleReport> vehicleReport)
        {
            _vehicleReport = vehicleReport;
        }

        [HttpGet]
        public async Task<ActionResult<List<VehicleReport>>> GetReports()
        {
            try
            {
                var result = await _vehicleReport.GetReports();
                if (result == null)
                {
                    return NotFound("Cant find any reports");
                }
                return Ok(result); 
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"{ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(VehicleReportDTO report)
        {
            var entity = new VehicleReport()
            {
                RegistrationNumber = report.RegistrationNumber,
                ReportDescripton = report.ReportDescripton,
            };
            try
            {
                var result = await _vehicleReport.AddReport(entity);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"{ex.Message}");
            }
        }


    }
}
