namespace BetaSpline.Extensions
{
    public static class ExtensionsFactory
    {
        public static StringExtensions Extensions(this string value)
        {
            return new StringExtensions(value);
        }

        public static IntegerExtensions Extensions(this int value)
        {
            return new IntegerExtensions(value);
        }
    }
}