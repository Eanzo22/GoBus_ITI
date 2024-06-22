using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Models
{
    public class Response
    {
        public bool Success { get; set; }
        public object? Data { get; set; } = new object();
        public object? Messages { get; set; } = new object();
    }
}
