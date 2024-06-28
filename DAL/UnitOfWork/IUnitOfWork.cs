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
using DAL.Repos;
using DAL.Repos.ReportRepo;
using DAL.Repos.ClassImageRepo;
using DAL.Repos.BusClassRepo;
using DAL.RepoS;


namespace DAL.UnitOfWork
{ 
    public interface IUnitOfWork
    {
   
        public IDestinationRepo DestinationRepo { get; }
        public IEndBranchRepo EndBranchRepo { get; }
    
        public IPublicActivityRepo PublicActivityRepo { get; }
        public IQuestionRepo QuestionRepo { get; }
        
        public IStartBranchRepo StartBranchRepo { get; }
       
        public ITripRepo TripRepo { get; }

        public IReportRepo ReportRepo { get; }

        public IClassImageRepo ClassImageRepo { get; }

        public IBusClassRepo BusClassRepo { get; }
        public IBusRepo BusRepo { get; }
        Task<int> SaveChangesAsync();
        Response Response(bool success, object? data, object? messages);


    }
}
