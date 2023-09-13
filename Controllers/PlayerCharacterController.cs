using Microsoft.AspNetCore.Mvc;
using Models;

namespace Knave_API.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayerCharacterController : ControllerBase
{
    private readonly IPlayerCharacterService _playerCharacterService;
    private readonly ILogger<PlayerCharacterController> _logger;

    public PlayerCharacterController(IPlayerCharacterService playerCharacterService, ILogger<PlayerCharacterController> logger)
    {
        _playerCharacterService = playerCharacterService;
        _logger = logger;
    }

    [HttpGet("Random")]
    public ActionResult<PlayerCharacter> Random()
    {
        return Ok(_playerCharacterService.Random());
    }
}
