﻿using Microsoft.AspNetCore.Mvc;
using rest_api.DTO;
using rest_api.Exceptions;
using rest_api.Interfaces.Services;
using rest_api.Mapper;

namespace rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController( IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserDto>>> GetUsers()
        {
            return Ok( (await _userService.GetEntities()).Select(user => user.AsDto()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetUser(int id)
        {
            var user = await _userService.GetEntity(id);

            if (user == null)
            {
                return NotFound("User with id " + id + " was not found.");
            }

            return Ok(user.AsDto());
        }

        [HttpGet("{userId}/companies")]
        public async Task<ActionResult<CompanyDto>> GetUserByCompany(int userId)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] UserCreateDto user, [FromQuery] int companyId)
        {
            await _userService.Add(user.AsEntity(), companyId);

            return Ok();
        }
    }
}
