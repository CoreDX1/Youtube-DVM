namespace Tube.Utilities.Options;

public interface IOption
{
    string DefaultOptionString { get; }
    string[] OptionStrings { get; }
    bool IsSet { get; }
    void SetFromString(string s);
    IEnumerable<string> ToStringCollection();
    bool IsCustom { get; }
}
