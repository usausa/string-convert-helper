namespace StringConvertHelper;

using System.ComponentModel;
using System.Runtime.CompilerServices;

public static class StringConvert
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool TryConvert<TResult>(string? value, out TResult result) => Converter<TResult>.TryConverter.TryConvert(value, out result);

    internal static class Converter<T>
    {
        internal static readonly ITryConverter<T> TryConverter = ResolveConverter();

        private static ITryConverter<T> ResolveConverter()
        {
            var type = typeof(T);

            if (type.GetInterfaces().Any(static x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IParsable<>)))
            {
                var converterType = typeof(ParsableConverter<>).MakeGenericType(type);
                return (ITryConverter<T>)Activator.CreateInstance(converterType)!;
            }

            var converter = TypeDescriptor.GetConverter(type);
            if (converter.CanConvertFrom(typeof(string)))
            {
                return new TypeConverterConverter<T>();
            }

            return new AlwaysFailedConverter<T>();
        }
    }

    internal interface ITryConverter<T>
    {
        bool TryConvert(string? value, out T result);
    }

#pragma warning disable CA1812
    internal sealed class ParsableConverter<T> : ITryConverter<T>
        where T : IParsable<T>
    {
        public bool TryConvert(string? value, out T result) => T.TryParse(value, null, out result!);
    }
#pragma warning restore CA1812

    private sealed class AlwaysFailedConverter<T> : ITryConverter<T>
    {
        public bool TryConvert(string? value, out T result)
        {
            result = default!;
            return false;
        }
    }

    private sealed class TypeConverterConverter<T> : ITryConverter<T>
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
