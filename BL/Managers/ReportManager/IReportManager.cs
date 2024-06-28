using BL.Dtos.QuestionDtos;
using BL.Dtos.ReportDto;
using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Managers.ReportManager
{
    public interface IReportManager
    {
        Task<Response> GetAllAsync();

        Task<Response> GetByIdAsync(int id);

        Task<Response> AddAysnc(ReportAddDto reportAddDto);

        Task<Response> UpdateAsync(int id, ReportUpdateDto reportUpdateDto);

        Task<Response> DeleteAsync(int id);
    }
}
