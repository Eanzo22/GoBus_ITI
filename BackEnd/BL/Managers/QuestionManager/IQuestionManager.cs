using Azure;
using BL.Dtos.QuestionDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Response = DAL.Data.Models.Response;

namespace BL.Managers.QuestionManager
{
    public interface IQuestionManager
    {
        Task<Response> GetAllAsync();

        Task<Response> GetByIdAsync(int id);

        Task<Response> AddAysnc(QuestionAddDto questionAddDto);

        Task<Response> UpdateAsync(int id, QuestionUpdateDto questionUpdateDto);

        Task<Response> DeleteAsync(int id);
    }
}
