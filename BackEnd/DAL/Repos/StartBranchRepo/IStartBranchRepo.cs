using DAL.Data.Models;
using DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.StartBranchRepo
{
    public interface IStartBranchRepo: IGenericRepo<StartBranch>
    {
        Task<IEnumerable<StartBranch>?> GetAllByDestinationIdAsync(int id);
        Task<IEnumerable<StartBranch>?> GetAllWithDestinationNameAsync();
        Task<StartBranch?> GetByIdWithDestinationNameAsync(int id);
        Task<IEnumerable<StartBranch>?> FilterStartBranchesByEndBranchDestinationIdAsync(int id);
    }
}
