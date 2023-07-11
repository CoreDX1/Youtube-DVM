using Tube.Application.DTO.Request;

namespace Tube.Application.Interfaces;

public interface IAudioApplication
{
    public string AudioDownload(VideoRequestDto url);
}
