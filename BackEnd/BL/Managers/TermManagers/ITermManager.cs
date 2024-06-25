using BL.Dtos.TermDtos;
using DAL.Data.Models;

namespace BL.Managers.TermManagers;

public interface ITermManager
{
    Task<Response> GetAllAsync();
    Task<Response> GetByIdAsync(int id);
    Task<Response> AddAsync(TermAddDto termAddDto);
    Task<Response> UpdateAsync(int id, TermUpdateDto termUpdateDto);
    Task<Response> DeleteAsync(int id);
}
