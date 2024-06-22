namespace DAL.Repos.GenericRepo;

public interface IGenericRepo<Entity> where Entity : class
{
    Task<IEnumerable<Entity>?> GetAllAsync();
    Task<Entity?> GetByIdAsync(int id);
    Task AddAsync(Entity entity);
    void Delete(Entity entity);
}
