using BL.Dtos.DestinationDtos;
using BL.Dtos.EndBranchDtos;
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

        public async Task<Response> GetAllWithBranchesDetailsAsync()
        {
            IEnumerable<Destination>? destinations = await _unitOfWork.DestinationRepo.GetAllWithBranchesDetailsAsync();
            if (destinations is not null)
            {
                var data = destinations.Select(x => new DestinationWithBranchesDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Branches = x.EndBranchs.Select(y => new EndBranchReadDto
                    {
                        Id = y.Id,
                        Name = y.Name,
                        Address = y.Address,
                        Phone = y.Phone
                    }),
                });
                return _unitOfWork.Response(true, data, null);

            }

            return _unitOfWork.Response(false, null, "There is no Destinations");
        }

        public async Task<Response> GetByIdAsync(int id)
        {
            Destination? destinations = await _unitOfWork.DestinationRepo.GetByIdAsync(id);
            if (destinations is not null)
            {
                var data = new DestinationReadDto
                {
                    Id = destinations.Id,
                    Name = destinations.Name,
                    ImageURL = destinations.ImageURL,
                };
                return _unitOfWork.Response(true, data, null);
            }

            return _unitOfWork.Response(false, null, $"Destination with id ({id}) is not found");
        }

        public async Task<Response> UpdateAsync(int id, DestinationAddDto destinationUpdateDto)
        {
            Destination? destination = await _unitOfWork.DestinationRepo.GetByIdAsync(id);
            if (destination is not null)
            {
                destination.Name = destinationUpdateDto.Name;
                destination.ImageURL = destinationUpdateDto.ImageURL;
            }
            bool result = await _unitOfWork.SaveChangesAsync() > 0;
            if (result)
            {
                return _unitOfWork.Response(true, null, "The Destination has been updated successfully");
            }
            return _unitOfWork.Response(false, null, "Failed to update Destination");
        }
    }
}
