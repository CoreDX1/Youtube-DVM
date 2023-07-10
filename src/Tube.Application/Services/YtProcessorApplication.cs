using System.Diagnostics;
using Tube.Application.DTO.Request;

namespace Tube.Application.Services;

public class YtProcessorApplication
{
    private readonly string pathFolder =
        @"C:\Users\Christian\Desktop\Project\Youtube-Download\Downloads";
    private readonly string pathYt =
        @"C:\Users\Christian\Desktop\Project\Youtube-Download\Codec\YT-DLP\yt-dlp.exe";

    public bool ProcessYt(VideoRequestDto video)
    {
        try
        {
            using (Process processYt = new Process())
            {
                processYt.StartInfo.FileName = pathYt;
                processYt.StartInfo.Arguments = @$"-P {pathFolder} {video.URL}";
                processYt.StartInfo.UseShellExecute = false;
                processYt.StartInfo.RedirectStandardOutput = true;
                processYt.StartInfo.CreateNoWindow = true;

                processYt.Start();

                string salida = processYt.StandardOutput.ReadToEnd();
                processYt.WaitForExit();

                return true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return false;
    }
}
