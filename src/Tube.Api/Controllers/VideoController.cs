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
        [Route("Download")]
        public async Task<IActionResult> Get([FromBody] VideoRequestDto video)
        {
            var response = await _app.Video(video);
            return Ok(response);
        }
    }
}
