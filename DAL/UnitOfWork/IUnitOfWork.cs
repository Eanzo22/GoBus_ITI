using DAL.Data.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IQuestionRepo QuestionRepo { get; }

        Task<int> SaveChangesAsync();
        Response Response(bool success, object? data, object? messages);
    }
}
