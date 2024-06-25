using DAL.Data.Context;
using DAL.Data.Models;
using DAL.Repos.GenericRepo;

namespace DAL.Repos.ApplicationRoleRepo;

public class ApplicationRoleRepo : GenericRepo<ApplicationRole>, IApplicationRoleRepo
{
    private readonly AppDbContext _appDbContext;

    public ApplicationRoleRepo(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<ApplicationRole?> GetByIdAsync(string id)
    {
        return await _appDbContext.Set<ApplicationRole>().FindAsync(id);
    }
}
