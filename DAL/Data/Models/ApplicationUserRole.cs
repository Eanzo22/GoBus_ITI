using Microsoft.AspNetCore.Identity;

namespace DAL.Data.Models;

public class ApplicationUserRole : IdentityUserRole<string>
{
    public ApplicationUser ApplicationUser { get; set; } = null!;
    public ApplicationRole ApplicationRole { get; set; } = null!;
}
