using DAL.Data.Models;
using DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.BusClassRepo
{
    public interface IBusClassRepo : IGenericRepo<BusClass>
    {
        Task<IEnumerable<BusClass>?> GetAllWithDetailsAsync();
        Task<BusClass?> GetByIdWithDetailsAsync(int id);
    }
}
