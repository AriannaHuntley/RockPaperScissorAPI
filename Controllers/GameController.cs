using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace RockPaperScissorAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GameController : ControllerBase
{
    private readonly GameService _service;
    public GameController(GameService service)
    {
        _service = service;
    }

    [HttpGet]

    [Route("ComputerRnd")]

    public string ComputerRndSelection()
    {
        return _service.ComputerRnd();
    }
}
