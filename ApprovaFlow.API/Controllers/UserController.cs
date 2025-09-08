using ApprovaFlow.Application.Models;
using ApprovaFlow.Core.Repositories;
using ApprovaFlow.Infrastructure.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace ApprovaFlow.API.Controllers
{
   
    [ApiController]
    [Route("api/user")]
    [Authorize]
    public class UserController : ControllerBase

    {
        private readonly IUserRepository _repository;

        public UserController(UserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [AllowAnonymous]

        //public async Task<IActionResult> CreateUser(CreateUserInputModel model)
        //{
        //    var user = await _repository.CreateUser(model);

        //    return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, model);
        //}

        [HttpGet]
        public async Task<IActionResult> GetAllRequest()
        {
            var requests = await _repository.GetAllRequest();
            return Ok(requests);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRequestById(int id)
        {
            var requests = await _repository.GetRequestId(id);
            

            return Ok();
        }
    }
}
