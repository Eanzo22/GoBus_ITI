using DAL.Data.Models;
using DAL.Repos.GenericRepo;

namespace DAL.Repos.BusRepo;

public interface IBusRepo : IGenericRepo<Bus>
{
    Task<IEnumerable<Bus>?> GetAllByBusClassIdAsync(int id);
    Task<IEnumerable<Bus>?> GetAllWithBusClassAsync();
    Task<IEnumerable<Bus>?> GetAllAvailableBusesAsync();
    Task<Bus?> GetByIdWithBusClassAsync(int id);
}
