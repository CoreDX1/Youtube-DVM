using Tube.Application.Interfaces;
using Tube.Utilities.Static;

namespace Tube.Application.Services;

public class VideoDownloaderApplication : IVideoDownloaderApplication
{
    private readonly IFormateProcessApplication _processExecutor;

    public VideoDownloaderApplication(IFormateProcessApplication processExecutor)
    {
        _processExecutor = processExecutor;
    }

    public async Task<string> VideoDownload(string url)
    {
        string videoArgument = @$"-P {Const.pathFolder} {url}";
        return await _processExecutor.ExecuteProcess(videoArgument);
    }
}
