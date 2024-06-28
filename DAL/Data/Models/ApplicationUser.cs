using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public bool Blocked { get; set; } = false;
        public IEnumerable<ApplicationUserRole> ApplicationUserRoles { get; set; } = new List<ApplicationUserRole>();
        public IEnumerable<Bus> Buses { get; set; } = new List<Bus>();
        public IEnumerable<Report> Reports { get; set; } = new List<Report>();

    }
}
