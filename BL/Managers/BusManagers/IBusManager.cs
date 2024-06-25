using BL.Dtos.BusDtos;
using DAL.Data.Models;

namespace BL.Managers.BusManagers;

public interface IBusManager
{
    Task<Response> GetAllWithBusClassAsync();
    Task<Response> GetAllByBusClassIdAsync(int id);
    Task<Response> GetAllAvailableBusesAsync(DateTime departureDate, DateTime arrivalDate);
    Task<Response> GetByIdWithBusClassAsync(int id);
    Task<Response> AddAsync(BusAddDto busAddDto);
    Task<Response> UpdateAsync(int id, BusUpdateDto busUpdateDto);
    Task<Response> DeleteAsync(int id);
}
