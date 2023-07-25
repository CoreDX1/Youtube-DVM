namespace Tube.Utilities.Options;

public class Option<T> : IOption
{
    private T value;

    public string DefaultOptionString => OptionStrings.Last();

    public string[] OptionStrings { get; }

    public bool IsSet { get; private set; }

    public bool IsCustom { get; }

    public Option(params string[] optionStrings)
    {
        OptionStrings = optionStrings;
        IsSet = false;
    }

    public T Value
    {
        get => value;
        set
        {
            this.IsSet = !object.Equals(value, default(T));
            this.value = value;
        }
    }

    public void SetFromString(string s)
    {
        string[] split = s.Split(' ');
        string stringValue = s.Substring(split[0].Length).Trim().Trim('"');
        if (!OptionStrings.Contains(split[0]))
        {
            throw new ArgumentException($"Given string does not match required format");
        }
        Value = Utils.OptionValueFromString<T>(stringValue);
    }

    public IEnumerable<string> ToStringCollection()
    {
        throw new NotImplementedException();
    }
}
