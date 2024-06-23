using BL.Dtos.QuestionDtos;
using BL.Managers.QuestionManager;
using DAL.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoBusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionManager _questionManager;
        
        public QuestionsController(IQuestionManager questionManager)
        {
            _questionManager = questionManager;
        }

        #region GetAllAsync
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            Response response = await _questionManager.GetAllAsync();
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
            Response response = await _questionManager.GetByIdAsync(id);
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
        public async Task<IActionResult> UpdateAsync(int id, QuestionUpdateDto questionUpdateDto)
        {
            if (ModelState.IsValid)
            {
                Response response = await _questionManager.UpdateAsync(id, questionUpdateDto);

                if (response.Success)
                {
                    return Ok(response);
                }
                return BadRequest(response);

            }

            return BadRequest(questionUpdateDto);
        }
        #endregion

        #region AddAsync
        [HttpPost]
        //Authorize for admin

        public async Task<IActionResult> AddAsync(QuestionAddDto questionAddDto)
        {
            if (ModelState.IsValid)
            {

                Response response = await _questionManager.AddAysnc(questionAddDto);

                if (response.Success)
                {
                    return Ok(response);
                }
                return BadRequest(response);
            }

            return BadRequest(questionAddDto);
        }
        #endregion

        #region DeleteAsync
        [HttpDelete("{id:int}")]
        //Authorize for admin
        public async Task<IActionResult> DeleteAsync(int id)
        {
            
            Response response = await _questionManager.DeleteAsync(id);

            if (response.Success)
            {
               return Ok(response);
            }

            return NotFound(response);
             
        }

        #endregion
    }
}
