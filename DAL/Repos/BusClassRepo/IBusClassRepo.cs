using DAL.Data.Models;
using DAL.Repos.GenericRepo;

namespace DAL.Repos.BusClassRepo;

public interface IBusClassRepo : IGenericRepo<BusClass>
{
    Task<IEnumerable<BusClass>?> GetAllWithDetailsAsync();
    Task<BusClass?> GetByIdWithDetailsAsync(int id);
}
