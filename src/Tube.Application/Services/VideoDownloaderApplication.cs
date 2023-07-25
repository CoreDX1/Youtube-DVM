using Tube.Application.Interfaces;
using Tube.Utilities.Options;
using Tube.Utilities.Static;

namespace Tube.Application.Services;

public class VideoDownloaderApplication : IVideoDownloaderApplication
{
    private readonly IFormateProcessApplication _processExecutor;

    public VideoDownloaderApplication(IFormateProcessApplication processExecutor)
    {
        _processExecutor = processExecutor;
    }

    public async Task<string> RunVideoDownload(
        string url,
        string format = "bestvideo+bestaudio/best",
        DownloadMergeFormat mergeFormat = DownloadMergeFormat.Unspecified,
        CancellationToken ct = default
    )
    {
        string videoArgument = @$" -P {Const.pathFolder} {url}";
        return await _processExecutor.ExecuteProcess(videoArgument);
    }

    protected virtual OptionSet GetDownloadOptions()
    {
        return new OptionSet() { Output = Utils.OutputFolder };
    }
}
