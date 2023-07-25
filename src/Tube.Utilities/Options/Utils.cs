using System.ComponentModel;
using System.Globalization;

namespace Tube.Utilities.Options
{
    public static class Utils
    {
        public static string YtDlpBinaryName => "af";
        public static string FFmpegBinaryName =>
            @"C:\Users\Christian\Desktop\Project\Youtube-Download\Codec\YT-DLP\ffmpeg.exe";

        public static string OutputFolder =>
            @"C:\Users\Christian\Desktop\Project\Youtube-Download\Downloads";

        public static T OptionValueFromString<T>(string stringValue)
        {
            if (typeof(T) == typeof(bool))
            {
                return (T)(object)true;
            }
            else if (typeof(T) == typeof(Enum))
            {
                string titleCase = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(stringValue);
                return (T)Enum.Parse(typeof(T), titleCase);
            }
            else if (typeof(T) == typeof(DateTime))
            {
                return (T)(object)DateTime.ParseExact(stringValue, "yyyyMMdd", null);
            }
            else
            {
                TypeConverter conv = TypeDescriptor.GetConverter(typeof(T));
                return (T)conv.ConvertFrom(stringValue);
            }
        }

        public static string OptionValueToString<T>(T value)
        {
            string val;
            if (value is bool)
                val = String.Empty;
            else if (value is Enum)
                val = $" \"{value.ToString().ToLower()}\"";
            else if (value is DateTime dateTime)
                val = $" {dateTime.ToString("yyyyMMdd")}";
            else if (value is string)
                val = $" \"{value}\"";
            else
                val = " " + value;
            return val;
        }
    }
}
