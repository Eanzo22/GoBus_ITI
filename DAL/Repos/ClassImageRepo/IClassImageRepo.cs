using DAL.Data.Models;
using DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.ClassImageRepo
{
    public interface IClassImageRepo : IGenericRepo<ClassImage>
    {
        Task<IEnumerable<ClassImage>?> GetAllByBusClassIdAsync(int id);

    }
}
