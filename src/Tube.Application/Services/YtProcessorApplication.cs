using System.Diagnostics;
using src.Tube.Application.Services;
using Tube.Application.DTO.Request;

namespace Tube.Application.Services;

public class YtProcessorApplication
{
    public FormateProcessApplication ProcessYt(VideoRequestDto video)
    {
        var format = new FormateProcessApplication(video.URL);
        return format;
    }
}
