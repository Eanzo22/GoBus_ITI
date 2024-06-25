using DAL.Repos;
using DAL.Repos.DestinationRepo;
using DAL.Repos.EndBranchRepo;
using DAL.Repos.PublicActivityRepos;
using DAL.Repos.StartBranchRepo;
using DAL.Repos.TripRepo;
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
 
        }
    }
}
