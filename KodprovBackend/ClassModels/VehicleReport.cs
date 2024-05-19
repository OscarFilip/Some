using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ClassModels
{
    public class VehicleReport
    {
        [Key]
        public int VehicleReportID { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }
        [Required]
        public string ReportDescripton { get; set; }
        public DateTime ReportedAt { get; set; } = DateTime.Now;
    }
}
