using Microsoft.AspNetCore.Mvc;
using Tube.Application.DTO.Request;
using Tube.Application.Interfaces;

namespace src.Tube.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VideoController : ControllerBase
    {
        private readonly IVideoApplication _app;

        public VideoController(IVideoApplication app)
        {
            _app = app;
        }

        [HttpPost]
        [Route("Video")]
        public string Get([FromBody] VideoRequestDto video)
        {
            return _app.VideoDownload(video);
        }
    }
}
