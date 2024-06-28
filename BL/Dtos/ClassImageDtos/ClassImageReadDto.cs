using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Dtos.ClassImageDtos
{
    public class ClassImageReadDto
    {
        public int Id { get; set; }
        public string ImageURL { get; set; } = string.Empty;
        public int BusClassId { get; set; }
    }
}
