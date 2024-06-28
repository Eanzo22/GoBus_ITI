using BL.Dtos.ClassImageDtos;
using DAL.Data.Models;
using DAL.Repos.ClassImageRepo;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Managers.ClassImageManger
{
    public class ClassImageManager : IClassImageManager
    {
        private readonly IUnitOfWork _unitOfWork;
        public ClassImageManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Response> AddAsync(ClassImageAddDto classImageAddDto)
        {
            ClassImage classImage = new ClassImage
            {
                ImageURL = classImageAddDto.ImageURL,
                BusClassId = classImageAddDto.BusClassId,

            };
            await _unitOfWork.ClassImageRepo.AddAsync(classImage);
            bool result = await _unitOfWork.SaveChangesAsync() > 0;
            if (result)
            {
                return _unitOfWork.Response(true, null, "ClassImage has been added successfully");
            }

            return _unitOfWork.Response(false, null, "failed to add ClassImage");

        }

        public async Task<Response> DeleteAsync(int id)
        {
            ClassImage? classImage = await _unitOfWork.ClassImageRepo.GetByIdAsync(id);
            if (classImage is not null)
            {
                _unitOfWork.ClassImageRepo.Delete(classImage);
                bool result = await _unitOfWork.SaveChangesAsync() > 0;
                if (result)
                {
                    return _unitOfWork.Response(true, null, "The classImage has been deleted successfully");
                }
                return _unitOfWork.Response(false, null, "Failed to delete classImage");
            }
            return _unitOfWork.Response(false, null, $"classImage is not found");


        }

        public async Task<Response> GetAllAsync()
        {
            IEnumerable<ClassImage>? classImages = await _unitOfWork.ClassImageRepo.GetAllAsync();
            if (classImages is not null)
            {
                var data = classImages.Select(x => new ClassImageReadDto
                {
                    Id = x.Id,
                    ImageURL = x.ImageURL,
                    BusClassId = x.BusClassId
                });
                return _unitOfWork.Response(true, data, null);
            }

            return _unitOfWork.Response(false, null, "There is no ClassImages");
        }


        public async Task<Response> GetByIdAsync(int id)
        {
            ClassImage? classImage = await _unitOfWork.ClassImageRepo.GetByIdAsync(id);
            if (classImage is not null)
            {
                var data = new ClassImageReadDto
                {
                    Id = classImage.Id,
                    ImageURL = classImage.ImageURL,
                    BusClassId = classImage.BusClassId
                };
                return _unitOfWork.Response(true, data, null);
            }

            return _unitOfWork.Response(false, null, $"ClassImages is not found");
        }


        public async Task<Response> GetAllByBusClassIdAsync(int id)
        {
            IEnumerable<ClassImage>? classImages = await _unitOfWork.ClassImageRepo.GetAllByBusClassIdAsync(id);
            if (classImages is not null)
            {
                var data = classImages.Select(x => new ClassImageReadDto
                {
                    Id = x.Id,
                    ImageURL = x.ImageURL,
                    BusClassId = x.BusClassId
                });
                return _unitOfWork.Response(true, data, null);
            }

            return _unitOfWork.Response(false, null, "There is no ClassImages");
        }
    }

}
     
   
