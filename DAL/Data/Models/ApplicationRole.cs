using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Models
{
    public class ApplicationRole: IdentityRole
    {
        public IEnumerable<ApplicationUserRole> ApplicationUserRoles { get; set; } = new List<ApplicationUserRole>();

    }
}
