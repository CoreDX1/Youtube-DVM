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
        [Route("Audio")]
        public string DownloadAudio([FromBody] VideoRequestDto video)
        {
            return _app.AudioDownload(video);
        }
    }
}
