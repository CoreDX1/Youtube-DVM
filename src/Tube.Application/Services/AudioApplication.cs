using Tube.Application.Interfaces;
using Tube.Application.DTO.Request;

namespace Tube.Application.Services;

public class AudioApplication : IAudioApplication
{
    public string AudioDownload(VideoRequestDto url)
    {
        var audio = new FormateProcessApplication(url.URL).DownloadAudio();
        return audio ? "Downloaded" : "Error";
    }
}
