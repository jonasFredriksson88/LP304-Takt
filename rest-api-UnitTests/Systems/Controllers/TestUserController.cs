using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using rest_api.Controllers;
using rest_api.Interfaces.Services;
using rest_api.models;

namespace rest_api_UnitTests.Systems.Controllers
{
    public class TestUserController
    {
        [Fact]
        public async void GetUsers_OnSuccess_InvokesUserServiceExactlyOnce()
        {
            var _userServiceMock = new Mock<IUserService>();

            _userServiceMock
                .Setup(service => service.GetEntities())
                .ReturnsAsync(new List<User>());

            var sut = new UserController(_userServiceMock.Object);

            var result = await sut.GetUsers();

            _userServiceMock.Verify(
                service => service.GetEntities(), 
                Times.Once);
        }
    }
}