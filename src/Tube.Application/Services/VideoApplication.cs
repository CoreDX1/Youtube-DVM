using System.Diagnostics;
using Tube.Application.DTO.Request;
using Tube.Application.Interfaces;

namespace Tube.Application.Services;

public class VideoApplication : IVideoApplication
{
    public VideoApplication() { }

    public string VideoDownload(VideoRequestDto url)
    {
        var donwload = new YtProcessorApplication();
        var salida = donwload.ProcessYt(url).DownloadVideo();
        return salida ? "Downloaded" : "Error";
    }
}
