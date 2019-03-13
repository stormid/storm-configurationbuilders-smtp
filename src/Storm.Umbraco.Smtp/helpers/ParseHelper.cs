namespace Storm.Umbraco.Smtp.helpers
{
    internal class ParseHelper
    {
        internal static bool ParseBoolean(string value, bool defaultValue)
        {
            return bool.TryParse(value, out bool result) ? result : defaultValue;
        }

        internal static int ParseInt(string value, int defaultValue)
        {
            return int.TryParse(value, out int result) ? result : defaultValue;
        }

        internal static string ParseString(string value, string defaultValue = "")
        {
            return !string.IsNullOrWhiteSpace(value) ? value : defaultValue;
        }
    }
}