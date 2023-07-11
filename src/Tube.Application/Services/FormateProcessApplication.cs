using Tube.Utilities.Static;
using System.Diagnostics;

namespace Tube.Application.Services
{
    public class FormateProcessApplication
    {
        public string videoArgument;
        public string audioArgument;

        public FormateProcessApplication(string url)
        {
            videoArgument = @$"-P {Const.pathFolder} {url}";
            audioArgument = @$"-P {Const.pathFolder} {url} -f ba[ext=m4a]";
        }

        public bool DownloadVideo() => ExecuteProcess(videoArgument);

        public bool DownloadAudio() => ExecuteProcess(audioArgument);

        private bool ExecuteProcess(string arguments)
        {
            try
            {
                using var processYt = new Process()
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = Const.pathYt,
                        Arguments = arguments,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };

                processYt.Start();
                processYt.StandardOutput.ReadToEnd();
                processYt.WaitForExit();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
