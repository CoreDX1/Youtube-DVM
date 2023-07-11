namespace Tube.Application.Interfaces;

public interface IFormateProcessApplication
{
    public Task<string> ExecuteProcess(string arguments);
}
