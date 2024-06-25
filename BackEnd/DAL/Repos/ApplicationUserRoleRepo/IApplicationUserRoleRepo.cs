using DAL.Data.Models;
using DAL.Repos.GenericRepo;

namespace DAL.Repos.ApplicationUserRoleRepo;

public interface IApplicationUserRoleRepo : IGenericRepo<ApplicationUserRole>
{
    Task<ApplicationUserRole?> GetByUserIdAsync(string userId);
}
