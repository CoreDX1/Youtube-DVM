using Tube.Utilities.Options;

namespace Tube.Application.Interfaces;

public interface IVideoDownloaderApplication
{
    public Task<string> RunVideoDownload(
        string url,
        string format = "bestvideo+bestaudio/best",
        DownloadMergeFormat mergeFormat = DownloadMergeFormat.Unspecified,
        CancellationToken ct = default
    );
}
