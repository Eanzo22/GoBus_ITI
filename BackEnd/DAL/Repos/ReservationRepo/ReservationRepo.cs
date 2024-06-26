﻿using DAL.Data.Context;
using DAL.Data.Models;
using DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repos.ReservationRepo;

public class ReservationRepo : GenericRepo<Reservation>, IReservationRepo
{
    private readonly AppDbContext _appDbContext;

    public ReservationRepo(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }


    public async Task<IEnumerable<Reservation>?> GetAllWithTripDetailsAsync()
    {
        return await _appDbContext
            .Reservations

            .Include(x => x.User)

            .Include(x => x.Tickets)

            .Include(x => x.Trip)
            .ThenInclude(y => y.StartBranch)

            .Include(x => x.Trip)
            .ThenInclude(y => y.EndBranch)

            .Include(x => x.Trip)
            .ThenInclude(y => y.Bus)
            .ThenInclude(z => z.BusClass)

            .ToListAsync();
    }

    public async Task<IEnumerable<Reservation>?> GetAllWithTripDetailsByUserIdAsync(string id)
    {
        return await _appDbContext.
             Reservations

            .Include(x => x.User)

            .Include(x => x.Tickets)

            .Include(x => x.Trip)
            .ThenInclude(y => y.StartBranch)

            .Include(x => x.Trip)
            .ThenInclude(y => y.EndBranch)

            .Include(x => x.Trip)
            .ThenInclude(y => y.Bus)
            .ThenInclude(z => z.BusClass)

            .Where(x => x.UserId == id)

            .ToListAsync();
    }

    public async Task<IEnumerable<Reservation>?> GetAllByTripIdAsync(int id)
    {
        return await _appDbContext
             .Reservations

             .Include(x => x.User)

             .Include(x => x.Tickets)

             .Include(x => x.Trip)
             .ThenInclude(y => y.StartBranch)

             .Include(x => x.Trip)
             .ThenInclude(y => y.EndBranch)

             .Include(x => x.Trip)
             .ThenInclude(y => y.Bus)
             .ThenInclude(z => z.BusClass)

             .ToListAsync();
    }

    public async Task<Reservation?> GetByIdWithTripDetailsAsync(int id)
    {
        return await _appDbContext
            .Reservations

            .Include(x => x.User)

            .Include(x => x.Tickets)

            .Include(x => x.Trip)
            .ThenInclude(y => y.StartBranch)

            .Include(x => x.Trip)
            .ThenInclude(y => y.EndBranch)

            .Include(x => x.Trip)
            .ThenInclude(y => y.Bus)
            .ThenInclude(z => z.BusClass)

            .FirstOrDefaultAsync(x => x.Id == id);
    }
}
