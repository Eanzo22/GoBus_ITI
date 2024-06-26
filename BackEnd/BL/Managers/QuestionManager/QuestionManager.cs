﻿using Azure;
using BL.Dtos.QuestionDtos;
using DAL.Data.Models;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Response = DAL.Data.Models.Response;

namespace BL.Managers.QuestionManager
{
    public class QuestionManager : IQuestionManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuestionManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #region AddAsync
        public async Task<Response> AddAysnc(QuestionAddDto questionAddDto)
        {
            Question question = new Question{
                Title = questionAddDto.Title,
                Answer = questionAddDto.Answer
            };

            await _unitOfWork.QuestionRepo.AddAsync(question);
            bool result = await _unitOfWork.SaveChangesAsync() > 0;
            if (result)
            {
                return _unitOfWork.Response(true, null, "Question has been added successfully");
            }
            return _unitOfWork.Response(false, null, "Failed to add Question");
        }
        #endregion

        #region DeleteAsync
        public async Task<Response> DeleteAsync(int id)
        {
            Question? question = await _unitOfWork.QuestionRepo.GetByIdAsync(id);
            if(question is not null)
            {
                _unitOfWork.QuestionRepo.Delete(question);
                bool result = await _unitOfWork.SaveChangesAsync() > 0;
                if (result)
                {
                    return _unitOfWork.Response(true, null, "Question has been deleted successfully");
                }
                return _unitOfWork.Response(false, null, "Failed to delete Question");
            }
            return _unitOfWork.Response(false, null, $"Question with id ({id}) is not found");

        }
        #endregion
        #region GetAllAsync
        public async Task<Response> GetAllAsync()
        {
            IEnumerable<Question>? questions = await _unitOfWork.QuestionRepo.GetAllAsync();
            if(questions is not null)
            {
                var data = questions.Select(x => new QuestionReadDto
                {
                    Id = x.Id,
                    Title = x.Title,
                    Answer = x.Answer
                });

                return _unitOfWork.Response(true, data, null);
            }

            return _unitOfWork.Response(false, null, "There is no Question");
        }
        #endregion

        #region GetByIdAsync
        public async Task<Response> GetByIdAsync(int id)
        {
            Question? question = await _unitOfWork.QuestionRepo.GetByIdAsync(id);
            if (question is not null)
            {
                var data = new QuestionReadDto
                {
                    Id = question.Id,
                    Title = question.Title,
                    Answer = question.Answer
                };
                return _unitOfWork.Response(true, data, null);
            }
            return _unitOfWork.Response(false, null, $"Question with Id ({id}) is not found");
        }
        #endregion

        #region UpdateAsync
        public async Task<Response> UpdateAsync(int id, QuestionUpdateDto questionUpdateDto)
        {
            Question? question = await _unitOfWork.QuestionRepo.GetByIdAsync(id);
            if (question is not null)
            {
                question.Title = questionUpdateDto.Title;
                question.Answer = questionUpdateDto.Answer;
            }
            bool result = await _unitOfWork.SaveChangesAsync() > 0;
            if (result)
            {
                return _unitOfWork.Response(true, null, "The Question has been updated successfully");
            }
            return _unitOfWork.Response(false, null, "Failed to update Question");
        }
        #endregion
    }
}
