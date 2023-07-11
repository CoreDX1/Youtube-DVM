using Tube.Application.DTO.Request;

namespace Tube.Application.Interfaces;

public interface IAudioApplication
{
    public Task<string> Audio(AudioRequestDto url);
}
