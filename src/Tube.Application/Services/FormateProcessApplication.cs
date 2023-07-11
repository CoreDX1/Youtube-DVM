using Tube.Utilities.Static;
using System.Diagnostics;
using Tube.Application.Interfaces;

namespace Tube.Application.Services
{
    public class FormateProcessApplication : IFormateProcessApplication
    {
        public async Task<string> ExecuteProcess(string arguments)
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
                var output = processYt.StandardOutput.ReadToEnd();
                await processYt.WaitForExitAsync();
                return output;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                return null!;
            }
        }
    }
}
