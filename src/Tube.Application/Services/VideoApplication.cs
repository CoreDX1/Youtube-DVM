using Tube.Application.DTO.Request;
using Tube.Application.Interfaces;

namespace Tube.Application.Services;

public class VideoApplication : IVideoApplication
{
    private readonly IVideoDownloaderApplication _app;

    public VideoApplication(IVideoDownloaderApplication app)
    {
        _app = app;
    }

    public async Task<string> Video(VideoRequestDto video)
    {
        var ytDl = new YoutubeDL();
        var result = await ytDl.RunVideoDownload(video.URL);
        if (result is null)
            return "Error";

        return "Downloaded";
    }
}
