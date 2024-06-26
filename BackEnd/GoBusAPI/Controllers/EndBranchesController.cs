﻿using BL.Dtos.EndBranchDtos;
using BL.Managers.EndBranchManagers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Data.Models;


namespace GoBusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EndBranchesController : ControllerBase
    {
        private readonly IEndBranchManager _endBranchManager;

        public EndBranchesController(IEndBranchManager endBranchManager)
        {
            _endBranchManager = endBranchManager;
        }

        //admin 

        #region AddAsync
        [HttpPost]
        [Authorize(Policy = "ForAdmin")]
        public async Task<IActionResult> AddAsync(EndBranchAddDto endBranchAddDto)
        {
            if (ModelState.IsValid)
            {
                Response response = await _endBranchManager.AddAsync(endBranchAddDto);

                if (response.Success)

                    return Ok(response);
            }

            return BadRequest(endBranchAddDto);
        }
        #endregion


        #region UpdateAsync
        [HttpPut("{id:int}")]
        [Authorize(Policy = "ForAdmin")]
        public async Task<IActionResult> UpdateAsync(int id, EndBranchAddDto endBranchUpdateDto)
        {
            if (ModelState.IsValid)
            {
                Response response = await _endBranchManager.UpdateAsync(id, endBranchUpdateDto);

                if (response.Success)
                {
                    return Ok(response);
                }
                return BadRequest(response);

            }

            return BadRequest(endBranchUpdateDto);
        }
        #endregion


        #region DeleteAsync
        [HttpDelete("{id:int}")]
        [Authorize(Policy = "ForAdmin")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            Response response = await _endBranchManager.DeleteAsync(id);

            if (response.Success)
            {
                return Ok(response);
            }

            return NotFound(response);
        }
        #endregion

        // user 


        #region GetAllWithDestinationNameAsync
        [HttpGet]
        public async Task<IActionResult> GetAllWithDestinationNameAsync()
        {
            Response response = await _endBranchManager.GetAllWithDestinationNameAsync();

            if (response.Success)
            {
                return Ok(response);
            }

            return NotFound(response);

        }
        #endregion


        #region GetAllByDestinationIdAsync
        [HttpGet("destinationId/{id:int}")]
        public async Task<IActionResult> GetAllByDestinationIdAsync(int id)
        {
            Response response = await _endBranchManager.GetAllByDestinationIdAsync(id);

            if (response.Success)
            {
                return Ok(response);
            }

            return NotFound(response);

        }
        #endregion


        #region FilterEndBranchesByStartBranchDestinationIdAsync
        [HttpGet("filter/destinationId/{id:int}")]
        public async Task<IActionResult> FilterEndBranchesByStartBranchDestinationIdAsync(int id)
        {
            Response response = await _endBranchManager.FilterEndBranchesByStartBranchDestinationIdAsync(id);

            if (response.Success)
            {
                return Ok(response);
            }

            return NotFound(response);

        }
        #endregion


        #region GetByIdWithDestinationNameAsync
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdWithDestinationNameAsync(int id)
        {
            Response response = await _endBranchManager.GetByIdWithDestinationNameAsync(id);

            if (response.Success)
            {
                return Ok(response);
            }

            return NotFound(response);
        }
        #endregion


      
    }
}
