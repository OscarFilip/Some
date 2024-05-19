using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModels
{
    public class VehicleReportDTO
    {
        [Required]
        public string RegistrationNumber { get; set; }
        [Required]
        public string ReportDescripton { get; set; }
    }
}
