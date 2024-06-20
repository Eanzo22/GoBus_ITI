using DAL.Repos.DestinationRepo;
using DAL.Repos.EndBranchRepo;
using DAL.Repos.StartBranchRepo;
using DAL.Repos.TripRepo;
using DAL.UnitOfWorks;

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            service.AddScoped<IUnitOfWork , UnitOfWork>();
        }
    }
}
