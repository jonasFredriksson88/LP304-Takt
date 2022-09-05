using rest_api.Models;
using Microsoft.AspNetCore.Mvc;
using rest_api.Interfaces;
using AutoMapper;
using rest_api.DTO;
using rest_api.Mapper;
using rest_api.Services;
using rest_api.Interfaces.Services;

namespace rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController( IMapper mapper, ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CompanyDto>>> GetCompanies()
        {
            return Ok( (await _companyService.GetEntities()).Select(c => c.AsDto()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyDto>> GetCompany(int id)
        {
            var company = await _companyService.GetEntity(id);

            if (company == null)
            {
                return NotFound("User with id " + id + " was not found.");
            }

            return Ok(company.AsDto());
        }

        [HttpGet("{companyId}/users")]
        public async Task<ActionResult<List<UserDto>>> GetUserByCompany(int companyId)
        {
            var users = (await _companyService.GetUserByCompany(companyId)).Select(u => u.AsDto());
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> AddCompany(CompanyCreateDto company)
        {
            await _companyService.Add(company.AsEntity());

            return Ok();
        }
    }
}
