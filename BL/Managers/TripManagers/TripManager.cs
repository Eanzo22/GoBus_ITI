using BL.Dtos.TripsDtos;
using DAL.Data.Models;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Managers.TripManagers
{
    public class TripManager : ITripManager     
    {
        private readonly IUnitOfWork _unitOfWork;

        public TripManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // admin 


        public Task<Response> AddAsync(TripAddDto tripAddDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateAsync(int id, TripAddDto tripUpdateDto)
        {
            throw new NotImplementedException();
        }

        // user 


        public Task<Response> FilterByDateAsync(DateOnly date)
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetAllWithDetailsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetByIdWithBusClassNameAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> SearchAsync(TripSearchDto tripSearchDto)
        {
            throw new NotImplementedException();
        }

       
    }
}
