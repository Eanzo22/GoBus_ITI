﻿using BL.Dtos.ClassImageDtos;
using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Managers.ClassImageManger
{
    public interface IClassImageManager  
    {
        Task<Response> GetAllAsync();
        Task<Response> GetAllByBusClassIdAsync(int id);
        Task<Response> GetByIdAsync(int id);
        Task<Response> AddAsync(ClassImageAddDto classImageAddDto);
        Task<Response> DeleteAsync(int id);
    }
}
