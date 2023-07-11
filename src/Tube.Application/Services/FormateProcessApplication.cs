using Tube.Utilities.Static;
using System.Diagnostics;

namespace src.Tube.Application.Services
{
    public class FormateProcessApplication
    {
        public string Video;
        public string Audio;

        public FormateProcessApplication(string url)
        {
            Video = @$"-P {Const.pathFolder} {url}";
            Audio = @$"-P {Const.pathFolder} {url} -f ba[ext=m4a]";
        }

        public bool DownloadVideo() => ExecuteProcess(Video);

        public bool DownloadAudio() => ExecuteProcess(Audio);

        private bool ExecuteProcess(string arguments)
        {
            try
            {
                using (Process processYt = new Process())
                {
                    processYt.StartInfo.FileName = Const.pathYt;
                    processYt.StartInfo.Arguments = arguments;
                    processYt.StartInfo.UseShellExecute = false;
                    processYt.StartInfo.RedirectStandardOutput = true;
                    processYt.StartInfo.CreateNoWindow = true;

                    processYt.Start();

                    string output = processYt.StandardOutput.ReadToEnd();
                    processYt.WaitForExit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
