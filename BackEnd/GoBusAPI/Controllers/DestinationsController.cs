using BL.Managers.DestinationManagers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Data.Models;
using BL.Dtos.DestinationDtos;
using Microsoft.AspNetCore.Authorization;


namespace GoBusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationsController : ControllerBase
    {

        private readonly IDestinationManager _destinationManager;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DestinationsController(IDestinationManager destinationManager, IWebHostEnvironment webHostEnvironment)
        {
            _destinationManager = destinationManager;
            _webHostEnvironment = webHostEnvironment ?? throw new ArgumentNullException(nameof(webHostEnvironment));
        }

        // user 

        #region GetAllDestination 
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            Response response = await _destinationManager.GetAllAsync();

            if (response.Success)
            {
                return Ok(response);
            }

            return NotFound(response);

        }
        #endregion

        #region GetAllWithBranchesDetailsAsync
        [HttpGet("branches")]
        public async Task<IActionResult> GetAllWithBranchesDetailsAsync()
        {
            Response response = await _destinationManager.GetAllWithBranchesDetailsAsync();

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
            Response response = await _destinationManager.GetByIdAsync(id);

            if (response.Success)
            {
                return Ok(response);
            }

            return NotFound(response);
        }
        #endregion

        // admin 

        #region AddAsync
        [HttpPost]
        [Authorize(Policy = "ForAdmin")]
        public async Task<IActionResult> AddAsync([FromForm] IFormFile file, [FromForm] string name)
        {

            // check for the image file 
            if (file == null || file.Length == 0)
            {
                return BadRequest("Invalid file");
            }

            string folderPath = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
            // creat the upload directory if not exists 

            
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            // uploade the image 

            string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            string filePath = Path.Combine(folderPath, uniqueFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            var imageUrl = "https://localhost:7066/Images/" + uniqueFileName;


            // creat the destination object 
            var destinationAddDto = new DestinationAddDto
            {
                Name = name,
                ImageURL = imageUrl
            };

            // save the destination in the db
            Response response = await _destinationManager.AddAsync(destinationAddDto);

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
        public async Task<IActionResult> UpdateAsync([FromRoute] int id, [FromForm] string name, [FromForm] string imageURL, [FromForm] IFormFile? file)
        {
           
            string newImageUrl;
            if (file != null && file.Length > 0)
            {
                string folderPath = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
                // creat the upload directory if not exists 


                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filePath = Path.Combine(folderPath, uniqueFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                newImageUrl = "https://localhost:7066/Images/" + uniqueFileName;
            }
            else
            {
                newImageUrl = imageURL; // Use the existing image URL if no new file is uploaded
            }

            var destinationUpdateDto = new DestinationAddDto
            {
                Name = name,
                ImageURL = newImageUrl
            };

            Response response = await _destinationManager.UpdateAsync(id, destinationUpdateDto);

            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }
        #endregion

        #region DeleteAsync
        [HttpDelete("{id:int}")]
        [Authorize(Policy = "ForAdmin")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            Response response = await _destinationManager.DeleteAsync(id);

            if (response.Success)
            {
                return Ok(response);
            }

            return NotFound(response);
        }
        #endregion

    }
}
