using BL.Dtos.PublicActivityDtos;
using BL.Managers.PublicActivityManagers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Data.Models;


namespace GoBusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicActivitiesController : ControllerBase
    {
        private readonly IPublicActivityManager _publicActivityManager;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PublicActivitiesController(IPublicActivityManager publicActivityManager, IWebHostEnvironment webHostEnvironment)
        {
            _publicActivityManager = publicActivityManager;
            _webHostEnvironment = webHostEnvironment;
        }


        //admin 

        #region AddAsync
        [HttpPost]
        [Authorize(Policy = "ForAdmin")]
        public async Task<IActionResult> AddAsync
            (
            [FromForm] IFormFile file,
            [FromForm] string title,
            [FromForm] string description,
            [FromForm] int destinationID
            )
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Invalid file");
            }

            string folderPath;

            if (!Directory.Exists(Path.Combine(_webHostEnvironment!.WebRootPath!, "Images")))
            {
                folderPath = Path.Combine(_webHostEnvironment!.WebRootPath!, "Images");
            }
            else
            {
                Directory.CreateDirectory(Path.Combine(_webHostEnvironment!.WebRootPath!, "Images"));
                folderPath = Path.Combine(_webHostEnvironment!.WebRootPath!, "Images");
            }


            string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            string filePath = Path.Combine(folderPath, uniqueFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            var imageUrl = "https://site6032.siteasp.net/wwwroot/wwwroot/Images/" + uniqueFileName;

            var publicActivityAddDto = new PublicActivityAddDto
            {
                Title = title,
                Description = description,
                DestinationID = destinationID,
                ImageURL = imageUrl
            };


            Response response = await _publicActivityManager.AddAsync(publicActivityAddDto);

            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);

        }
        #endregion


        #region UpdateAsync
        [HttpPut("{id:int}")]
        [Authorize(Policy = "ForAdmin")]
        public async Task<IActionResult> UpdateAsync
            (
            [FromRoute] int id,
            [FromForm] IFormFile file,
            [FromForm] string title,
            [FromForm] string description,
            [FromForm] int destinationID
            )
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Invalid file");
            }

            string folderPath;

            if (!Directory.Exists(Path.Combine(_webHostEnvironment!.WebRootPath!, "Images")))
            {
                folderPath = Path.Combine(_webHostEnvironment!.WebRootPath!, "Images");
            }
            else
            {
                Directory.CreateDirectory(Path.Combine(_webHostEnvironment!.WebRootPath!, "Images"));
                folderPath = Path.Combine(_webHostEnvironment!.WebRootPath!, "Images");
            }


            string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            string filePath = Path.Combine(folderPath, uniqueFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var imageUrl = "https://site6032.siteasp.net/wwwroot/wwwroot/Images/" + uniqueFileName;

            var publicActivityUpdateDto = new PublicActivityAddDto
            {
                Title = title,
                Description = description,
                DestinationID = destinationID,
                ImageURL = imageUrl,
            };


            Response response = await _publicActivityManager.UpdateAsync(id, publicActivityUpdateDto);

            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);

        }
        #endregion


        #region DeleteAsync
        [HttpDelete("{id:int}")]
        //[Authorize(Policy = "ForAdmin")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            Response response = await _publicActivityManager.DeleteAsync(id);

            if (response.Success)
            {
                return Ok(response);
            }

            return NotFound(response);
        }
        #endregion

        //user 


        #region GetAllAsync
        [HttpGet]
        public async Task<IActionResult> GetAllWithDestinationNameAsync()
        {
            Response response = await _publicActivityManager.GetAllWithDestinationNameAsync();

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
            Response response = await _publicActivityManager.GetAllByDestinationIdAsync(id);

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
            Response response = await _publicActivityManager.GetByIdAsync(id);

            if (response.Success)
            {
                return Ok(response);
            }

            return NotFound(response);

        }
        #endregion


    }
}
