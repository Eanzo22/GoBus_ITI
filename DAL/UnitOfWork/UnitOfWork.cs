using DAL.Data.Context;
using DAL.Data.Models;
using DAL.Repos.DestinationRepo;
using DAL.Repos.EndBranchRepo;
using DAL.Repos.PublicActivityRepos;
using DAL.Repos.StartBranchRepo;
using DAL.Repos.TripRepo;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repos.ReportRepo;
using DAL.Repos.ClassImageRepo;
using DAL.Repos.BusClassRepo;
using DAL.RepoS;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        public IDestinationRepo DestinationRepo { get; }
        public IEndBranchRepo EndBranchRepo { get; }

        public IPublicActivityRepo PublicActivityRepo { get; }
        public IQuestionRepo QuestionRepo { get; }

        public IStartBranchRepo StartBranchRepo { get; }

        public ITripRepo TripRepo { get; }

        public IReportRepo ReportRepo {get; }

        public IBusClassRepo BusClassRepo { get; }

        public IClassImageRepo ClassImageRepo { get; }

        public IBusRepo BusRepo { get; }

        public AppDbContext AppDbContext { get; }

        public UnitOfWork(AppDbContext appDbContext,          
            IDestinationRepo destinationRepo,
            IEndBranchRepo endBranchRepo,          
            IPublicActivityRepo publicActivityRepo,
            IQuestionRepo questionRepo,      
            IStartBranchRepo startBranchRepo,     
            ITripRepo tripRepo,
            IReportRepo reportRepo,
            IClassImageRepo classImageRepo,
            IBusClassRepo busClassRepo,
            IBusRepo busRepo)
        {
            AppDbContext = appDbContext;          
            DestinationRepo = destinationRepo;
            EndBranchRepo = endBranchRepo;     
            PublicActivityRepo = publicActivityRepo;
            QuestionRepo = questionRepo; 
            StartBranchRepo = startBranchRepo;           
            TripRepo = tripRepo;
            ReportRepo = reportRepo;
            ClassImageRepo = classImageRepo;
            busRepo = busRepo;
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
