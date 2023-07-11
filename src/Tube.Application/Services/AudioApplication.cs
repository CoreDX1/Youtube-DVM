using Tube.Application.Interfaces;
using Tube.Application.DTO.Request;

namespace Tube.Application.Services;

public class AudioApplication : IAudioApplication
{
    private readonly IAudioDownloaderApplication _app;

    public AudioApplication(IAudioDownloaderApplication app)
    {
        _app = app;
    }

    public async Task<string> Audio(AudioRequestDto audio)
    {
        var result = await _app.AudioDownload(audio.URL);
        if (result is null)
            return "Error";

        return "Downloaded";
    }
}
