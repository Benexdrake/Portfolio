using System.Globalization;

using System.Text.RegularExpressions;


namespace Unicode_Escape_Sequence_Converter_Console
{
    public class UnicodeConverter
    {
        private static readonly Regex Regex = new Regex(@"\\[uU]([0-9A-Fa-f]{4})");
        public static async Task<string> UnescapeUnicode(string str)
        {
            return Regex.Replace(str,
                match => ((char)int.Parse(match.Value.Substring(2),
                    NumberStyles.HexNumber)).ToString());
        }
    }
}
