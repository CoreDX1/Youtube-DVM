using Tube.Application.DTO.Request;

namespace Tube.Application.Interfaces;

public interface IVideoApplication
{
    public Task<string> Video(VideoRequestDto video);
}
