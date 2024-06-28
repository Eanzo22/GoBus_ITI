using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Models
{
    public class Report
    {
        public int Id { get; set; }
        public int ReservationNumber { get; set; }
        public string MessageTitle { get; set; } = string.Empty;
        public string MessageContent { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;
    }
}
