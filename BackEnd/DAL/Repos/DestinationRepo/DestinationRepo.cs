using DAL.Data.Context;
using DAL.Data.Models;

using DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.DestinationRepo
{
    public class DestinationRepo: GenericRepo<Destination>,IDestinationRepo
    {
        private readonly AppDbContext _appDbContext;

        public DestinationRepo(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IEnumerable<Destination>?> GetAllWithBranchesDetailsAsync()
        {
            return await
                _appDbContext
                .Destinations
                .Include(x => x.EndBranchs)
                .ToListAsync();
        }

    }
}
