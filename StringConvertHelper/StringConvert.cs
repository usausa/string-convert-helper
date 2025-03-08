namespace StringConvertHelper;

using System.ComponentModel;
using System.Runtime.CompilerServices;

public static class StringConvert
{
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static T As<T>(string? value)
    {
        TryConvert<T>(value, out var result);
        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool TryConvert<T>(string? value, out T result)
    {
        if (String.IsNullOrEmpty(value))
        {
            result = default!;
            return true;
        }

        if (typeof(T) == typeof(bool))
        {
            result = Boolean.TryParse(value, out var t) ? Unsafe.As<bool, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(bool?))
        {
            result = Boolean.TryParse(value, out var t) ? Unsafe.As<bool, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(byte))
        {
            result = Byte.TryParse(value, out var t) ? Unsafe.As<byte, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(byte?))
        {
            result = Byte.TryParse(value, out var t) ? Unsafe.As<byte, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(sbyte))
        {
            result = SByte.TryParse(value, out var t) ? Unsafe.As<sbyte, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(sbyte?))
        {
            result = SByte.TryParse(value, out var t) ? Unsafe.As<sbyte, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(char))
        {
            result = Char.TryParse(value, out var t) ? Unsafe.As<char, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(char?))
        {
            result = Char.TryParse(value, out var t) ? Unsafe.As<char, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(short))
        {
            result = Int16.TryParse(value, out var t) ? Unsafe.As<short, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(short?))
        {
            result = Int16.TryParse(value, out var t) ? Unsafe.As<short, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(ushort))
        {
            result = UInt16.TryParse(value, out var t) ? Unsafe.As<ushort, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(ushort?))
        {
            result = UInt16.TryParse(value, out var t) ? Unsafe.As<ushort, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(int))
        {
            result = Int32.TryParse(value, out var t) ? Unsafe.As<int, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(int?))
        {
            result = Int32.TryParse(value, out var t) ? Unsafe.As<int, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(uint))
        {
            result = UInt32.TryParse(value, out var t) ? Unsafe.As<uint, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(uint?))
        {
            result = UInt32.TryParse(value, out var t) ? Unsafe.As<uint, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(long))
        {
            result = Int64.TryParse(value, out var t) ? Unsafe.As<long, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(long?))
        {
            result = Int64.TryParse(value, out var t) ? Unsafe.As<long, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(ulong))
        {
            result = UInt64.TryParse(value, out var t) ? Unsafe.As<ulong, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(ulong?))
        {
            result = UInt64.TryParse(value, out var t) ? Unsafe.As<ulong, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(Int128))
        {
            result = Int128.TryParse(value, out var t) ? Unsafe.As<Int128, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(Int128?))
        {
            result = Int128.TryParse(value, out var t) ? Unsafe.As<Int128, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(UInt128))
        {
            result = UInt128.TryParse(value, out var t) ? Unsafe.As<UInt128, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(UInt128?))
        {
            result = UInt128.TryParse(value, out var t) ? Unsafe.As<UInt128, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(IntPtr))
        {
            result = IntPtr.TryParse(value, out var t) ? Unsafe.As<IntPtr, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(IntPtr?))
        {
            result = IntPtr.TryParse(value, out var t) ? Unsafe.As<IntPtr, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(UIntPtr))
        {
            result = UIntPtr.TryParse(value, out var t) ? Unsafe.As<UIntPtr, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(UIntPtr?))
        {
            result = UIntPtr.TryParse(value, out var t) ? Unsafe.As<UIntPtr, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(Half))
        {
            result = Half.TryParse(value, out var t) ? Unsafe.As<Half, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(Half?))
        {
            result = Half.TryParse(value, out var t) ? Unsafe.As<Half, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(float))
        {
            result = Single.TryParse(value, out var t) ? Unsafe.As<float, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(float?))
        {
            result = Single.TryParse(value, out var t) ? Unsafe.As<float, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(double))
        {
            result = Double.TryParse(value, out var t) ? Unsafe.As<double, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(double?))
        {
            result = Double.TryParse(value, out var t) ? Unsafe.As<double, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(decimal))
        {
            result = Decimal.TryParse(value, out var t) ? Unsafe.As<decimal, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(decimal?))
        {
            result = Decimal.TryParse(value, out var t) ? Unsafe.As<decimal, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(DateTime))
        {
            result = DateTime.TryParse(value, out var t) ? Unsafe.As<DateTime, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(DateTime?))
        {
            result = DateTime.TryParse(value, out var t) ? Unsafe.As<DateTime, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(DateTimeOffset))
        {
            result = DateTimeOffset.TryParse(value, out var t) ? Unsafe.As<DateTimeOffset, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(DateTimeOffset?))
        {
            result = DateTimeOffset.TryParse(value, out var t) ? Unsafe.As<DateTimeOffset, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(DateOnly))
        {
            result = DateOnly.TryParse(value, out var t) ? Unsafe.As<DateOnly, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(DateOnly?))
        {
            result = DateOnly.TryParse(value, out var t) ? Unsafe.As<DateOnly, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(TimeSpan))
        {
            result = TimeSpan.TryParse(value, out var t) ? Unsafe.As<TimeSpan, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(TimeSpan?))
        {
            result = TimeSpan.TryParse(value, out var t) ? Unsafe.As<TimeSpan, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(TimeOnly))
        {
            result = TimeOnly.TryParse(value, out var t) ? Unsafe.As<TimeOnly, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(TimeOnly?))
        {
            result = TimeOnly.TryParse(value, out var t) ? Unsafe.As<TimeOnly, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(Guid))
        {
            result = Guid.TryParse(value, out var t) ? Unsafe.As<Guid, T>(ref t) : default!;
            return true;
        }
        if (typeof(T) == typeof(Guid?))
        {
            result = Guid.TryParse(value, out var t) ? Unsafe.As<Guid, T>(ref t) : default!;
            return true;
        }

        if (value is T str)
        {
            result = str;
            return true;
        }

        var typeConverter = TypeConverterCache<T>.Converter;
        if (typeConverter is not null)
        {
#pragma warning disable CA1031
            try
            {
                var converted = typeConverter.ConvertFrom(value);
                result = converted is null ? default! : Unsafe.As<object, T>(ref converted);
                return true;
            }
            catch
            {
                result = default!;
                return false;
            }
#pragma warning restore CA1031
        }

        result = default!;
        return false;
    }

    private static class TypeConverterCache<T>
    {
        // ReSharper disable once StaticMemberInGenericType
        public static readonly TypeConverter? Converter;

#pragma warning disable CA1810
        static TypeConverterCache()
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            Converter = converter.CanConvertFrom(typeof(string)) ? converter : null;
        }
#pragma warning restore CA1810
    }
}
