namespace BetaSpline.Extensions
{
    public static class ExtensionsFactory
    {
        public static StringExtensions Extensions(this string input)
        {
            return new StringExtensions(input);
        }
    }
}