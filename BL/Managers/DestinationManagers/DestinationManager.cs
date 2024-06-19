using BL.Dtos.DestinationDtos;
using DAL.Data.Models;
using DAL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Managers.DestinationManagers
{
    public class DestinationManager : IDestinationManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public DestinationManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<Response> AddAsync(DestinationAddDto destinationAddDto)
        {
            Destination destination = new Destination
            {
                Name = destinationAddDto.Name,
                ImageURL = destinationAddDto.ImageURL,
            };
            await _unitOfWork.DestinationRepo.AddAsync(destination);
            bool result = await _unitOfWork.SaveChangesAsync() > 0;
            if (result)
            {
                return _unitOfWork.Response(true, null, "The Destination has been added successfully");
            }
            return _unitOfWork.Response(false, null, "Failed to add Destination");
        }

        public async Task<Response> DeleteAsync(int id)
        {
            Destination? destination = await _unitOfWork.DestinationRepo.GetByIdAsync(id);
            if (destination is not null)
            {
                _unitOfWork.DestinationRepo.Delete(destination);
                bool result = await _unitOfWork.SaveChangesAsync() > 0;
                if (result)
                {
                    return _unitOfWork.Response(true, null, "The Destination has been deleted successfully");
                }
                return _unitOfWork.Response(false, null, "Failed to delete Destination");
            }
            return _unitOfWork.Response(false, null, $"Destination with id ({id}) is not found");
        }

        public async Task<Response> GetAllAsync()
        {
            IEnumerable<Destination>? destinations = await _unitOfWork.DestinationRepo.GetAllAsync();
            if (destinations is not null)
            {
                var data = destinations.Select(x => new DestinationReadDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    ImageURL = x.ImageURL,
                });
                return _unitOfWork.Response(true, data, null);

            }

            return _unitOfWork.Response(false, null, "There is no Destinations");
        }

        public Task<Response> GetAllWithBranchesDetailsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateAsync(int id, DestinationAddDto destinationUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
