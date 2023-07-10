using System.Diagnostics;
using Tube.Application.DTO.Request;
using Tube.Application.Interfaces;

namespace Tube.Application.Services;

public class VideoApplication : IVideoApplication
{
    public VideoApplication() { }

    public string GetVideo(VideoRequestDto video)
    {
        string pathYt =
            @"C:\Users\Christian\Desktop\Project\Youtube-Download\Codec\YT-DLP\yt-dlp.exe";
        Process processYt = new Process();
        try
        {
            processYt.StartInfo.FileName = pathYt;
            processYt.StartInfo.Arguments =
                @$"-P C:\Users\Christian\Desktop\Project\Youtube-Download\Downloads\ {video.URL}";
            processYt.StartInfo.UseShellExecute = false;
            processYt.StartInfo.RedirectStandardOutput = true;
            processYt.StartInfo.CreateNoWindow = true;

            processYt.Start();

            string salida = processYt.StandardOutput.ReadToEnd();
            processYt.WaitForExit();
            Console.WriteLine(salida);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return "Video";
    }
}
