using Tube.Application.Interfaces;
using Tube.Utilities.Static;

namespace Tube.Application.Services;

public class AudioDownloaderApplication : IAudioDownloaderApplication
{
    private readonly IFormateProcessApplication _processExecutor;

    public AudioDownloaderApplication(IFormateProcessApplication processExecutor)
    {
        _processExecutor = processExecutor;
    }

    public async Task<string> AudioDownload(string url)
    {
        string videoArgument = @$"-P {Const.pathFolder} {url} -f ba[ext=m4a]";
        return await _processExecutor.ExecuteProcess(videoArgument);
    }
}
