﻿using DAL.Data.Context;
using DAL.Data.Models;
using DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repos.BusClassRepo;

public class BusClassRepo : GenericRepo<BusClass>, IBusClassRepo
{
    private readonly AppDbContext _appDbContext;

    public BusClassRepo(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }


    public async Task<IEnumerable<BusClass>?> GetAllWithDetailsAsync()
    {
        return await _appDbContext
            .BusClasses
            .Include(x => x.Buses)
            .Include(x => x.ClassImages)
            .ToListAsync();
    }

    public async Task<BusClass?> GetByIdWithDetailsAsync(int id)
    {
        return await _appDbContext
            .BusClasses
            .Include(x => x.Buses)
            .Include(x => x.ClassImages)
            .FirstOrDefaultAsync(x => x.Id == id);
    }
}
