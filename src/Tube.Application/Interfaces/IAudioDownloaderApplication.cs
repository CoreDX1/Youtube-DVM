namespace Tube.Application.Interfaces;

public interface IAudioDownloaderApplication
{
    public Task<string> AudioDownload(string url);
    public Task<string> AudioPlayslistDownload(string url);
}
