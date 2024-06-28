using BL.Dtos.BusClassDtos;
using BL.Dtos.BusDtos;
using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Managers.BusManager
{
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
}
