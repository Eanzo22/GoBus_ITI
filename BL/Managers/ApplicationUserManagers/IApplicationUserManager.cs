using BL.Dtos.ApplicationUserDtos;
using DAL.Data.Models;

namespace BL.Managers.ApplicationUserManagers;

public interface IApplicationUserManager
{
    Task<Response> GetAllUsersAsync();
    Task<Response> GetAllDriversAsync();
    Task<Response> GetAllAdminsAsync();
    Task<Response> GetAllUsersWithDetailsAsync();
    Task<Response> GetAllDriversWithDetailsAsync();

    Task<Response> GetAllByRoleAsync(string roleId);

    Task<Response> GetUserByIdWithDetailsAsync(string Id);
    Task<Response> GetDriverByIdWithDetailsAsync(string Id);

    Task<Response> GetByIdAsync(string id);

    Task<Response> AddAsync(RegisterDto registerDto);
    Task<Response> RegisterAsync(RegisterDto registerDto);
    Task<Response> RegisterDriverAsync(RegisterDto registerDto);
    Task<Response> RegisterAdminAsync(RegisterDto registerDto);

    Task<Response> GetAllEmailsAsync();
    Task<Response> GetAllUserNamesAsync();
    Task<Response> LoginAsync(LoginDto loginDto);
    Task<Response> BlockUserAsync(string id);
    Task<Response> UpdateAsync(string id, UserUpdateDto userUpdateDto);
    Task<Response> DeleteAsync(string id);
}
