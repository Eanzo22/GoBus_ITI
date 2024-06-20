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

namespace DAL.UnitOfWorks
{
    public interface IUnitOfWork
    {
        public IDestinationRepo DestinationRepo { get; }
        public IEndBranchRepo EndBranchRepo { get; }
        public IStartBranchRepo StartBranchRepo { get; }
        public ITripRepo TripRepo { get; }
        Task<int> SaveChangesAsync();
        Response Response(bool success, object? data, object? messages);


    }
}
