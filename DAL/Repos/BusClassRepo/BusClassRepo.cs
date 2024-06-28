using DAL.Data.Context;
using DAL.Data.Models;
using DAL.Repos.GenericRepo;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.BusClassRepo
{
    public class BusClassRepo : GenericRepo<BusClass> , IBusClassRepo
    {
        private readonly AppDbContext _appDbContext;
        public BusClassRepo(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

         

        public async Task<IEnumerable<BusClass>?> GetAllWithDetailsAsync()
        {
            return await _appDbContext.BusClasses.Include(x => x.ClassImages)
                   .Include(x => x.Buses)
                   .ToListAsync();
        }

        public async Task<BusClass?> GetByIdWithDetailsAsync(int id)
        {
            return await _appDbContext.BusClasses.Include(x => x.ClassImages)
                  .Include(x => x.Buses)
                  .FirstOrDefaultAsync(x=>x.Id==id);

        }

       
    }
}
