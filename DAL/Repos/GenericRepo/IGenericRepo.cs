using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

{
    public interface IGenericRepo<Entity> where Entity : class
    {
        Task<IEnumerable<Entity>?> GetAllAsync();
        Task<Entity?> GetByIdAsync(int id);
        Task AddAsync(Entity entity);
        void Delete(Entity entity);
    }
}
