using BL.Dtos.ApplicationRoleDtos;
using DAL.Data.Models;

namespace BL.Managers.ApplicationRoleManagers;

public interface IApplicationRoleManager
{
    Task<Response> GetAllAsync();
    Task<Response> GetByIdAsync(string id);
    Task<Response> AddAsync(ApplicationRoleAddDto applicationRoleAddDto);
    Task<Response> UpdateAsync(string id, ApplicationRoleUpdateDto applicationRoleUpdateDto);
    Task<Response> DeleteAsync(string id);
}
