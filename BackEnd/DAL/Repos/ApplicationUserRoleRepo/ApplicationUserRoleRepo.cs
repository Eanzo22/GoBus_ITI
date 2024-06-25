using DAL.Data.Context;
using DAL.Data.Models;
using DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repos.ApplicationUserRoleRepo;

public class ApplicationUserRoleRepo : GenericRepo<ApplicationUserRole>, IApplicationUserRoleRepo
{
    private readonly AppDbContext _appDbContext;

    public ApplicationUserRoleRepo(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<ApplicationUserRole?> GetByUserIdAsync(string userId)
    {
        return await _appDbContext
            .ApplicationUserRoles

            .FirstOrDefaultAsync(x => x.ApplicationUser.Id == userId);
    }
}
