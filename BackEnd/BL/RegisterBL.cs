using Microsoft.Extensions.DependencyInjection;
using BL.Managers.DestinationManagers;
using BL.Managers.EndBranchManagers;
using BL.Managers.TripManagers;
using BL.Managers.StartBranchManagers;
using BL.Managers.PublicActivityManagers;
using BL.Managers.QuestionManager;
using BL.Managers.ApplicationRoleManagers;
using BL.Managers.ApplicationUserManagers;
using BL.Managers.ApplicationUserRoleManagers;
using BL.Managers.BusClassManagers;
using BL.Managers.BusManagers;
using BL.Managers.ClassImageManagers;
using BL.Managers.PaymentManagers;
using BL.Managers.PolicyManagers;
using BL.Managers.ReservationManagers;
using BL.Managers.TermManagers;
using BL.Managers.TicketManagers;
using BL.Managers.ReportManagers;


namespace BL;

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
        service.AddScoped<IApplicationUserManager, ApplicationUserManager>();
        service.AddScoped<IApplicationRoleManager, ApplicationRoleManager>();
        service.AddScoped<IApplicationUserRoleManager, ApplicationUserRoleManager>();
        service.AddScoped<IPolicyManager, PolicyManager>();
        service.AddScoped<IReservationManager, ReservationManager>();
        service.AddScoped<IPaymentManager, PaymentManager>();
        service.AddScoped<IBusClassManager, BusClassManager>();
        service.AddScoped<IBusManager, BusManager>();
        service.AddScoped<IClassImageManager, ClassImageManager>();
        service.AddScoped<ITermManager, TermManager>();
        service.AddScoped<ITicketManager, TicketManager>();
        service.AddScoped<IReportManager, ReportManager>();

    }
}
