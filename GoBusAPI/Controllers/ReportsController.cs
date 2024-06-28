using BL.Dtos.QuestionDtos;
using BL.Dtos.ReportDto;
using BL.Managers.QuestionManager;
using BL.Managers.ReportManager;
using DAL.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoBusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IReportManager _reportManager;

        public ReportsController(IReportManager reportManager)
        {
            _reportManager = reportManager;
        }


        #region GetAllAsync
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            Response response = await _reportManager.GetAllAsync();
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
            Response response = await _reportManager.GetByIdAsync(id);
            if (response.Success)
            {
                return Ok(response);
            }
            return NotFound(response);
        }

        #endregion

        #region UpdateAsync
        [HttpPut("{id:int}")]
        //Authorize for admin
        public async Task<IActionResult> UpdateAsync(int id, ReportUpdateDto reportUpdateDto)
        {
            if (ModelState.IsValid)
            {
                Response response = await _reportManager.UpdateAsync(id, reportUpdateDto);

                if (response.Success)
                {
                    return Ok(response);
                }
                return BadRequest(response);

            }

            return BadRequest(reportUpdateDto);
        }
        #endregion

        #region AddAsync
        [HttpPost]
        //Authorize for admin

        public async Task<IActionResult> AddAsync(ReportAddDto reportAddDto)
        {
            if (ModelState.IsValid)
            {

                Response response = await _reportManager.AddAysnc(reportAddDto);

                if (response.Success)
                {
                    return Ok(response);
                }
                return BadRequest(response);
            }

            return BadRequest(reportAddDto);
        }
        #endregion

        #region DeleteAsync
        [HttpDelete("{id:int}")]
        //Authorize for admin
        public async Task<IActionResult> DeleteAsync(int id)
        {

            Response response = await _reportManager.DeleteAsync(id);

            if (response.Success)
            {
                return Ok(response);
            }

            return NotFound(response);

        }

        #endregion
    }
}
