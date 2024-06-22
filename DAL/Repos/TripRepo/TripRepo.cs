using DAL.Data.Context;
using DAL.Data.Models;
using DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.TripRepo
{
    public class TripRepo : GenericRepo<Trip>, ITripRepo
    {
        private readonly AppDbContext _appDbContext;

        public TripRepo(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Trip>?> GetAllWithDetailsAsync()
        {
            return await _appDbContext
                .Trips
                .Include(x => x.StartBranch)
                .Include(x => x.EndBranch)
                .ToListAsync();
        }
    }
}
