using DAL.Repos;
using DAL.Repos.ApplicationRoleRepo;
using DAL.Repos.ApplicationUserRepo;
using DAL.Repos.ApplicationUserRoleRepo;
using DAL.Repos.BusClassRepo;
using DAL.Repos.BusRepo;
using DAL.Repos.ClassImageRepo;
using DAL.Repos.DestinationRepo;
using DAL.Repos.EndBranchRepo;
using DAL.Repos.PolicyRepo;
using DAL.Repos.PublicActivityRepos;
using DAL.Repos.ReservationRepo;
using DAL.Repos.StartBranchRepo;
using DAL.Repos.TermRepo;
using DAL.Repos.TicketRepo;
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
            service.AddScoped<IApplicationRoleRepo, ApplicationRoleRepo>();
            service.AddScoped<IApplicationUserRepo, ApplicationUserRepo>();
            service.AddScoped<IApplicationUserRoleRepo, ApplicationUserRoleRepo>();
            service.AddScoped<IPolicyRepo, PolicyRepo>();
            service.AddScoped<IReservationRepo, ReservationRepo>();
            service.AddScoped<IBusClassRepo, BusClassRepo>();
            service.AddScoped<IBusRepo, BusRepo>();
            service.AddScoped<IClassImageRepo, ClassImageRepo>();
            service.AddScoped<ITermRepo, TermRepo>();
            service.AddScoped<ITicketRepo, TicketRepo>();

        }
    }
}
