using Tube.Application.Interfaces;

namespace Tube.Application.Services;

public class VideoApplication : IVideoApplication
{
    public VideoApplication() { }

    public string GetVideo()
    {
        return "Demo for Tube Application";
    }
}
