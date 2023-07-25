using Tube.Application.Interfaces;
using Tube.Utilities.Options;
using Tube.Utilities.Static;

namespace Tube.Application.Services;

public class YoutubeDL : IYoutubeDL
{
    /// <summary>
    /// Path to the yt-dlp executable.
    /// </summary>
    public string YoutubeDLPath { get; set; } = Utils.YtDlpBinaryName;

    /// <summary>
    /// Path to the FFmeg executable.
    /// </summary>
    public string FFmpegPath { get; set; } = Utils.FFmpegBinaryName;

    /// <summary>
    /// Path of the folder where items will be dowloaded to.
    /// </summary>
    public string OutputFolder { get; set; } = Utils.OutputFolder;

    public async Task<string> RunVideoDownload(
        string url,
        string format = "bestvideo+bestaudio/best",
        DownloadMergeFormat mergeFormat = DownloadMergeFormat.Unspecified,
        IProgress<string> output = null,
        CancellationToken ct = default
    )
    {
        var opts = GetDownloadOptions();
        var rpc = new FormateProcessApplication();
        // string videoArgument = @$" -P {Const.pathFolder} {url}";
        var process = new YoutubeDLProcess();
        output?.Report($"Arguments: {process.ConvertToArgs(new[] { url }, opts)}\n");
        Console.WriteLine($"Arguments : {process.ConvertToArgs(new[] { url }, opts)}\n");
        return await rpc.ExecuteProcess("");
    }

    protected virtual OptionSet GetDownloadOptions()
    {
        return new OptionSet() { Output = OutputFolder, FFmpegLocation = FFmpegPath };
    }
}
