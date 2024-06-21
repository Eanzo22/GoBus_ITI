using DAL.Data.Context;
using DAL.Data.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IQuestionRepo QuestionRepo { get; }
        private readonly AppDbContext AppDbContext;

        public UnitOfWork(AppDbContext appContext, IQuestionRepo questionRepo)
        {
            AppDbContext = appContext;
            QuestionRepo = questionRepo;
        }
      

        public Response Response(bool success, object? data, object? messages)
        {
            return new Response
            {
                Success = success,
                Data = data,
                Messages = messages
            };
        }

        public async Task<int> SaveChangesAsync()
        {
            return await AppDbContext.SaveChangesAsync();
        }
    }
}
