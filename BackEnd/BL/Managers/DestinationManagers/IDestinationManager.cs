using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Dtos.DestinationDtos;
using DAL.Data.Models;


namespace BL.Managers.DestinationManagers
{
    public interface IDestinationManager
    {
        Task<Response> GetAllAsync();
        Task<Response> GetAllWithBranchesDetailsAsync();
        Task<Response> GetByIdAsync(int id);
        Task<Response> AddAsync(DestinationAddDto destinationAddDto);
        Task<Response> UpdateAsync(int id, DestinationAddDto destinationUpdateDto);
        Task<Response> DeleteAsync(int id);
    }
}
