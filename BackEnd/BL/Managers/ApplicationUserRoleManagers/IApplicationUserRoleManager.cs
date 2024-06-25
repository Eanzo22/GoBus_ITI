using BL.Dtos.ApplicationUserRoleDto;
using DAL.Data.Models;

namespace BL.Managers.ApplicationUserRoleManagers;

public interface IApplicationUserRoleManager
{
    Task<Response> AddAsync(ApplicationUserRoleAddDto applicationUserRoleAddDto);
    Task<Response> DeleteAsync(string userId);
}
