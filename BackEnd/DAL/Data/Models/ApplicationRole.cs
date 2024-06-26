﻿using Microsoft.AspNetCore.Identity;

namespace DAL.Data.Models;

public class ApplicationRole : IdentityRole
{
    public IEnumerable<ApplicationUserRole> ApplicationUserRoles { get; set; } = new List<ApplicationUserRole>();
}
