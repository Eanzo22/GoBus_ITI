using DAL.Repos.EndBranchRepo;
using DAL.Repos.StartBranchRepo;
using DAL.Repos.TripRepo;
using DAL.Repos.DestinationRepo;
using DAL.Data.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repos.PublicActivityRepos;

namespace DAL.UnitOfWorks
{
    public interface IUnitOfWork
    {
        public IDestinationRepo DestinationRepo { get; }
        public IEndBranchRepo EndBranchRepo { get; }
        public IStartBranchRepo StartBranchRepo { get; }
        public ITripRepo TripRepo { get; }
        public IPublicActivityRepo PublicActivityRepo { get; }

        Task<int> SaveChangesAsync();
        Response Response(bool success, object? data, object? messages);


    }
}

using DAL.Repos.ApplicationRoleRepo;
using DAL.Repos.ApplicationUserRepo;
using DAL.Repos.ApplicationUserRoleRepo;
using DAL.Repos.PolicyRepo;
using DAL.Repos.ReservationRepo;

namespace DAL.UnitOfWork;

public interface IUnitOfWork
{
    public IApplicationRoleRepo ApplicationRoleRepo { get; }
    public IApplicationUserRepo ApplicationUserRepo { get; }
    public IApplicationUserRoleRepo ApplicationUserRoleRepo { get; }
    public IPolicyRepo PolicyRepo { get; }
    public IReservationRepo ReservationRepo { get; }

    Task<int> SaveChangesAsync();
    Data.Models.Response Response(bool success, object? data, object? messages);
}
