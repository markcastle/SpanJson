﻿using System.Threading;
using System.Threading.Tasks;

namespace SpanJson
{
    public interface IJsonFormatter
    {
    }

    public interface ICustomJsonFormatter
    {
        object Arguments { get; set; }
    }

    public interface ICustomJsonFormatter<T> : IJsonFormatter<T, byte>, IJsonFormatter<T, char>, ICustomJsonFormatter
    {
    }

    public interface IJsonFormatter<T, TSymbol> : IJsonFormatter where TSymbol : struct
    {
        void Serialize(ref JsonWriter<TSymbol> writer, T value);
        T Deserialize(ref JsonReader<TSymbol> reader);
    }


    public interface IAsyncJsonFormatter<T, TSymbol> : IJsonFormatter<T, TSymbol> where TSymbol : struct
    {
        Task SerializeAsync(AsyncJsonWriter<TSymbol> asyncWriter, T value, CancellationToken cancellationToken = default);
        Task<T> DeserializeAsync(AsyncJsonReader<TSymbol> asyncReader, CancellationToken cancellationToken = default);
    }
}