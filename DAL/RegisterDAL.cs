using DAL.Repos;
using DAL.Repos.BusClassRepo;
using DAL.Repos.BusRepo;
using DAL.Repos.ClassImageRepo;
using DAL.Repos.DestinationRepo;
using DAL.Repos.EndBranchRepo;
using DAL.Repos.PublicActivityRepos;
using DAL.Repos.ReportRepo;
using DAL.Repos.StartBranchRepo;
using DAL.Repos.TripRepo;
using DAL.RepoS;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public static class RegisterDAL
    {
        public static void RegisterDALMethod(this IServiceCollection service)
        {
           
            service.AddScoped<IDestinationRepo, DestinationRepo>();
            service.AddScoped<IEndBranchRepo, EndBranchRepo>();
            service.AddScoped<IStartBranchRepo, StartBranchRepo>();
            service.AddScoped<ITripRepo, TripRepo>();
            service.AddScoped<IPublicActivityRepo, PublicActivityRepo>();
            service.AddScoped<IQuestionRepo, QuestionRepo>();
            service.AddScoped<IReportRepo, ReportRepo>();
            service.AddScoped<IClassImageRepo, ClassImageRepo>();
            service.AddScoped<IBusClassRepo, BusClassRepo>();
            service.AddScoped<IBusRepo, BusRepo>();

        }
    }
}
