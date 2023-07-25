namespace Tube.Utilities.Options;

public partial class OptionSet : ICloneable
{
    private static readonly OptionComparer _comparer = new OptionComparer();
    public static readonly OptionSet Default = new OptionSet();

    public object Clone()
    {
        throw new NotImplementedException();
    }
}
