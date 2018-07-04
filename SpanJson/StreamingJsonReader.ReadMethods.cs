﻿// Autogenerated
// ReSharper disable BuiltInTypeReferenceStyle
// ReSharper disable ImpureMethodCallOnReadonlyValueField
using System.Runtime.CompilerServices;
using System;
namespace SpanJson
{
	public ref partial struct StreamingJsonReader<TSymbol> where TSymbol : struct
	{

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public SByte ReadUtf8SByte()
      {	       
		  return _jsonReader.ReadUtf8SByte();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public SByte ReadUtf16SByte()
      {	       
		  return _jsonReader.ReadUtf16SByte();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public SByte ReadSByte()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16SByte();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8SByte();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Int16 ReadUtf8Int16()
      {	       
		  return _jsonReader.ReadUtf8Int16();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Int16 ReadUtf16Int16()
      {	       
		  return _jsonReader.ReadUtf16Int16();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Int16 ReadInt16()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16Int16();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8Int16();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Int32 ReadUtf8Int32()
      {	       
		  return _jsonReader.ReadUtf8Int32();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Int32 ReadUtf16Int32()
      {	       
		  return _jsonReader.ReadUtf16Int32();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Int32 ReadInt32()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16Int32();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8Int32();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Int64 ReadUtf8Int64()
      {	       
		  return _jsonReader.ReadUtf8Int64();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Int64 ReadUtf16Int64()
      {	       
		  return _jsonReader.ReadUtf16Int64();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Int64 ReadInt64()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16Int64();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8Int64();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Byte ReadUtf8Byte()
      {	       
		  return _jsonReader.ReadUtf8Byte();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Byte ReadUtf16Byte()
      {	       
		  return _jsonReader.ReadUtf16Byte();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Byte ReadByte()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16Byte();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8Byte();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public UInt16 ReadUtf8UInt16()
      {	       
		  return _jsonReader.ReadUtf8UInt16();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public UInt16 ReadUtf16UInt16()
      {	       
		  return _jsonReader.ReadUtf16UInt16();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public UInt16 ReadUInt16()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16UInt16();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8UInt16();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public UInt32 ReadUtf8UInt32()
      {	       
		  return _jsonReader.ReadUtf8UInt32();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public UInt32 ReadUtf16UInt32()
      {	       
		  return _jsonReader.ReadUtf16UInt32();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public UInt32 ReadUInt32()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16UInt32();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8UInt32();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public UInt64 ReadUtf8UInt64()
      {	       
		  return _jsonReader.ReadUtf8UInt64();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public UInt64 ReadUtf16UInt64()
      {	       
		  return _jsonReader.ReadUtf16UInt64();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public UInt64 ReadUInt64()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16UInt64();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8UInt64();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Single ReadUtf8Single()
      {	       
		  return _jsonReader.ReadUtf8Single();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Single ReadUtf16Single()
      {	       
		  return _jsonReader.ReadUtf16Single();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Single ReadSingle()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16Single();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8Single();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Double ReadUtf8Double()
      {	       
		  return _jsonReader.ReadUtf8Double();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Double ReadUtf16Double()
      {	       
		  return _jsonReader.ReadUtf16Double();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Double ReadDouble()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16Double();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8Double();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Decimal ReadUtf8Decimal()
      {	       
		  return _jsonReader.ReadUtf8Decimal();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Decimal ReadUtf16Decimal()
      {	       
		  return _jsonReader.ReadUtf16Decimal();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Decimal ReadDecimal()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16Decimal();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8Decimal();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Boolean ReadUtf8Boolean()
      {	       
		  return _jsonReader.ReadUtf8Boolean();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Boolean ReadUtf16Boolean()
      {	       
		  return _jsonReader.ReadUtf16Boolean();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Boolean ReadBoolean()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16Boolean();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8Boolean();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Char ReadUtf8Char()
      {	       
		  return _jsonReader.ReadUtf8Char();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Char ReadUtf16Char()
      {	       
		  return _jsonReader.ReadUtf16Char();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Char ReadChar()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16Char();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8Char();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public DateTime ReadUtf8DateTime()
      {	       
		  return _jsonReader.ReadUtf8DateTime();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public DateTime ReadUtf16DateTime()
      {	       
		  return _jsonReader.ReadUtf16DateTime();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public DateTime ReadDateTime()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16DateTime();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8DateTime();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public DateTimeOffset ReadUtf8DateTimeOffset()
      {	       
		  return _jsonReader.ReadUtf8DateTimeOffset();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public DateTimeOffset ReadUtf16DateTimeOffset()
      {	       
		  return _jsonReader.ReadUtf16DateTimeOffset();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public DateTimeOffset ReadDateTimeOffset()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16DateTimeOffset();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8DateTimeOffset();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public TimeSpan ReadUtf8TimeSpan()
      {	       
		  return _jsonReader.ReadUtf8TimeSpan();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public TimeSpan ReadUtf16TimeSpan()
      {	       
		  return _jsonReader.ReadUtf16TimeSpan();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public TimeSpan ReadTimeSpan()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16TimeSpan();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8TimeSpan();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Guid ReadUtf8Guid()
      {	       
		  return _jsonReader.ReadUtf8Guid();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Guid ReadUtf16Guid()
      {	       
		  return _jsonReader.ReadUtf16Guid();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Guid ReadGuid()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16Guid();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8Guid();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Version ReadUtf8Version()
      {	       
		  return _jsonReader.ReadUtf8Version();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Version ReadUtf16Version()
      {	       
		  return _jsonReader.ReadUtf16Version();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Version ReadVersion()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16Version();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8Version();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Uri ReadUtf8Uri()
      {	       
		  return _jsonReader.ReadUtf8Uri();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Uri ReadUtf16Uri()
      {	       
		  return _jsonReader.ReadUtf16Uri();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public Uri ReadUri()
      {
          if (typeof(TSymbol) == typeof(char))
          {
              return _jsonReader.ReadUtf16Uri();
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
              return _jsonReader.ReadUtf8Uri();
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public void ReadUtf8BeginObjectOrThrow(  )
      {	       
		   _jsonReader.ReadUtf8BeginObjectOrThrow( );
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public void ReadUtf16BeginObjectOrThrow(  )
      {	       
		   _jsonReader.ReadUtf16BeginObjectOrThrow( );
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public void ReadBeginObjectOrThrow(  )
      {
          if (typeof(TSymbol) == typeof(char))
          {
		       _jsonReader.ReadUtf16BeginObjectOrThrow( );
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
		       _jsonReader.ReadUtf8BeginObjectOrThrow( );
          }

          ThrowNotSupportedException();
          
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public void ReadUtf8BeginArrayOrThrow(  )
      {	       
		   _jsonReader.ReadUtf8BeginArrayOrThrow( );
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public void ReadUtf16BeginArrayOrThrow(  )
      {	       
		   _jsonReader.ReadUtf16BeginArrayOrThrow( );
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public void ReadBeginArrayOrThrow(  )
      {
          if (typeof(TSymbol) == typeof(char))
          {
		       _jsonReader.ReadUtf16BeginArrayOrThrow( );
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
		       _jsonReader.ReadUtf8BeginArrayOrThrow( );
          }

          ThrowNotSupportedException();
          
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool ReadUtf8IsNull(  )
      {	       
		  return _jsonReader.ReadUtf8IsNull( );
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool ReadUtf16IsNull(  )
      {	       
		  return _jsonReader.ReadUtf16IsNull( );
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool ReadIsNull(  )
      {
          if (typeof(TSymbol) == typeof(char))
          {
		      return _jsonReader.ReadUtf16IsNull( );
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
		      return _jsonReader.ReadUtf8IsNull( );
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool TryReadUtf8IsEndArrayOrValueSeparator(ref int count)
      {	       
		  return _jsonReader.TryReadUtf8IsEndArrayOrValueSeparator(ref count);
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool TryReadUtf16IsEndArrayOrValueSeparator(ref int count)
      {	       
		  return _jsonReader.TryReadUtf16IsEndArrayOrValueSeparator(ref count);
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool TryReadIsEndArrayOrValueSeparator(ref int count)
      {
          if (typeof(TSymbol) == typeof(char))
          {
		      return _jsonReader.TryReadUtf16IsEndArrayOrValueSeparator(ref count);
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
		      return _jsonReader.TryReadUtf8IsEndArrayOrValueSeparator(ref count);
          }

          ThrowNotSupportedException();
          return default;
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool TryReadUtf8IsEndObjectOrValueSeparator(ref int count)
      {	       
		  return _jsonReader.TryReadUtf8IsEndObjectOrValueSeparator(ref count);
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool TryReadUtf16IsEndObjectOrValueSeparator(ref int count)
      {	       
		  return _jsonReader.TryReadUtf16IsEndObjectOrValueSeparator(ref count);
      }
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool TryReadIsEndObjectOrValueSeparator(ref int count)
      {
          if (typeof(TSymbol) == typeof(char))
          {
		      return _jsonReader.TryReadUtf16IsEndObjectOrValueSeparator(ref count);
          }
		  
		  if (typeof(TSymbol) == typeof(byte))
          {
		      return _jsonReader.TryReadUtf8IsEndObjectOrValueSeparator(ref count);
          }

          ThrowNotSupportedException();
          return default;
      }
  }
}