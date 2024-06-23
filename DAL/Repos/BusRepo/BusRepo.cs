using DAL.Data.Context;
using DAL.Data.Models;
using DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repos.BusRepo;

public class BusRepo : GenericRepo<Bus>, IBusRepo
{
    private readonly AppDbContext _appDbContext;

    public BusRepo(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<IEnumerable<Bus>?> GetAllByBusClassIdAsync(int id)
    {
        return await
            _appDbContext
            .Buses
            .Include(x => x.BusClass)
            .Include(x => x.Driver)
            .Where(x => x.BusClassId == id)
            .ToListAsync();
    }

    public async Task<IEnumerable<Bus>?> GetAllWithBusClassAsync()
    {
        return await
            _appDbContext
            .Buses
            .Include(x => x.BusClass)
            .Include(x => x.Driver)
            .ToListAsync();
    }

    public async Task<IEnumerable<Bus>?> GetAllAvailableBusesAsync()
    {
        return await
            _appDbContext
            .Buses
            .Include(x => x.BusClass)
            .Include(x => x.Trips)
            .ToListAsync();
    }

    public async Task<Bus?> GetByIdWithBusClassAsync(int id)
    {
        return await
            _appDbContext
            .Buses
            .Include(x => x.BusClass)
            .Include(x => x.Driver)
            .FirstOrDefaultAsync(x => x.Id == id);
    }
}
