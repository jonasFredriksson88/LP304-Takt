using Microsoft.AspNetCore.Mvc;
using rest_api.DTO;
using rest_api.Interfaces.Services;
using rest_api.Mapper;

namespace rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        private readonly IStationService _stationService;

        public StationController(IStationService stationService)
        {
            _stationService = stationService;
        }

        [HttpPost]
        public async Task<IActionResult> AddStation([FromBody] StationCreateDto station, [FromQuery] int areaId)
        {
            await _stationService.Add(station.AsEntity(), areaId);

            return Ok();
        }
    }
}
