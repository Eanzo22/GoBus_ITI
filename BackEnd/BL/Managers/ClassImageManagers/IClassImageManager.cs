using BL.Dtos.ClassImageDto;
using DAL.Data.Models;

namespace BL.Managers.ClassImageManagers;

public interface IClassImageManager
{
    Task<Response> GetAllAsync();
    Task<Response> GetAllByBusClassIdAsync(int id);
    Task<Response> GetByIdAsync(int id);
    Task<Response> AddAsync(ClassImageAddDto classImageAddDto);
    Task<Response> DeleteAsync(int id);
}
