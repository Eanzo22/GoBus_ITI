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


    Task<int> SaveChangesAsync();
    Response Response(bool success, object? data, object? messages);


}
