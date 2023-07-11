namespace Tube.Application.Interfaces;

public interface IVideoDownloaderApplication
{
    public Task<string> VideoDownload(string url);
}
