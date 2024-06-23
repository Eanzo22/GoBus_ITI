using BL.Dtos.TermDtos;
using BL.Managers.TermManagers;
using DAL.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoBusAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TermsController : ControllerBase
{
    private readonly ITermManager _termManager;

    public TermsController(ITermManager termManager)
    {
        _termManager = termManager;
    }


    #region GetAllAsync
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        Response response = await _termManager.GetAllAsync();

        if (response.Success)
        {
            return Ok(response);
        }

        return NotFound(response);

    }
    #endregion

    #region GetByIdAsync
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        Response response = await _termManager.GetByIdAsync(id);

        if (response.Success)
        {
            return Ok(response);
        }

        return NotFound(response);

    }
    #endregion

    #region AddAsync
    [HttpPost]
    public async Task<IActionResult> AddAsync(TermAddDto termAddDto)
    {
        if (ModelState.IsValid)
        {
            Response response = await _termManager.AddAsync(termAddDto);

            if (response.Success)

                return Ok(response);
        }

        return BadRequest(termAddDto);
    }
    #endregion

    #region UpdateAsync
    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateAsync(int id, TermUpdateDto termUpdateDto)
    {
        if (ModelState.IsValid)
        {
            Response response = await _termManager.UpdateAsync(id, termUpdateDto);

            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);

        }

        return BadRequest(termUpdateDto);
    }
    #endregion

    #region DeleteAsync
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        Response response = await _termManager.DeleteAsync(id);

        if (response.Success)
        {
            return Ok(response);
        }

        return NotFound(response);
    }
    #endregion
}
