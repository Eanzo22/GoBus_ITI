using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Dtos.ReportDto
{
    public class ReportReadDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int ReservationNumber { get; set; }
        public string MessageTitle { get; set; } = string.Empty;
        public string MessageContent { get; set; } = string.Empty;
    }
}
