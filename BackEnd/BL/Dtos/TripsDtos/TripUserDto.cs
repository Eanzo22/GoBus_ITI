using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Dtos.TripsDtos
{
    public class TripUserDto
    {
        public int Id { get; set; }
        public int AvailableSeats { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int BusId { get; set; }
        public string BusClassName { get; set; } = string.Empty;
        public string StartBranchName { get; set; } = string.Empty;
        public string EndBranchName { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
