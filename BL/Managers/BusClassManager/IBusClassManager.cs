using BL.Dtos.BusClassDtos;
using DAL.Data.Models;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Managers.BusClassManager
{
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
}
