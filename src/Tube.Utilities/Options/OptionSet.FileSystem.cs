namespace Tube.Utilities.Options;

public partial class OptionSet
{
    private Option<string> paths = new Option<string>("-P", "--paths");
    private Option<string> output = new Option<string>("-o");

    public string Output
    {
        get => output.Value;
        set => output.Value = value;
    }
}
