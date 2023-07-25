namespace Tube.Utilities.Options;

public partial class OptionSet
{
    private Option<string> ffmpegLocation = new Option<string>("--ffmpeg-location");

    public string FFmpegLocation { get; set; } = Utils.FFmpegBinaryName;
}
