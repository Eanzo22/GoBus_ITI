using DAL.Data.Models;
using DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.PublicActivityRepos
{
    public interface IPublicActivityRepo : IGenericRepo<PublicActivity>
    {
        Task<IEnumerable<PublicActivity>?> GetAllWithDestinationNameAsync();
        Task<IEnumerable<PublicActivity>?> GetAllByDestinationIdAsync(int id);
    }
}
