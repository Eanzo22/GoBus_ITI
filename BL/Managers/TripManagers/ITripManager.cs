using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Data.Models;
using BL.Dtos.TripsDtos;


namespace BL.Managers.TripManagers
{
    public interface ITripManager
    {
        Task<Response> SearchAsync(TripSearchDto tripSearchDto);
        Task<Response> FilterByDateAsync(DateOnly date);
        Task<Response> GetAllWithDetailsAsync();
        Task<Response> GetByIdWithBusClassNameAsync(int id);
        Task<Response> AddAsync(TripAddDto tripAddDto);
        Task<Response> UpdateAsync(int id, TripAddDto tripUpdateDto);
        Task<Response> DeleteAsync(int id);
    }
}
