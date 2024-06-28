using DAL.Repos.EndBranchRepo;
using DAL.Repos.StartBranchRepo;
using DAL.Repos.TripRepo;
using DAL.Repos.DestinationRepo;
using DAL.Data.Models;
using DAL.Repos.PublicActivityRepos;
using DAL.Repos;
using DAL.Repos.ApplicationRoleRepo;
using DAL.Repos.ApplicationUserRepo;
using DAL.Repos.ApplicationUserRoleRepo;
using DAL.Repos.PolicyRepo;
using DAL.Repos.ReservationRepo;
using DAL.Repos.TermRepo;
using DAL.Repos.TicketRepo;
using DAL.Repos.BusClassRepo;
using DAL.Repos.BusRepo;
using DAL.Repos.ClassImageRepo;
using DAL.Repos.ReportRepo;

namespace DAL.UnitOfWork;

public interface IUnitOfWork
{
    public IApplicationRoleRepo ApplicationRoleRepo { get; }
    public IApplicationUserRepo ApplicationUserRepo { get; }
    public IApplicationUserRoleRepo ApplicationUserRoleRepo { get; }
    public IPolicyRepo PolicyRepo { get; }
    public IReservationRepo ReservationRepo { get; }
    public IDestinationRepo DestinationRepo { get; }
    public IEndBranchRepo EndBranchRepo { get; }
    public IStartBranchRepo StartBranchRepo { get; }
    public ITripRepo TripRepo { get; }
    public IPublicActivityRepo PublicActivityRepo { get; }
    public IQuestionRepo QuestionRepo { get; }
    public ITermRepo TermRepo { get; }
    public ITicketRepo TicketRepo { get; }
    public IBusClassRepo BusClassRepo { get; }
    public IBusRepo BusRepo { get; }
    public IClassImageRepo ClassImageRepo { get; }

    public IReportRepo ReportRepo { get; }
    Task<int> SaveChangesAsync();
    Response Response(bool success, object? data, object? messages);


}
