using Tube.Application.DTO.Request;

namespace Tube.Application.Interfaces;

public interface IVideoApplication
{
    public string GetVideo(VideoRequestDto video);
}
