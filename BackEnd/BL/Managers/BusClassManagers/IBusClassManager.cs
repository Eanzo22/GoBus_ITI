using BL.Dtos.BusClassDtos;
using DAL.Data.Models;

namespace BL.Managers.BusClassManagers;

public interface IBusClassManager
{
    Task<Response> GetAllAsync();
    Task<Response> GetAllWithDetailsAsync();
    Task<Response> GetByIdAsync(int id);
    Task<Response> GetByIdWithDetailsAsync(int id);
    Task<Response> AddAsync(BusClassAddDto busClassAddDto);
    Task<Response> UpdateAsync(int id, BusClassUpdateDto busClassUpdateDto);
    Task<Response> DeleteAsync(int id);
}
