using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Dtos.TripsDtos
{
    public class TripSearchDto
    {
        public bool TwoWay { get; set; }
        public int Quantity { get; set; }
        public string DepartureDate { get; set; } = string.Empty;
        public string ReturnDate { get; set; } = string.Empty;
        public int StartBranchId { get; set; }
        public int EndBranchId { get; set; }
    }
}
