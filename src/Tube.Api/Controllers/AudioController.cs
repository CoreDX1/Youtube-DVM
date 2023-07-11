using Microsoft.AspNetCore.Mvc;
using Tube.Application.DTO.Request;
using Tube.Application.Interfaces;

namespace src.Tube.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AudioController : ControllerBase
    {
        private readonly IAudioApplication _app;

        public AudioController(IAudioApplication app)
        {
            _app = app;
        }

        [HttpPost]
        [Route("Download")]
        public async Task<IActionResult> DownloadAudio([FromBody] AudioRequestDto video)
        {
            var response = await _app.Audio(video);
            return Ok(response);
        }
    }
}
