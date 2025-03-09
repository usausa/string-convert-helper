namespace StringConvertHelper.Tests;

using System.ComponentModel;
using System.Globalization;

public sealed class StringConvertTest
{
    [Fact]
    public void TestByParsable()
    {
        var result = StringConvert.TryConvert<int>("12345", out var value);

        Assert.True(result);
        Assert.Equal(12345, value);
    }

    [Fact]
    public void TestByNullableParsable()
    {
        var result = StringConvert.TryConvert<int?>("12345", out var value);

        Assert.True(result);
        Assert.Equal(12345, value);
    }

    [Fact]
    public void TestByTypeConverter()
    {
        var result = StringConvert.TryConvert<CustomType>("12345", out var value);

        Assert.True(result);
        Assert.Equal(12345, value.Value);
    }

    [TypeConverter(typeof(CustomTypeConverter))]
    private sealed class CustomType
    {
        public int Value { get; }

        public CustomType(int value)
        {
            Value = value;
        }
    }

    public sealed class CustomTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType) =>
            sourceType == typeof(string);

        public override object ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value) =>
            new CustomType(Int32.Parse((string)value, null));
    }
}
