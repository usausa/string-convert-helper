namespace StringConvertHelper;

using System.ComponentModel;
using System.Runtime.CompilerServices;

public static class StringConverter
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool TryConvert<TResult>(string? value, out TResult result) => Converter<TResult>.TryConverter.TryConvert(value, out result);

    internal static class Converter<T>
    {
        internal static readonly ITryConverter<T> TryConverter = ResolveConverter();

        private static ITryConverter<T> ResolveConverter()
        {
            var type = typeof(T);
            if (type == typeof(int))
            {
                return (ITryConverter<T>)(object)new Int32Converter();
            }

            // TODO

            return new AlwaysFailedConverter<T>();
        }
    }

    internal interface ITryConverter<T>
    {
        bool TryConvert(string? value, out T result);
    }

    // TODO

    private sealed class Int32Converter : ITryConverter<int>
    {
        public bool TryConvert(string? value, out int result) => Int32.TryParse(value, out result);
    }

    private sealed class AlwaysFailedConverter<T> : ITryConverter<T>
    {
        public bool TryConvert(string? value, out T result)
        {
            result = default!;
            return false;
        }
    }

    public sealed class TypeConverterConverter<T> : ITryConverter<T>
    {
        private static readonly TypeConverter Converter = TypeDescriptor.GetConverter(typeof(T));

        public bool TryConvert(string? value, out T result)
        {
            if (value is null)
            {
                result = default!;
                return true;
            }

#pragma warning disable CA1031
            try
            {
                result = (T)Converter.ConvertFrom(value)!;
                return true;
            }
            catch (Exception)
            {
                result = default!;
                return false;
            }
#pragma warning restore CA1031
        }
    }
}
