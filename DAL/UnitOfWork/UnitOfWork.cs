using DAL.Data.Context;
using DAL.Data.Models;
using DAL.Repos.ApplicationRoleRepo;
using DAL.Repos.ApplicationUserRepo;
using DAL.Repos.ApplicationUserRoleRepo;
using DAL.Repos.DestinationRepo;
using DAL.Repos.EndBranchRepo;
using DAL.Repos.PolicyRepo;
using DAL.Repos.PublicActivityRepos;
using DAL.Repos.ReservationRepo;
using DAL.Repos.StartBranchRepo;
using DAL.Repos.TripRepo;
using DAL.Repos;
using DAL.Repos.TermRepo;
using DAL.Repos.TicketRepo;
using DAL.Repos.BusClassRepo;
using DAL.Repos.BusRepo;
using DAL.Repos.ClassImageRepo;

namespace DAL.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    public IDestinationRepo DestinationRepo { get; }
    public IEndBranchRepo EndBranchRepo { get; }
    public IStartBranchRepo StartBranchRepo { get; }
    public ITripRepo TripRepo { get; }
    public IPublicActivityRepo PublicActivityRepo { get; }
    public IApplicationRoleRepo ApplicationRoleRepo { get; }
    public IApplicationUserRepo ApplicationUserRepo { get; }
    public IApplicationUserRoleRepo ApplicationUserRoleRepo { get; }
    public IPolicyRepo PolicyRepo { get; }
    public IReservationRepo ReservationRepo { get; }
    public IQuestionRepo QuestionRepo { get; }
    public ITermRepo TermRepo { get; }
    public ITicketRepo TicketRepo { get; }
    public IBusClassRepo BusClassRepo { get; }
    public IBusRepo BusRepo { get; }
    public IClassImageRepo ClassImageRepo { get; }
    public AppDbContext AppDbContext { get; }


    public UnitOfWork(AppDbContext appDbContext,
        IDestinationRepo destinationRepo,
        IEndBranchRepo endBranchRepo,
        IStartBranchRepo startBranchRepo,
        ITripRepo tripRepo,
        IPublicActivityRepo publicActivityRepo,
        IApplicationRoleRepo applicationRoleRepo,
        IApplicationUserRepo applicationUserRepo,
        IApplicationUserRoleRepo applicationUserRoleRepo,
        IPolicyRepo policyRepo,
        IReservationRepo reservationRepo,
        IQuestionRepo questionRepo,
        ITermRepo termRepo,
        ITicketRepo ticketRepo,
        IBusClassRepo busClassRepo,
        IBusRepo busRepo,
        IClassImageRepo classImageRepo)
    {
        AppDbContext = appDbContext;
        StartBranchRepo = startBranchRepo;
        EndBranchRepo = endBranchRepo;
        DestinationRepo = destinationRepo;
        TripRepo = tripRepo;
        PublicActivityRepo = publicActivityRepo;
        ApplicationRoleRepo = applicationRoleRepo;
        ApplicationUserRepo = applicationUserRepo;
        ApplicationUserRoleRepo = applicationUserRoleRepo;
        PolicyRepo = policyRepo;
        ReservationRepo = reservationRepo;
        QuestionRepo = questionRepo;
        TermRepo = termRepo;
        TicketRepo = ticketRepo;
        BusClassRepo = busClassRepo;
        BusRepo = busRepo;
        ClassImageRepo = classImageRepo;
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
