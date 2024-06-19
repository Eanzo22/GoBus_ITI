using BL.Managers.DestinationManagers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Data.Models;


namespace GoBusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationsController : ControllerBase
    {

        private readonly IDestinationManager _destinationManager;
        public DestinationsController(IDestinationManager destinationManager)
        {
            _destinationManager = destinationManager;
        }


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
    }
}
