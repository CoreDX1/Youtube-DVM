namespace Tube.Utilities.Options;

public class YoutubeDLProcess
{
    public string ExecutablePath { get; set; }

    public YoutubeDLProcess(string executablePaht = "yt-dlp.exe")
    {
        this.ExecutablePath = executablePaht;
    }

    public string ConvertToArgs(string[] urls, OptionSet option) =>
        (urls != null ? String.Join(" ", urls.Select(s => $"\"{s}\"")) : String.Empty)
        + option.ToString();
}
