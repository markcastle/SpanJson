# 🚀 SpanJson

[![NuGet](https://img.shields.io/nuget/v/SpanJson.svg)](https://www.nuget.org/packages/SpanJson)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
[![Build Status](https://github.com/markcastle/SpanJson/actions/workflows/build.yml/badge.svg)](https://github.com/markcastle/SpanJson/actions/workflows/build.yml)

> A high-performance JSON serializer for .NET that leverages `Span<T>` for maximum performance and minimal allocations.

## 📊 Performance

See [Performance Benchmarks](https://github.com/markcastle/SpanJson/wiki/Performance) for detailed comparisons with other JSON serializers.

## ✨ Features

### 🔄 Core Functionality
- Serialization and Deserialization into/from:
  - Byte arrays
  - Strings
  - TextWriter/TextReader
  - Streams

### 📦 Supported Types
- **Primitive Types**: `bool`, `char`, `sbyte`, `Int16`, `Int32`, `Int64`, `byte`, `UInt16`, `UInt32`, `UInt64`, `Single`, `Double`, `decimal`
- **Date/Time**: `DateTime`, `DateTimeOffset`, `TimeSpan`, `DateOnly`, `TimeOnly`
- **Special Types**: `string`, `Uri`, `Guid`, `Version`
- **Collections**: Arrays, Lists, Dictionaries, Tuples, ValueTuples, KeyValuePairs
- **Enums**: String and integer support (including Flags)
- **Dynamic Objects**
- **Anonymous Types**
- **Immutable Collections**: `ImmutableList`, `ImmutableArray`, `ImmutableDictionary`, `ImmutableSortedDictionary`

### 🛠️ Advanced Features
- **Custom Resolvers** for controlling serialization behavior
- **Pretty Printing** and **Minification** of JSON
- **ISO8601** DateTime formatting
- **Extension Data** support via `[JsonExtensionData]`
- **Custom Serializers** via `[JsonCustomSerializer]`
- **Constructor Injection** via `[JsonConstructor]`
- **Member Control**:
  - `[DataMember(Name="MemberName")]` for custom field names
  - `[IgnoreDataMember]` to exclude members
  - `ShouldSerializeXXX()` pattern for runtime control
  - `[EnumMember]` for custom enum string values

## 🚀 Quick Start

### Installation
```bash
dotnet add package SpanJson
```

#### Unity

To use SpanJson in Unity, you'll need to open the Package Manager and install the package via the Git URL. Follow these steps:

1. Open Unity.
2. In the top menu, go to Window > Package Manager.
3. In the Package Manager, click the + button at the top-left corner and select "Add package from git URL...".
4. Enter the following Git URL: 
    https://github.com/markcastle/SpanJson.git?path=/SpanJson
5. Click Add to install the SpanJson package into your Unity project.

This will allow you to use the SpanJson library directly in Unity.

### Basic Usage
```csharp
using SpanJson;

// Simple serialization/deserialization
var input = new Input { Text = "Hello World" };
var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
var deserialized = JsonSerializer.Generic.Utf16.Deserialize<Input>(serialized);
```

### API Overview

#### Synchronous API
```csharp
// UTF16
var result = JsonSerializer.Generic.Utf16.Serialize(input);
var result = JsonSerializer.Generic.Utf16.Deserialize<Input>(input);

// UTF8
var result = JsonSerializer.Generic.Utf8.Serialize(input);
var result = JsonSerializer.Generic.Utf8.Deserialize<Input>(input);

// ArrayPool (remember to return!)
var result = JsonSerializer.Generic.Utf16.SerializeToArrayPool(input);
```

#### Asynchronous API
```csharp
// UTF16
ValueTask result = JsonSerializer.Generic.Utf16.SerializeAsync(input, textWriter, cancellationToken);
ValueTask<Input> result = JsonSerializer.Generic.Utf16.DeserializeAsync<Input>(textReader, cancellationToken);

// UTF8
ValueTask result = JsonSerializer.Generic.Utf8.SerializeAsync(input, stream, cancellationToken);
ValueTask<Input> result = JsonSerializer.Generic.Utf8.DeserializeAsync<Input>(stream, cancellationToken);
```

## 🎯 Advanced Usage

### Custom Resolvers
```csharp
// Use different resolvers for custom behavior
var serialized = JsonSerializer.NonGeneric.Utf16.Serialize<Input, IncludeNullsOriginalCaseResolver<char>>(input);
```

### Pretty Printing & Minification
```csharp
// Pretty print JSON
var pretty = JsonSerializer.PrettyPrinter.Print(serialized);

// Minify JSON
var minified = JsonSerializer.Minifier.Minify(serialized);
```

### Constructor Injection
```csharp
public class DefaultDO
{
    [JsonConstructor]
    public DefaultDO(string key, int value)
    {
        Key = key;
        Value = value;
    }

    public string Key { get; }
    public int Value { get; }
}
```

### Custom Serializers
```csharp
[JsonCustomSerializer(typeof(LongAsStringFormatter), "Hello World")]
public class TestDTO
{
    public long Value { get; set; }
}
```

## 📚 Documentation

For more detailed information, please refer to:
- [Performance Benchmarks](https://github.com/markcastle/SpanJson/wiki/Performance)
- [API Documentation](https://github.com/markcastle/SpanJson/wiki)

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## What is supported ##
- Serialization and Deserialization into/from byte arrays, strings, TextWriter/TextReader and streams
- Serialization and Deserialization of Arrays, Lists, Complex types of the following Base Class Library types:
    - ``bool``, ``char``
    - ``sbyte``, ``Int16``, ``Int32``, ``Int64``
    - ``byte``, ``UInt16``, ``UInt32``, ``UInt64``
    - ``Single``, ``Double``, ``decimal``
    - ``DateTime``, ``DateTimeOffset``, ``TimeSpan``, ``DateOnly``, ``TimeOnly``
    - ``string``, ``Uri``
    - ``Guid``,  ``Version``
    - ``Tuple<,>``,``ValueTuple<,>``, ``KeyValuePair<,>``
- Public Properties and Fields are considered for serialization/deserialization
- DateTime{Offset} is in ISO8601 mode with profile https://www.w3.org/TR/NOTE-datetime
- Dynamics
- Enums (string and integer, for integer see section Custom Resolver), incl. Flags
- Anonymous types
- ``Dictionary``, ``ConcurrentDictionary`` with string/int/enum as key, the enum is formatted as a string
- Serialization/Deserialization of most IEnumerable<T> types (Stack and ConcurrentStack are not supported)
- Support for ``[DataMember(Name="MemberName")]`` to set field name
- Support for ``[IgnoreDataMember]`` to ignore a specific member
- Support for ``ShouldSerializeXXX()`` method pattern to decide at runtime if a member should be serialized
- Support for ``[EnumMember]`` to specify the string value of the enum value
- Support for Immutable Collections, full Serialization/Deserialization for ``ImmutableList``, ``ImmutableArray``, ``ImmutableDictionary``, ``ImmutableSortedDictionary``. ``ImmutableStack`` is not supported
- Support for read-only collections, ``ReadOnlyCollection``, ``ReadOnlyDictionary``, they are deserialized into a writeable type (i.e. ``List`` or ``Dictionary``), then the read-only version is created via an appropriate constructor overload
- Support for tuples currently excludes the last type with 8 arguments (``TRest``)
- Support for annotating a constructor with ``[JsonConstructor]`` to use that one instead of assigning members during deserialization
- Support for custom serializers with ``[JsonCustomSerializer]`` to use that one instead of the normal formatter, see examples below
- Support for Base64 encoded byte arrays, see the Custom Resolvers example below
- Support for annotating a ``IDictionary<string,object>`` with ``[JsonExtensionData]``. Serialization will write all values from the dictionary as additional attributes. Deserialization will deserialize all unknown attributes into it.
  This does not work together with the Dynamic Language Runtime (DLR) support or the ``[JsonConstructor]`` attribute. See example below. The ``Dictionary`` will also honor the Case Setting (i.e. CamelCase) and ``null`` behaviour for the dictionary keys
- Pretty printing JSON
- Minify JSON
- Different 'Resolvers' to control general behaviour:
  - Exclude Nulls with Camel Case: ``ExcludeNullsCamelCaseResolver``
  - Exclude Nulls with Original Case (default): ``ExcludeNullsOriginalCaseResolver``
  - Include Nulls with Camel Case: ``IncludeNullsCamelCaseResolver``
  - Include Nulls with Original Case: ``IncludeNullsOriginalCaseResolver``
- Custom Resolvers to control behaviour how you desire


## How to use it ##
```csharp
// Synchronous API:
var result = JsonSerializer.Generic.Utf16.Serialize(input);
var result = JsonSerializer.NonGeneric.Utf16.Serialize(input);
var result = JsonSerializer.Generic.Utf16.Deserialize<Input>(input);
var result = JsonSerializer.NonGeneric.Utf16.Deserialize(input, typeof(Input));

var result = JsonSerializer.Generic.Utf8.Serialize(input);
var result = JsonSerializer.NonGeneric.Utf8.Serialize(input);
var result = JsonSerializer.Generic.Utf8.Deserialize<Input>(input);
var result = JsonSerializer.NonGeneric.Utf8.Deserialize(input, typeof(Input));

// The following methods return an ArraySegment from the ArrayPool, you NEED to return it yourself after working with it.
var result = JsonSerializer.Generic.Utf16.SerializeToArrayPool(input);
var result = JsonSerializer.NonGeneric.Utf16.SerializeToArrayPool(input);
var result = JsonSerializer.Generic.Utf8.SerializeToArrayPool(input);
var result = JsonSerializer.NonGeneric.Utf8.SerializeToArrayPool(input);

// Asynchronous API:
ValueTask result = JsonSerializer.Generic.Utf16.SerializeAsync(input, textWriter, cancellationToken);
ValueTask result = JsonSerializer.NonGeneric.Utf16.SerializeAsync(input, textWriter, cancellationToken);
ValueTask<Input> result = JsonSerializer.Generic.Utf16.DeserializeAsync<Input>(textReader,cancellationToken);
ValueTask<object> result = JsonSerializer.NonGeneric.Utf16.DeserializeAsync(textReader,typeof(Input),cancellationToken);
ValueTask result = JsonSerializer.Generic.Utf8.SerializeAsync(input, stream, cancellationToken);
ValueTask result = JsonSerializer.NonGeneric.Utf8.SerializeAsync(input, stream, cancellationToken);
ValueTask<Input> result = JsonSerializer.Generic.Utf8.DeserializeAsync<Input>(input, stream, cancellationToken);
ValueTask<object> result = JsonSerializer.NonGeneric.Utf8.DeserializeAsync(input, stream, typeof(Input) cancellationToken);

// To use other resolvers use the appropriate overloads,e.g.:
var serialized = JsonSerializer.NonGeneric.Utf16.Serialize<Input, IncludeNullsOriginalCaseResolver<char>>(includeNull);

// Pretty printing:
var pretty = JsonSerializer.PrettyPrinter.Print(serialized); // this works by reading the JSON and writing it out again with spaces and line breaks

// Minify:
var minified = JsonSerializer.Minifier.Minify(serialized); // this works by reading the JSON and writing it out again without spaces and line breaks
```

Full example:
```csharp
using System;
using SpanJson;

namespace Test
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var input = new Input { Text = "Hello World" };
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<Input>(serialized);
        }
    }

    public class Input
    {
        public string Text { get; set; }
    }
}
```

```csharp
using System;
using SpanJson;

namespace Test
{
    // This JsonConstructorAttribute assumes that the constructor parameter names are the same as the member names (case insensitive comparison, order is not important)
    public class DefaultDO
    {
        [JsonConstructor]
        public DefaultDO(string key, int value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; }
        public int Value { get; }
    }

    // This JsonConstructorAttribute allows overwriting the matching names of the constructor parameter names to allow for different member names vs. constructor parameter names, order is important here
    public readonly struct NamedDO
    {
        [JsonConstructor(nameof(Key), nameof(Value))]
        public NamedDO(string first, int second)
        {
            Key = first;
            Value = second;
        }

        public string Key { get; }
        public int Value { get; }
    }
}
```

```csharp
// Type with a custom serializer to (de)serialize the long value into/from string
public class TestDTO
{
    [JsonCustomSerializer(typeof(LongAsStringFormatter), "Hello World")]
    public long Value { get; set; }
}

// Serializes the Long into a string
public sealed class LongAsStringFormatter : ICustomJsonFormatter<long>
{
    public static readonly LongAsStringFormatter Default = new LongAsStringFormatter();

    public object Arguments { get; set; } // the Argument from the attribute will be assigned

    public void Serialize(ref JsonWriter<char> writer, long value)
    {
        StringUtf16Formatter.Default.Serialize(ref writer, value.ToString(CultureInfo.InvariantCulture));
    }

    public long Deserialize(ref JsonReader<char> reader)
    {
        var value = StringUtf16Formatter.Default.Deserialize(ref reader);
        if (long.TryParse(value, out long longValue))
        {
            return longValue;
        }

        throw new InvalidOperationException("Invalid value.");
    }

    public void Serialize(ref JsonWriter<byte> writer, long value)
    {
        StringUtf8Formatter.Default.Serialize(ref writer, value.ToString(CultureInfo.InvariantCulture));
    }

    public long Deserialize(ref JsonReader<byte> reader)
    {
        var value = StringUtf8Formatter.Default.Deserialize(ref reader);
        if (long.TryParse(value, out long longValue))
        {
            return longValue;
        }

        throw new InvalidOperationException("Invalid value.");
    }
}
```

```csharp
// It's possible to annotate custom types a custom formatter to always use the custom formatter
[JsonCustomSerializer(typeof(TwcsCustomSerializer))]
public class TypeWithCustomSerializer : IEquatable<TypeWithCustomSerializer>
{
    public long Value { get; set; }
}

// Instead of copying the implementation of for serialize/deserialize for utf8/utf16
// it is possible to use the writer/reader methods which support both, there is no or only a very minor performance difference
public sealed class TwcsCustomSerializer : ICustomJsonFormatter<TypeWithCustomSerializer>
{
    public static readonly TwcsCustomSerializer Default = new TwcsCustomSerializer();

    public object Arguments { get; set; }

    private void SerializeInternal<TSymbol>(ref JsonWriter<TSymbol> writer, TypeWithCustomSerializer value) where TSymbol : struct
    {
        if (value == null)
        {
            writer.WriteNull();
            return;
        }

        writer.WriteBeginObject();
        writer.WriteName(nameof(TypeWithCustomSerializer.Value));
        writer.WriteInt64(value.Value);
        writer.WriteEndObject();
    }

    public void Serialize(ref JsonWriter<byte> writer, TypeWithCustomSerializer value)
    {
        SerializeInternal(ref writer, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TypeWithCustomSerializer DeserializeInternal<TSymbol>(ref JsonReader<TSymbol> reader) where TSymbol : struct
    {
        if (reader.ReadIsNull())
        {
            return null;
        }

        reader.ReadBeginObjectOrThrow();
        var result = new TypeWithCustomSerializer {Value = reader.ReadInt64()};
        reader.ReadEndObjectOrThrow();
        return result;
    }

    public TypeWithCustomSerializer Deserialize(ref JsonReader<byte> reader)
    {
        return DeserializeInternal(ref reader);
    }

    public void Serialize(ref JsonWriter<char> writer, TypeWithCustomSerializer value)
    {
        SerializeInternal(ref writer, value);
    }

    public TypeWithCustomSerializer Deserialize(ref JsonReader<char> reader)
    {
        return DeserializeInternal(ref reader);
    }
}
```

```csharp
// Below class will serialize Key and Value and any additional key-value-pair from the dictionary
public class ExtensionTest
{
    public string Key;
    public string Value;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalValues { get; set; }
}
```


## ASP.NET Core 6.0+ Formatter ##
You can enable ``SpanJson`` as the default JSON formatter in ASP.NET Core 6.0+ by using the NuGet package [SpanJson.AspNetCore.Formatter](https://www.nuget.org/packages/SpanJson.AspNetCore.Formatter).
To enable it, add one of the following extension methods to the ``AddMvc()`` call in ``ConfigureServices``
- ``AddSpanJson`` for a resolver with ASP.NET Core 6.0 defaults: IncludeNull, CamelCase, Integer Enums
- ``AddSpanJsonCustom`` for a custom resolver (one of the default resolvers or custom)

```csharp
// This method gets called by the runtime. Use this method to add services to the container.
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc().AddSpanJson();
}
```

``AddSpanJson`` is the closest in behaviour compared to the default JSON.NET formatter; this uses the ``AspNetCoreDefaultResolver`` type.
### **Note:** This clears the ``Formatter`` list; if you have other formatters (e.g. JSON Patch or XML) you need to readd them.

## Custom Resolver ##
As each option is a concrete class it is infeasible to supply concrete classes for each possible option combination.
To support a custom combination implement your own custom formatter resolvers.
```csharp
public sealed class CustomResolver<TSymbol> : ResolverBase<TSymbol, CustomResolver<TSymbol>> where TSymbol : struct
{
    public CustomResolver() : base(new SpanJsonOptions
    {
        NullOption = NullOptions.ExcludeNulls,
        NamingConvention = NamingConventions.CamelCase,
        EnumOption = EnumOptions.Integer,
        ByteArrayOptions = ByteArrayOptions.Base64
    })
    {
    }
}
```
and pass this type just the same as e.g. ``ExcludeNullsCamelCaseResolver``


## TODO ##
- Improve async deserialization/serialization: Find a way to do it streaming instead of buffering.
