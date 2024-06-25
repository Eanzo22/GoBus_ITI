using BL.Dtos.ApplicationUserRoleDto;
using BL.Managers.ApplicationUserRoleManagers;
using DAL.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoBusAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ApplicationUserRoleController : ControllerBase
{
    private readonly IApplicationUserRoleManager _applicationUserRoleManager;

    public ApplicationUserRoleController(IApplicationUserRoleManager applicationUserRoleManager)
    {
        _applicationUserRoleManager = applicationUserRoleManager;
    }


    #region AddUserToRoleAsync
    [HttpPost]
    [Authorize(Policy = "ForAdmin")]
    public async Task<IActionResult> AddUserToRoleAsync(ApplicationUserRoleAddDto applicationUserRoleAddDto)
    {
        Response response = await _applicationUserRoleManager.AddAsync(applicationUserRoleAddDto);

        if (response.Success)
        {
            return Ok(response);
        }

        return NotFound(response);
    }
    #endregion
}
