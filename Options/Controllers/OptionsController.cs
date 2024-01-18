using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Options.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController : ControllerBase
    {
        private readonly PlayerSettings _playersettings;

        public OptionsController(IOptions<PlayerSettings> playersettings)
        {
            _playersettings = playersettings.Value;
        }
        [HttpGet("Player")]
        public ActionResult GetPlayerSettings()
        {
            return Ok(_playersettings);
        }
    }
}
