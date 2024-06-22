using BL.Dtos.EndBranchDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Data.Models;


namespace BL.Managers.EndBranchManagers
{
    public interface IEndBranchManager
    {
        Task<Response> GetAllWithDestinationNameAsync();
        Task<Response> GetAllByDestinationIdAsync(int id);
        Task<Response> FilterEndBranchesByStartBranchDestinationIdAsync(int id);
        Task<Response> GetByIdWithDestinationNameAsync(int id);
        Task<Response> AddAsync(EndBranchAddDto endBranchAddDto);
        Task<Response> UpdateAsync(int id, EndBranchAddDto endBranchUpdateDto);
        Task<Response> DeleteAsync(int id);
    }
}
