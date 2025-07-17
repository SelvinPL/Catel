namespace Catel.Compatibility
{
    internal static class StringEx
    {
        public static bool Contains(this string str, char chr) => str.Contains(chr.ToString());
    }
}
