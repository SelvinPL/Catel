namespace Catel.Compatibility
{
    internal static class StringExtensions
    {
        public static bool Contains(this string str, char chr) => str.Contains(chr.ToString());
    }
}
