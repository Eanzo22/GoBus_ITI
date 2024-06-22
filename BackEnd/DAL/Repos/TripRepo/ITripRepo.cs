﻿using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.TripRepo
{
    public interface ITripRepo
    {
        Task<IEnumerable<Trip>?> GetAllWithDetailsAsync();
    }
}