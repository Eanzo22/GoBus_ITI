using BL.Dtos.QuestionDtos;
using BL.Dtos.ReportDto;
using DAL.Data.Models;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Managers.ReportManager
{
    public class ReportManager : IReportManager
    {
        private readonly IUnitOfWork _unitOfWork;


        public ReportManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
           
        }
        #region AddAsync
        public async Task<Response> AddAysnc(ReportAddDto reportAddDto)
        {
            Report report = new Report
            {
                FullName= reportAddDto.FullName,
                Email = reportAddDto.Email,
                PhoneNumber = reportAddDto.PhoneNumber,
                ReservationNumber = reportAddDto.ReservationNumber,
                MessageTitle = reportAddDto.MessageTitle,
                MessageContent = reportAddDto.MessageContent,
            };

            await _unitOfWork.ReportRepo.AddAsync(report);
            bool result = await _unitOfWork.SaveChangesAsync() > 0;
            if (result)
            {
                return _unitOfWork.Response(true, null, "Report has been added successfully");
            }
            return _unitOfWork.Response(false, null, "Failed to add Report");
        }
        #endregion


        #region DeleteAsync
        public async Task<Response> DeleteAsync(int id)
        {
            Report? report= await _unitOfWork.ReportRepo.GetByIdAsync(id);
            if (report is not null)
            {
                _unitOfWork.ReportRepo.Delete(report);
                bool result = await _unitOfWork.SaveChangesAsync() > 0;
                if (result)
                {
                    return _unitOfWork.Response(true, null, "Report has been deleted successfully");
                }
                return _unitOfWork.Response(false, null, "Failed to delete Report");
            }
            return _unitOfWork.Response(false, null, $"Report with id ({id}) is not found");

        }
        #endregion

        #region GetAllAsync
        public async Task<Response> GetAllAsync()
        {

            IEnumerable<Report>? reports = await _unitOfWork.ReportRepo.GetAllAsync();
            if (reports is not null)
            {
                var data = reports.Select(x => new ReportReadDto
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    Email = x.Email,
                    PhoneNumber = x.PhoneNumber,
                    ReservationNumber = x.ReservationNumber,
                    MessageTitle = x.MessageTitle,
                    MessageContent = x.MessageContent
                                
                });

                return _unitOfWork.Response(true, data, null);
            }

            return _unitOfWork.Response(false, null, "There is no Reports");
        }

        #endregion

        #region GetByIdAsync
        public async Task<Response> GetByIdAsync(int id)
        {
            Report? report = await _unitOfWork.ReportRepo.GetByIdAsync(id);
            if (report is not null)
            {
                var data = new ReportReadDto
                {
                    Id = report.Id,
                    FullName = report.FullName,
                    Email = report.Email,
                    PhoneNumber = report.PhoneNumber,
                    ReservationNumber = report.ReservationNumber,
                    MessageTitle = report.MessageTitle,
                    MessageContent = report.MessageContent

                };
                return _unitOfWork.Response(true, data, null);
            }
            return _unitOfWork.Response(false, null, $"Report with Id ({id}) is not found");
        }
        #endregion

        #region UpdateAsync
        public async Task<Response> UpdateAsync(int id, ReportUpdateDto reportUpdateDto)
        {
            Report? report = await _unitOfWork.ReportRepo.GetByIdAsync(id);
            if (report is not null)
            {
                report.FullName  = reportUpdateDto.FullName;
                report.Email = reportUpdateDto.Email;
                report.PhoneNumber = reportUpdateDto.PhoneNumber;
                report.ReservationNumber = reportUpdateDto.ReservationNumber;
                report.MessageTitle = reportUpdateDto.MessageTitle;
                report.MessageContent = reportUpdateDto.MessageContent;
             }
            bool result = await _unitOfWork.SaveChangesAsync() > 0;
            if (result)
            {
                return _unitOfWork.Response(true, null, "The Report has been updated successfully");
            }
            return _unitOfWork.Response(false, null, "Failed to update Report");
        }

        #endregion
    }
}
