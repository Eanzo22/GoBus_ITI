using DAL.Data.Context;
using DAL.Data.Models;
using DAL.Repos.DestinationRepo;
using DAL.Repos.EndBranchRepo;
using DAL.Repos.PublicActivityRepos;
using DAL.Repos.StartBranchRepo;
using DAL.Repos.TripRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDestinationRepo DestinationRepo { get; }

        public IEndBranchRepo EndBranchRepo { get; }

        public IStartBranchRepo StartBranchRepo { get; }

        public ITripRepo TripRepo { get; }
        public IPublicActivityRepo PublicActivityRepo { get; }


        public AppDbContext AppDbContext { get; }

            
        public UnitOfWork(AppDbContext appDbContext,
            IDestinationRepo destinationRepo,
            IEndBranchRepo endBranchRepo,
            IStartBranchRepo startBranchRepo,
            ITripRepo tripRepo,
            IPublicActivityRepo publicActivityRepo
            )
        {
            AppDbContext = appDbContext;
            StartBranchRepo = startBranchRepo;
            EndBranchRepo = endBranchRepo;
            DestinationRepo = destinationRepo;
            TripRepo = tripRepo;
            PublicActivityRepo = publicActivityRepo;


        }
        public Response Response(bool success, object? data, object? messages)
        {
            return new Response
            {
                Success = success,
                Data = data,
                Messages = messages
            };
        }

        public async Task<int> SaveChangesAsync()
        {
            return await AppDbContext.SaveChangesAsync();
        }
    }
}
