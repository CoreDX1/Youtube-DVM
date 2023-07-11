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
        public async Task<IActionResult> DownloadAudio([FromBody] AudioRequestDto audio)
        {
            var response = await _app.Audio(audio);
            return Ok(response);
        }

        [HttpPost]
        [Route("Playslist")]
        public async Task<IActionResult> DownloadPlayslist([FromBody] AudioRequestDto audio)
        {
            var response = await _app.AudioPlayslistDownload(audio);
            return Ok(response);
        }
    }
}
