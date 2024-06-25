using DAL.Data.Context;
using DAL.Data.Models;
using DAL.Repos.GenericRepo;

namespace DAL.Repos.TermRepo;

public class TermRepo : GenericRepo<Term>, ITermRepo
{
    private readonly AppDbContext _appDbContext;

    public TermRepo(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }
}
