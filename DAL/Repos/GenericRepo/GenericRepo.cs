using DAL.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Generic_Repo
{
    public class GenericRepo<Entity> : IGenericRepo <Entity> where Entity : class
    {
        private readonly AppDbContext _appDbContext;

        public GenericRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task AddAsync(Entity entity)
        {
            await _appDbContext.Set<Entity>().AddAsync(entity);
        }

        public  void Delete(Entity entity)
        {
             _appDbContext.Remove(entity);
        }

        public async Task<IEnumerable<Entity>?> GetAllAsync()
        {
            return await _appDbContext.Set<Entity>().ToListAsync();
        }

        public async Task<Entity?> GetByIdAsync(int id)
        {

            return await _appDbContext.Set<Entity>().FindAsync(id);
        }
    }
}
