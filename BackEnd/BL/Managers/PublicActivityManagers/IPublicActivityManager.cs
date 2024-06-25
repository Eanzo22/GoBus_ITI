using BL.Dtos.PublicActivityDtos;
using DAL.Data.Models;


namespace BL.Managers.PublicActivityManagers;

public interface IPublicActivityManager
{
    Task<Response> GetAllWithDestinationNameAsync();
    Task<Response> GetAllByDestinationIdAsync(int id);
    Task<Response> GetByIdAsync(int id);
    Task<Response> AddAsync(PublicActivityAddDto publicActivityAddDto);
    Task<Response> UpdateAsync(int id, PublicActivityAddDto publicActivityUpdateDto);
    Task<Response> DeleteAsync(int id);
}
