using DAL.Data.Models;
using DAL.Repos.Generic_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public interface IQuestionRepo : IGenericRepo<Question>
    {
    }
}
