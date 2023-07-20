using Microsoft.AspNetCore.Mvc;
using SharedLibrary;

namespace Server.Controllers;

[ApiController]
[Route("controller")]

public class PlayerController : ControllerBase {
    [HttpGet]
    public Player Get() {
        var player = new Player();
        player.Color = "blue";

        return player;
    }
}