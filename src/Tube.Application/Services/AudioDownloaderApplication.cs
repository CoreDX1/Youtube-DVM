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
        string audioArgument = @$"-P {Const.pathFolder} {url} -f ba[ext=m4a]";
        return await _processExecutor.ExecuteProcess(audioArgument);
    }

    public async Task<string> AudioPlayslistDownload(string url)
    {
        string videoArgument =
            @$"--ignore-errors --format bestaudio --extract-audio --output '%(title)s.%(ext)s' --yes-playlist https://www.youtube.com/playlist?list=PLqD1n_qEWOZ2yHyntUbhs0NgMglPcYttk -f ba[ext=m4a]";

        return await _processExecutor.ExecuteProcess(videoArgument);
    }
}
