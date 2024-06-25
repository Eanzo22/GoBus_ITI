using BL.Dtos.StartBranchDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Data.Models;

namespace BL.Managers.StartBranchManagers
{
    public interface IStartBranchManager
    {
        Task<Response> GetAllWithDestinationNameAsync();
        Task<Response> GetAllByDestinationIdAsync(int id);
        Task<Response> FilterStartBranchesByEndBranchDestinationIdAsync(int id);
        Task<Response> GetByIdWithDestinationNameAsync(int id);
        Task<Response> AddAsync(StartBranchAddDto startBranchAddDto);
        Task<Response> UpdateAsync(int id, StartBranchAddDto startBranchUpdateDto);
        Task<Response> DeleteAsync(int id);
    }
}
