using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Dtos.EndBranchDtos
{
    public class EndBranchWithDestinationNameDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string DestinationName { get; set; } = string.Empty;
        public int DestinationId { get; set; }
    }
}
