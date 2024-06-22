using BL.Dtos.PolicyDtos;

namespace BL.Managers.PolicyManagers;

public interface IPolicyManager
{
    Task<IEnumerable<PolicyReadDto>?> GetAllAsync();
    Task<PolicyReadDto?> GetByIdAsync(int id);
    Task<bool> AddAsync(PolicyAddDto policyAddDto);
    Task<bool> UpdateAsync(int id, PolicyUpdateDto policyUpdateDto);
    Task<bool> DeleteAsync(int id);

}
