using DAL.Data.Models;
using DAL.Repos.GenericRepo;

namespace DAL.Repos.ReservationRepo;

public interface IReservationRepo : IGenericRepo<Reservation>
{
    Task<IEnumerable<Reservation>?> GetAllWithTripDetailsAsync();
    Task<IEnumerable<Reservation>?> GetAllByTripIdAsync(int id);
    Task<IEnumerable<Reservation>?> GetAllWithTripDetailsByUserIdAsync(string id);
    Task<Reservation?> GetByIdWithTripDetailsAsync(int id);
}
