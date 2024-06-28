using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Models
{
    public class ClassImage
    {
        public int Id { get; set; }
        public string ImageURL { get; set; } = string.Empty;
        public int BusClassId { get; set; }
        public BusClass BusClass { get; set; } = null!;
    }
}
