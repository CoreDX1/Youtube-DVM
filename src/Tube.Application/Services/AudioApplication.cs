using Tube.Application.Interfaces;
using Tube.Application.DTO.Request;

namespace Tube.Application.Services;

public class AudioApplication : IAudioApplication
{
    public string AudioDownload(VideoRequestDto url)
    {
        var donwload = new YtProcessorApplication();
        var salida = donwload.ProcessYt(url).DownloadAudio();
        return salida ? "Downloaded" : "Error";
    }
}
