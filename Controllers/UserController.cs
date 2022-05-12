using Microsoft.AspNetCore.Mvc;
using Revisao.Models;
using Revisao.Repositories;

namespace Revisao.Controllers;

[ApiController]
public class UserController : ControllerBase
{
    private readonly UserRepository _userRepository;

    public UserController(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet]
    [Route("/users")]
    public async Task<IActionResult> GetAll()
    {
        IEnumerable<User> users = _userRepository.GetAll();
        return Ok(users);
    }
}
