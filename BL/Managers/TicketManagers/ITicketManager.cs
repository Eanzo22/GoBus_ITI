using BL.Dtos.TicketDtos;
using DAL.Data.Models;

namespace BL.Managers.TicketManagers;

public interface ITicketManager
{
    Task<Response> GetAllWithReservationNumberAsync();
    Task<Response> GetAllByReservationIdAsync(int id);
    Task<Response> GetAllByTripIdAsync(int id);
    Task<Response> GetByIdWithReservationNumberAsync(int id);
    Task<Response> AddAsync(TicketAddDto ticketAddDto);
    Task<Response> UpdateAsync(int id, TicketUpdateDto ticketUpdateDto);
    Task<Response> DeleteAsync(int id);
}
