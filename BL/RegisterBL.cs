using Microsoft.Extensions.DependencyInjection;
using BL.Managers.DestinationManagers;
using BL.Managers.EndBranchManagers;
using BL.Managers.TripManagers;
using BL.Managers.StartBranchManagers;
using BL.Managers.PublicActivityManagers;
using BL.Managers.QuestionManager;
using BL.Managers.ReportManager;
using BL.Managers.ClassImageManger;
using BL.Managers.BusManager;


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
            service.AddScoped<IReportManager, ReportManager>();
            service.AddScoped<IClassImageManager, ClassImageManager>();
            service.AddScoped<IBusManager, BusManager>();

        }
    }
}
