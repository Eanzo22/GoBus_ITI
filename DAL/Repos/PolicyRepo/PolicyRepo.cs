using DAL.Data.Context;
using DAL.Data.Models;
using DAL.Repos.GenericRepo;

namespace DAL.Repos.PolicyRepo;

public class PolicyRepo : GenericRepo<Policy>, IPolicyRepo
{
    private readonly AppDbContext _appDbContext;

    public PolicyRepo(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }
}
