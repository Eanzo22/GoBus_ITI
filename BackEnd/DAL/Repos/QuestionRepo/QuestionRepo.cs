using DAL.Data.Context;
using DAL.Data.Models;
using DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class QuestionRepo : GenericRepo<Question>, IQuestionRepo
    {
        private readonly AppDbContext _appDbContext;
        public QuestionRepo(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
