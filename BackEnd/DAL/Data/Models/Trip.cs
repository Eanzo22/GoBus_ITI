﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public int AvailableSeats { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public decimal Price { get; set; }
        public int BusId { get; set; }
        public int StartBranchId { get; set; }
        public StartBranch StartBranch { get; set; } = null!;
        public int EndBranchId { get; set; }
        public EndBranch EndBranch { get; set; } = null!;
        public Bus Bus { get; set; } = null!;
        public IEnumerable<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
