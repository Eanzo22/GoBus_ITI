using DAL.Data.Models;
using DAL.Repos.GenericRepo;

namespace DAL.Repos.ClassImageRepo;

public interface IClassImageRepo : IGenericRepo<ClassImage>
{
    Task<IEnumerable<ClassImage>?> GetAllByBusClassIdAsync(int id);
}
