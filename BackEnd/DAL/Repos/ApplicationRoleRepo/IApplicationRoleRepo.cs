using DAL.Data.Models;
using DAL.Repos.GenericRepo;

namespace DAL.Repos.ApplicationRoleRepo;

public interface IApplicationRoleRepo : IGenericRepo<ApplicationRole>
{
    Task<ApplicationRole?> GetByIdAsync(string id);
}
