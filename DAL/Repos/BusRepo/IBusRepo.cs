using DAL.Data.Models;
using DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.RepoS
{
    public interface IBusRepo: IGenericRepo<Bus>
    {
        Task<IEnumerable<Bus>?> GetAllByBusClassIdAsync(int id);
        Task<IEnumerable<Bus>?> GetAllWithBusClassAsync();
        Task<IEnumerable<Bus>?> GetAllAvailableBusesAsync();
        Task<Bus?> GetByIdWithBusClassAsync(int id);
    }
}
