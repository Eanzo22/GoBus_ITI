using DAL.Data.Context;
using DAL.Repos.ApplicationRoleRepo;
using DAL.Repos.ApplicationUserRepo;
using DAL.Repos.ApplicationUserRoleRepo;
using DAL.Repos.PolicyRepo;
using DAL.Repos.ReservationRepo;

namespace DAL.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    public IApplicationRoleRepo ApplicationRoleRepo { get; }
    public IApplicationUserRepo ApplicationUserRepo { get; }
    public IApplicationUserRoleRepo ApplicationUserRoleRepo { get; }
    public IPolicyRepo PolicyRepo { get; }
    public IReservationRepo ReservationRepo { get; }

    public AppDbContext AppDbContext { get; }

    public UnitOfWork(AppDbContext appDbContext,
            IApplicationRoleRepo applicationRoleRepo,
            IApplicationUserRepo applicationUserRepo,
            IApplicationUserRoleRepo applicationUserRoleRepo,
            IPolicyRepo policyRepo,
            IReservationRepo reservationRepo)
    {
        AppDbContext = appDbContext;
        ApplicationRoleRepo = applicationRoleRepo;
        ApplicationUserRepo = applicationUserRepo;
        ApplicationUserRoleRepo = applicationUserRoleRepo;
        PolicyRepo = policyRepo;
        ReservationRepo = reservationRepo;
    }

    public async Task<int> SaveChangesAsync()
    {
        return await AppDbContext.SaveChangesAsync();
    }

    Data.Models.Response IUnitOfWork.Response(bool success, object? data, object? messages)
    {
        return new Data.Models.Response
        {
            Success = success,
            Data = data,
            Messages = messages
        };
    }
}
