using DAL.Repos.DestinationRepo;
using DAL.Repos.EndBranchRepo;
using DAL.Repos.PublicActivityRepos;
using DAL.Repos.StartBranchRepo;
using DAL.Repos.TripRepo;
using DAL.Repos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Managers.DestinationManagers;
using BL.Managers.EndBranchManagers;
using BL.Managers.TripManagers;
using BL.Managers.StartBranchManagers;
using BL.Managers.PublicActivityManagers;
using BL.Managers.QuestionManager;


namespace BL
{
    public static class RegisterBL
    {
        public static void RegisterBLMethod(this IServiceCollection service)
        {
            service.AddScoped<IDestinationManager, DestinationManager>();
            service.AddScoped<IEndBranchManager, EndBranchManager>();
            service.AddScoped<IStartBranchManager, StartBranchManager>();
            service.AddScoped<ITripManager, TripManager>();
            service.AddScoped<IPublicActivityManager, PublicActivityManager>();
            service.AddScoped<IQuestionManager, QuestionManager>();

        }
    }
}
