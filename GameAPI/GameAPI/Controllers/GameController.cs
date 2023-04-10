using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GameAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private static readonly string[] GameNames = new[]
        {
        "Super Mario Sunshine", "Super Mario Odyssey", "Call of Duty: Black Ops Cold War", "Rocket League", "Sonic Adventure 2 Battle", "Need 4 Speed: Hot Pursuit 2"
        };
        private static readonly string[] Publishers = new[] { "Nintendo", "Activision", "Sega" };
        private static readonly string[] Genres = new[] { "1", "2", "3" };

        private readonly ILogger<GameController> _logger;

        public GameController(ILogger<GameController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetGameInformation")]
        public IEnumerable<Game> Get()
        {
            return Enumerable.Range(0, 6).Select(index => new Game
            {
                GameName = GameNames[index],
                Publisher = Publishers[Random.Shared.Next(Publishers.Length)],
                Genre = Genres[Random.Shared.Next(Publishers.Length)],
                GameRating = null,
                PercentComplete = 0
            });
        }
    }
}
