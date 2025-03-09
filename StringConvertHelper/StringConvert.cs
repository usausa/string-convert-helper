namespace StringConvertHelper;

using System;
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
            if (Boolean.TryParse(value, out var t))
            {
                result = Unsafe.As<bool, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(bool?))
        {
            if (Boolean.TryParse(value, out var t))
            {
                bool? nullable = t;
                result = Unsafe.As<bool?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(byte))
        {
            if (Byte.TryParse(value, out var t))
            {
                result = Unsafe.As<byte, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(byte?))
        {
            if (Byte.TryParse(value, out var t))
            {
                byte? nullable = t;
                result = Unsafe.As<byte?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(sbyte))
        {
            if (SByte.TryParse(value, out var t))
            {
                result = Unsafe.As<sbyte, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(sbyte?))
        {
            if (SByte.TryParse(value, out var t))
            {
                sbyte? nullable = t;
                result = Unsafe.As<sbyte?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(char))
        {
            if (Char.TryParse(value, out var t))
            {
                result = Unsafe.As<char, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(char?))
        {
            if (Char.TryParse(value, out var t))
            {
                char? nullable = t;
                result = Unsafe.As<char?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(short))
        {
            if (Int16.TryParse(value, out var t))
            {
                result = Unsafe.As<short, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(short?))
        {
            if (Int16.TryParse(value, out var t))
            {
                short? nullable = t;
                result = Unsafe.As<short?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(ushort))
        {
            if (UInt16.TryParse(value, out var t))
            {
                result = Unsafe.As<ushort, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(ushort?))
        {
            if (UInt16.TryParse(value, out var t))
            {
                ushort? nullable = t;
                result = Unsafe.As<ushort?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(int))
        {
            if (Int32.TryParse(value, out var t))
            {
                result = Unsafe.As<int, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(int?))
        {
            if (Int32.TryParse(value, out var t))
            {
                int? nullable = t;
                result = Unsafe.As<int?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(uint))
        {
            if (UInt32.TryParse(value, out var t))
            {
                result = Unsafe.As<uint, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(uint?))
        {
            if (UInt32.TryParse(value, out var t))
            {
                uint? nullable = t;
                result = Unsafe.As<uint?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(long))
        {
            if (Int64.TryParse(value, out var t))
            {
                result = Unsafe.As<long, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(long?))
        {
            if (Int64.TryParse(value, out var t))
            {
                long? nullable = t;
                result = Unsafe.As<long?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(ulong))
        {
            if (UInt64.TryParse(value, out var t))
            {
                result = Unsafe.As<ulong, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(ulong?))
        {
            if (UInt64.TryParse(value, out var t))
            {
                ulong? nullable = t;
                result = Unsafe.As<ulong?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(Int128))
        {
            if (Int128.TryParse(value, out var t))
            {
                result = Unsafe.As<Int128, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(Int128?))
        {
            if (Int128.TryParse(value, out var t))
            {
                Int128? nullable = t;
                result = Unsafe.As<Int128?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(UInt128))
        {
            if (UInt128.TryParse(value, out var t))
            {
                result = Unsafe.As<UInt128, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(UInt128?))
        {
            if (UInt128.TryParse(value, out var t))
            {
                UInt128? nullable = t;
                result = Unsafe.As<UInt128?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(IntPtr))
        {
            if (IntPtr.TryParse(value, out var t))
            {
                result = Unsafe.As<IntPtr, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(IntPtr?))
        {
            if (IntPtr.TryParse(value, out var t))
            {
                IntPtr? nullable = t;
                result = Unsafe.As<IntPtr?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(UIntPtr))
        {
            if (UIntPtr.TryParse(value, out var t))
            {
                result = Unsafe.As<UIntPtr, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(UIntPtr?))
        {
            if (UIntPtr.TryParse(value, out var t))
            {
                UIntPtr? nullable = t;
                result = Unsafe.As<UIntPtr?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(Half))
        {
            if (Half.TryParse(value, out var t))
            {
                result = Unsafe.As<Half, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(Half?))
        {
            if (Half.TryParse(value, out var t))
            {
                Half? nullable = t;
                result = Unsafe.As<Half?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(float))
        {
            if (Single.TryParse(value, out var t))
            {
                result = Unsafe.As<float, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(float?))
        {
            if (Single.TryParse(value, out var t))
            {
                float? nullable = t;
                result = Unsafe.As<float?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(double))
        {
            if (Double.TryParse(value, out var t))
            {
                result = Unsafe.As<double, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(double?))
        {
            if (Double.TryParse(value, out var t))
            {
                double? nullable = t;
                result = Unsafe.As<double?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(decimal))
        {
            if (Decimal.TryParse(value, out var t))
            {
                result = Unsafe.As<decimal, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(decimal?))
        {
            if (Decimal.TryParse(value, out var t))
            {
                decimal? nullable = t;
                result = Unsafe.As<decimal?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(DateTime))
        {
            if (DateTime.TryParse(value, out var t))
            {
                result = Unsafe.As<DateTime, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(DateTime?))
        {
            if (DateTime.TryParse(value, out var t))
            {
                DateTime? nullable = t;
                result = Unsafe.As<DateTime?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(DateTimeOffset))
        {
            if (DateTimeOffset.TryParse(value, out var t))
            {
                result = Unsafe.As<DateTimeOffset, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(DateTimeOffset?))
        {
            if (DateTimeOffset.TryParse(value, out var t))
            {
                DateTimeOffset? nullable = t;
                result = Unsafe.As<DateTimeOffset?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(DateOnly))
        {
            if (DateOnly.TryParse(value, out var t))
            {
                result = Unsafe.As<DateOnly, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(DateOnly?))
        {
            if (DateOnly.TryParse(value, out var t))
            {
                DateOnly? nullable = t;
                result = Unsafe.As<DateOnly?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(TimeOnly))
        {
            if (TimeOnly.TryParse(value, out var t))
            {
                result = Unsafe.As<TimeOnly, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(TimeOnly?))
        {
            if (TimeOnly.TryParse(value, out var t))
            {
                TimeOnly? nullable = t;
                result = Unsafe.As<TimeOnly?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(TimeSpan))
        {
            if (TimeSpan.TryParse(value, out var t))
            {
                result = Unsafe.As<TimeSpan, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(TimeSpan?))
        {
            if (TimeSpan.TryParse(value, out var t))
            {
                TimeSpan? nullable = t;
                result = Unsafe.As<TimeSpan?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(Guid))
        {
            if (Guid.TryParse(value, out var t))
            {
                result = Unsafe.As<Guid, T>(ref t);
                return true;
            }
            result = default!;
            return false;
        }
        if (typeof(T) == typeof(Guid?))
        {
            if (Guid.TryParse(value, out var t))
            {
                Guid? nullable = t;
                result = Unsafe.As<Guid?, T>(ref nullable);
                return true;
            }
            result = default!;
            return false;
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
