using System.Diagnostics;
using Tube.Application.DTO.Request;
using Tube.Application.Interfaces;

namespace Tube.Application.Services;

public class VideoApplication : IVideoApplication
{
    public VideoApplication() { }

    public string VideoDownload(VideoRequestDto video)
    {
        var Video = new FormateProcessApplication(video.URL).DownloadVideo();
        return Video ? "Downloaded" : "Error";
    }
}
