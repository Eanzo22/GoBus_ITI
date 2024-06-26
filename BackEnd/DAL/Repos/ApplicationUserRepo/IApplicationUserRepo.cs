﻿using DAL.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace DAL.Repos.ApplicationUserRepo;

public interface IApplicationUserRepo
{
    Task<IEnumerable<ApplicationUser>?> GetAllAsync();
    Task<IEnumerable<ApplicationUser>?> GetAllUsersAsync();
    Task<IEnumerable<ApplicationUser>?> GetAllDriversAsync();
    Task<IEnumerable<ApplicationUser>?> GetAllAdminsAsync();
    Task<IEnumerable<ApplicationUser>?> GetAllUsersWithDetailsAsync();
    Task<IEnumerable<ApplicationUser>?> GetAllDriversWithDetailsAsync();
    Task<IEnumerable<ApplicationUser>?> GetAllByRoleAsync(string roleId);
    Task<ApplicationUser?> GetUserByIdWithDetailsAsync(string id);
    Task<ApplicationUser?> GetDriverByIdWithDetailsAsync(string id);
    Task<ApplicationUser?> GetByIdAsync(string id);
    Task<IEnumerable<IdentityError>> AddAsync(ApplicationUser applicationUser, string password);
    void DeleteAsync(ApplicationUser applicationUser);
}
