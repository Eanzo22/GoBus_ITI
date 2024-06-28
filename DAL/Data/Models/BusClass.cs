using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Models
{
    public class BusClass
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string AveragePrice { get; set; } = string.Empty;
        public IEnumerable<Bus> Buses { get; set; } = new List<Bus>();
        public IEnumerable<ClassImage> ClassImages { get; set; } = new List<ClassImage>();
    }
}
