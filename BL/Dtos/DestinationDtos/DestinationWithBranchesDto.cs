using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Dtos.EndBranchDtos;


namespace BL.Dtos.DestinationDtos
{
    public class DestinationWithBranchesDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public IEnumerable<EndBranchReadDto> Branches { get; set; } = new List<EndBranchReadDto>();
    }
}
