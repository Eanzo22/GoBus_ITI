using DAL.Data.Models;
using DAL.Repos.GenericRepo;

namespace DAL.Repos.TicketRepo;

public interface ITicketRepo : IGenericRepo<Ticket>
{
    Task<IEnumerable<Ticket>?> GetAllWithReservationNumberAsync();
    Task<IEnumerable<Ticket>?> GetAllByReservationIdAsync(int id);
    Task<IEnumerable<Ticket>?> GetAllByTripIdAsync(int id);
    Task<Ticket?> GetByIdWithReservationNumberAsync(int id);
}
