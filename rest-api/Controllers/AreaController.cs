using Microsoft.AspNetCore.Mvc;
using rest_api.DTO;
using rest_api.Interfaces.Services;
using rest_api.Mapper;

namespace rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        private readonly IAreaService _areaService;

        public AreaController(IAreaService areaService)
        {
            _areaService = areaService;
        }

        [HttpPost]
        public async Task<IActionResult> AddArea([FromBody] AreaCreateDto area, [FromQuery] int companyId)
        {
            await _areaService.Add(area.AsEntity(), companyId);

            return Ok();
        }
    }
}
