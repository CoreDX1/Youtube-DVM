using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        [Route("Video")]
        public string Get()
        {
            return _app.GetVideo();
        }
    }
}
