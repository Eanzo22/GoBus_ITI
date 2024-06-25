using BL.Dtos.ReservationDtos;
using DAL.Data.Models;

namespace BL.Managers.ReservationManagers;

public interface IReservationManager
{
    Task<Response> GetAllWithTripDetailsAsync();
    Task<Response> GetAllByTripIdAsync(int id);
    Task<Response> GetAllWithTripDetailsByUserIdAsync(string id);
    Task<Response> FilterByDateAsync(DateOnly date);
    Task<Response> GetByIdWithTripDetailsAsync(int id);
    Task<Response> AddAsync(ReservationAddDto reservationAddDto);
    Task<Response> DeleteAsync(int id);
}
