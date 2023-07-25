namespace Tube.Utilities.Options;

public partial class OptionSet
{
    private Option<bool> help = new Option<bool>("-h", "--help");

    public bool Help
    {
        get => help.Value;
        set => help.Value = value;
    }
}
