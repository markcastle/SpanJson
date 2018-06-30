﻿  
  
  
  
  
  
  
 
using System;
using BenchmarkDotNet.Attributes;
using SpanJson.Benchmarks.Serializers;
using SpanJson.Shared.Fixture;
namespace SpanJson.Benchmarks
{  
  // Autogenerated
  // ReSharper disable BuiltInTypeReferenceStyle
  [Config(typeof(MyConfig))]
  public class BclBenchmark
  {
	private static readonly ExpressionTreeFixture ExpressionTreeFixture = new ExpressionTreeFixture();
  
	private static readonly JilSerializer JilSerializer = new JilSerializer();
  
	private static readonly SpanJsonSerializer SpanJsonSerializer = new SpanJsonSerializer();
  
	private static readonly SpanJsonUtf8Serializer SpanJsonUtf8Serializer = new SpanJsonUtf8Serializer();
  
	private static readonly Utf8JsonSerializer Utf8JsonSerializer = new Utf8JsonSerializer();
  
  
	private static readonly SByte SByteInput = ExpressionTreeFixture.Create<SByte>();
  
	private static readonly Int16 Int16Input = ExpressionTreeFixture.Create<Int16>();
  
	private static readonly Int32 Int32Input = ExpressionTreeFixture.Create<Int32>();
  
	private static readonly Int64 Int64Input = ExpressionTreeFixture.Create<Int64>();
  
	private static readonly Byte ByteInput = ExpressionTreeFixture.Create<Byte>();
  
	private static readonly UInt16 UInt16Input = ExpressionTreeFixture.Create<UInt16>();
  
	private static readonly UInt32 UInt32Input = ExpressionTreeFixture.Create<UInt32>();
  
	private static readonly UInt64 UInt64Input = ExpressionTreeFixture.Create<UInt64>();
  
	private static readonly Single SingleInput = ExpressionTreeFixture.Create<Single>();
  
	private static readonly Double DoubleInput = ExpressionTreeFixture.Create<Double>();
  
	private static readonly Boolean BooleanInput = ExpressionTreeFixture.Create<Boolean>();
  
	private static readonly Char CharInput = ExpressionTreeFixture.Create<Char>();
  
	private static readonly DateTime DateTimeInput = ExpressionTreeFixture.Create<DateTime>();
  
	private static readonly DateTimeOffset DateTimeOffsetInput = ExpressionTreeFixture.Create<DateTimeOffset>();
  
	private static readonly TimeSpan TimeSpanInput = ExpressionTreeFixture.Create<TimeSpan>();
  
	private static readonly Guid GuidInput = ExpressionTreeFixture.Create<Guid>();
  
	private static readonly String StringInput = ExpressionTreeFixture.Create<String>();
  
	private static readonly Decimal DecimalInput = ExpressionTreeFixture.Create<Decimal>();
  
	private static readonly Version VersionInput = ExpressionTreeFixture.Create<Version>();
  
	private static readonly Uri UriInput = ExpressionTreeFixture.Create<Uri>();
  
  

	[Benchmark]
	public String SerializeSByteWithJilSerializer()
	{
		return JilSerializer.Serialize(SByteInput);
	}	
  

	[Benchmark]
	public String SerializeSByteWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(SByteInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeSByteWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(SByteInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeSByteWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(SByteInput);
	}	
  

	[Benchmark]
	public String SerializeInt16WithJilSerializer()
	{
		return JilSerializer.Serialize(Int16Input);
	}	
  

	[Benchmark]
	public String SerializeInt16WithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(Int16Input);
	}	
  

	[Benchmark]
	public Byte[] SerializeInt16WithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(Int16Input);
	}	
  

	[Benchmark]
	public Byte[] SerializeInt16WithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(Int16Input);
	}	
  

	[Benchmark]
	public String SerializeInt32WithJilSerializer()
	{
		return JilSerializer.Serialize(Int32Input);
	}	
  

	[Benchmark]
	public String SerializeInt32WithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(Int32Input);
	}	
  

	[Benchmark]
	public Byte[] SerializeInt32WithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(Int32Input);
	}	
  

	[Benchmark]
	public Byte[] SerializeInt32WithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(Int32Input);
	}	
  

	[Benchmark]
	public String SerializeInt64WithJilSerializer()
	{
		return JilSerializer.Serialize(Int64Input);
	}	
  

	[Benchmark]
	public String SerializeInt64WithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(Int64Input);
	}	
  

	[Benchmark]
	public Byte[] SerializeInt64WithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(Int64Input);
	}	
  

	[Benchmark]
	public Byte[] SerializeInt64WithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(Int64Input);
	}	
  

	[Benchmark]
	public String SerializeByteWithJilSerializer()
	{
		return JilSerializer.Serialize(ByteInput);
	}	
  

	[Benchmark]
	public String SerializeByteWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(ByteInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeByteWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(ByteInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeByteWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(ByteInput);
	}	
  

	[Benchmark]
	public String SerializeUInt16WithJilSerializer()
	{
		return JilSerializer.Serialize(UInt16Input);
	}	
  

	[Benchmark]
	public String SerializeUInt16WithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(UInt16Input);
	}	
  

	[Benchmark]
	public Byte[] SerializeUInt16WithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(UInt16Input);
	}	
  

	[Benchmark]
	public Byte[] SerializeUInt16WithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(UInt16Input);
	}	
  

	[Benchmark]
	public String SerializeUInt32WithJilSerializer()
	{
		return JilSerializer.Serialize(UInt32Input);
	}	
  

	[Benchmark]
	public String SerializeUInt32WithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(UInt32Input);
	}	
  

	[Benchmark]
	public Byte[] SerializeUInt32WithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(UInt32Input);
	}	
  

	[Benchmark]
	public Byte[] SerializeUInt32WithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(UInt32Input);
	}	
  

	[Benchmark]
	public String SerializeUInt64WithJilSerializer()
	{
		return JilSerializer.Serialize(UInt64Input);
	}	
  

	[Benchmark]
	public String SerializeUInt64WithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(UInt64Input);
	}	
  

	[Benchmark]
	public Byte[] SerializeUInt64WithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(UInt64Input);
	}	
  

	[Benchmark]
	public Byte[] SerializeUInt64WithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(UInt64Input);
	}	
  

	[Benchmark]
	public String SerializeSingleWithJilSerializer()
	{
		return JilSerializer.Serialize(SingleInput);
	}	
  

	[Benchmark]
	public String SerializeSingleWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(SingleInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeSingleWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(SingleInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeSingleWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(SingleInput);
	}	
  

	[Benchmark]
	public String SerializeDoubleWithJilSerializer()
	{
		return JilSerializer.Serialize(DoubleInput);
	}	
  

	[Benchmark]
	public String SerializeDoubleWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(DoubleInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeDoubleWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(DoubleInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeDoubleWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(DoubleInput);
	}	
  

	[Benchmark]
	public String SerializeBooleanWithJilSerializer()
	{
		return JilSerializer.Serialize(BooleanInput);
	}	
  

	[Benchmark]
	public String SerializeBooleanWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(BooleanInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeBooleanWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(BooleanInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeBooleanWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(BooleanInput);
	}	
  

	[Benchmark]
	public String SerializeCharWithJilSerializer()
	{
		return JilSerializer.Serialize(CharInput);
	}	
  

	[Benchmark]
	public String SerializeCharWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(CharInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeCharWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(CharInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeCharWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(CharInput);
	}	
  

	[Benchmark]
	public String SerializeDateTimeWithJilSerializer()
	{
		return JilSerializer.Serialize(DateTimeInput);
	}	
  

	[Benchmark]
	public String SerializeDateTimeWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(DateTimeInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeDateTimeWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(DateTimeInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeDateTimeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(DateTimeInput);
	}	
  

	[Benchmark]
	public String SerializeDateTimeOffsetWithJilSerializer()
	{
		return JilSerializer.Serialize(DateTimeOffsetInput);
	}	
  

	[Benchmark]
	public String SerializeDateTimeOffsetWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(DateTimeOffsetInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeDateTimeOffsetWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(DateTimeOffsetInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeDateTimeOffsetWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(DateTimeOffsetInput);
	}	
  

	[Benchmark]
	public String SerializeTimeSpanWithJilSerializer()
	{
		return JilSerializer.Serialize(TimeSpanInput);
	}	
  

	[Benchmark]
	public String SerializeTimeSpanWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(TimeSpanInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeTimeSpanWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(TimeSpanInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeTimeSpanWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(TimeSpanInput);
	}	
  

	[Benchmark]
	public String SerializeGuidWithJilSerializer()
	{
		return JilSerializer.Serialize(GuidInput);
	}	
  

	[Benchmark]
	public String SerializeGuidWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(GuidInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeGuidWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(GuidInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeGuidWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(GuidInput);
	}	
  

	[Benchmark]
	public String SerializeStringWithJilSerializer()
	{
		return JilSerializer.Serialize(StringInput);
	}	
  

	[Benchmark]
	public String SerializeStringWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(StringInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeStringWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(StringInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeStringWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(StringInput);
	}	
  

	[Benchmark]
	public String SerializeDecimalWithJilSerializer()
	{
		return JilSerializer.Serialize(DecimalInput);
	}	
  

	[Benchmark]
	public String SerializeDecimalWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(DecimalInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeDecimalWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(DecimalInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeDecimalWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(DecimalInput);
	}	
  

	[Benchmark]
	public String SerializeVersionWithJilSerializer()
	{
		return JilSerializer.Serialize(VersionInput);
	}	
  

	[Benchmark]
	public String SerializeVersionWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(VersionInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeVersionWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(VersionInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeVersionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(VersionInput);
	}	
  

	[Benchmark]
	public String SerializeUriWithJilSerializer()
	{
		return JilSerializer.Serialize(UriInput);
	}	
  

	[Benchmark]
	public String SerializeUriWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Serialize(UriInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeUriWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Serialize(UriInput);
	}	
  

	[Benchmark]
	public Byte[] SerializeUriWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(UriInput);
	}	
 
  
	private static readonly String SByteOutputOfJilSerializer = JilSerializer.Serialize(SByteInput);
	[Benchmark]
	public SByte DeserializeSByteWithJilSerializer()
	{
		return JilSerializer.Deserialize<SByte>(SByteOutputOfJilSerializer);
	}
  
	private static readonly String SByteOutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(SByteInput);
	[Benchmark]
	public SByte DeserializeSByteWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<SByte>(SByteOutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] SByteOutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(SByteInput);
	[Benchmark]
	public SByte DeserializeSByteWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<SByte>(SByteOutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] SByteOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(SByteInput);
	[Benchmark]
	public SByte DeserializeSByteWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<SByte>(SByteOutputOfUtf8JsonSerializer);
	}
  
	private static readonly String Int16OutputOfJilSerializer = JilSerializer.Serialize(Int16Input);
	[Benchmark]
	public Int16 DeserializeInt16WithJilSerializer()
	{
		return JilSerializer.Deserialize<Int16>(Int16OutputOfJilSerializer);
	}
  
	private static readonly String Int16OutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(Int16Input);
	[Benchmark]
	public Int16 DeserializeInt16WithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<Int16>(Int16OutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] Int16OutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(Int16Input);
	[Benchmark]
	public Int16 DeserializeInt16WithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<Int16>(Int16OutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] Int16OutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(Int16Input);
	[Benchmark]
	public Int16 DeserializeInt16WithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Int16>(Int16OutputOfUtf8JsonSerializer);
	}
  
	private static readonly String Int32OutputOfJilSerializer = JilSerializer.Serialize(Int32Input);
	[Benchmark]
	public Int32 DeserializeInt32WithJilSerializer()
	{
		return JilSerializer.Deserialize<Int32>(Int32OutputOfJilSerializer);
	}
  
	private static readonly String Int32OutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(Int32Input);
	[Benchmark]
	public Int32 DeserializeInt32WithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<Int32>(Int32OutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] Int32OutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(Int32Input);
	[Benchmark]
	public Int32 DeserializeInt32WithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<Int32>(Int32OutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] Int32OutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(Int32Input);
	[Benchmark]
	public Int32 DeserializeInt32WithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Int32>(Int32OutputOfUtf8JsonSerializer);
	}
  
	private static readonly String Int64OutputOfJilSerializer = JilSerializer.Serialize(Int64Input);
	[Benchmark]
	public Int64 DeserializeInt64WithJilSerializer()
	{
		return JilSerializer.Deserialize<Int64>(Int64OutputOfJilSerializer);
	}
  
	private static readonly String Int64OutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(Int64Input);
	[Benchmark]
	public Int64 DeserializeInt64WithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<Int64>(Int64OutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] Int64OutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(Int64Input);
	[Benchmark]
	public Int64 DeserializeInt64WithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<Int64>(Int64OutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] Int64OutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(Int64Input);
	[Benchmark]
	public Int64 DeserializeInt64WithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Int64>(Int64OutputOfUtf8JsonSerializer);
	}
  
	private static readonly String ByteOutputOfJilSerializer = JilSerializer.Serialize(ByteInput);
	[Benchmark]
	public Byte DeserializeByteWithJilSerializer()
	{
		return JilSerializer.Deserialize<Byte>(ByteOutputOfJilSerializer);
	}
  
	private static readonly String ByteOutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(ByteInput);
	[Benchmark]
	public Byte DeserializeByteWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<Byte>(ByteOutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] ByteOutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(ByteInput);
	[Benchmark]
	public Byte DeserializeByteWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<Byte>(ByteOutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] ByteOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(ByteInput);
	[Benchmark]
	public Byte DeserializeByteWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Byte>(ByteOutputOfUtf8JsonSerializer);
	}
  
	private static readonly String UInt16OutputOfJilSerializer = JilSerializer.Serialize(UInt16Input);
	[Benchmark]
	public UInt16 DeserializeUInt16WithJilSerializer()
	{
		return JilSerializer.Deserialize<UInt16>(UInt16OutputOfJilSerializer);
	}
  
	private static readonly String UInt16OutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(UInt16Input);
	[Benchmark]
	public UInt16 DeserializeUInt16WithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<UInt16>(UInt16OutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] UInt16OutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(UInt16Input);
	[Benchmark]
	public UInt16 DeserializeUInt16WithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<UInt16>(UInt16OutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] UInt16OutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(UInt16Input);
	[Benchmark]
	public UInt16 DeserializeUInt16WithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<UInt16>(UInt16OutputOfUtf8JsonSerializer);
	}
  
	private static readonly String UInt32OutputOfJilSerializer = JilSerializer.Serialize(UInt32Input);
	[Benchmark]
	public UInt32 DeserializeUInt32WithJilSerializer()
	{
		return JilSerializer.Deserialize<UInt32>(UInt32OutputOfJilSerializer);
	}
  
	private static readonly String UInt32OutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(UInt32Input);
	[Benchmark]
	public UInt32 DeserializeUInt32WithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<UInt32>(UInt32OutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] UInt32OutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(UInt32Input);
	[Benchmark]
	public UInt32 DeserializeUInt32WithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<UInt32>(UInt32OutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] UInt32OutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(UInt32Input);
	[Benchmark]
	public UInt32 DeserializeUInt32WithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<UInt32>(UInt32OutputOfUtf8JsonSerializer);
	}
  
	private static readonly String UInt64OutputOfJilSerializer = JilSerializer.Serialize(UInt64Input);
	[Benchmark]
	public UInt64 DeserializeUInt64WithJilSerializer()
	{
		return JilSerializer.Deserialize<UInt64>(UInt64OutputOfJilSerializer);
	}
  
	private static readonly String UInt64OutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(UInt64Input);
	[Benchmark]
	public UInt64 DeserializeUInt64WithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<UInt64>(UInt64OutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] UInt64OutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(UInt64Input);
	[Benchmark]
	public UInt64 DeserializeUInt64WithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<UInt64>(UInt64OutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] UInt64OutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(UInt64Input);
	[Benchmark]
	public UInt64 DeserializeUInt64WithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<UInt64>(UInt64OutputOfUtf8JsonSerializer);
	}
  
	private static readonly String SingleOutputOfJilSerializer = JilSerializer.Serialize(SingleInput);
	[Benchmark]
	public Single DeserializeSingleWithJilSerializer()
	{
		return JilSerializer.Deserialize<Single>(SingleOutputOfJilSerializer);
	}
  
	private static readonly String SingleOutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(SingleInput);
	[Benchmark]
	public Single DeserializeSingleWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<Single>(SingleOutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] SingleOutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(SingleInput);
	[Benchmark]
	public Single DeserializeSingleWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<Single>(SingleOutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] SingleOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(SingleInput);
	[Benchmark]
	public Single DeserializeSingleWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Single>(SingleOutputOfUtf8JsonSerializer);
	}
  
	private static readonly String DoubleOutputOfJilSerializer = JilSerializer.Serialize(DoubleInput);
	[Benchmark]
	public Double DeserializeDoubleWithJilSerializer()
	{
		return JilSerializer.Deserialize<Double>(DoubleOutputOfJilSerializer);
	}
  
	private static readonly String DoubleOutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(DoubleInput);
	[Benchmark]
	public Double DeserializeDoubleWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<Double>(DoubleOutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] DoubleOutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(DoubleInput);
	[Benchmark]
	public Double DeserializeDoubleWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<Double>(DoubleOutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] DoubleOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(DoubleInput);
	[Benchmark]
	public Double DeserializeDoubleWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Double>(DoubleOutputOfUtf8JsonSerializer);
	}
  
	private static readonly String BooleanOutputOfJilSerializer = JilSerializer.Serialize(BooleanInput);
	[Benchmark]
	public Boolean DeserializeBooleanWithJilSerializer()
	{
		return JilSerializer.Deserialize<Boolean>(BooleanOutputOfJilSerializer);
	}
  
	private static readonly String BooleanOutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(BooleanInput);
	[Benchmark]
	public Boolean DeserializeBooleanWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<Boolean>(BooleanOutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] BooleanOutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(BooleanInput);
	[Benchmark]
	public Boolean DeserializeBooleanWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<Boolean>(BooleanOutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] BooleanOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(BooleanInput);
	[Benchmark]
	public Boolean DeserializeBooleanWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Boolean>(BooleanOutputOfUtf8JsonSerializer);
	}
  
	private static readonly String CharOutputOfJilSerializer = JilSerializer.Serialize(CharInput);
	[Benchmark]
	public Char DeserializeCharWithJilSerializer()
	{
		return JilSerializer.Deserialize<Char>(CharOutputOfJilSerializer);
	}
  
	private static readonly String CharOutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(CharInput);
	[Benchmark]
	public Char DeserializeCharWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<Char>(CharOutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] CharOutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(CharInput);
	[Benchmark]
	public Char DeserializeCharWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<Char>(CharOutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] CharOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(CharInput);
	[Benchmark]
	public Char DeserializeCharWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Char>(CharOutputOfUtf8JsonSerializer);
	}
  
	private static readonly String DateTimeOutputOfJilSerializer = JilSerializer.Serialize(DateTimeInput);
	[Benchmark]
	public DateTime DeserializeDateTimeWithJilSerializer()
	{
		return JilSerializer.Deserialize<DateTime>(DateTimeOutputOfJilSerializer);
	}
  
	private static readonly String DateTimeOutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(DateTimeInput);
	[Benchmark]
	public DateTime DeserializeDateTimeWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<DateTime>(DateTimeOutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] DateTimeOutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(DateTimeInput);
	[Benchmark]
	public DateTime DeserializeDateTimeWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<DateTime>(DateTimeOutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] DateTimeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(DateTimeInput);
	[Benchmark]
	public DateTime DeserializeDateTimeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<DateTime>(DateTimeOutputOfUtf8JsonSerializer);
	}
  
	private static readonly String DateTimeOffsetOutputOfJilSerializer = JilSerializer.Serialize(DateTimeOffsetInput);
	[Benchmark]
	public DateTimeOffset DeserializeDateTimeOffsetWithJilSerializer()
	{
		return JilSerializer.Deserialize<DateTimeOffset>(DateTimeOffsetOutputOfJilSerializer);
	}
  
	private static readonly String DateTimeOffsetOutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(DateTimeOffsetInput);
	[Benchmark]
	public DateTimeOffset DeserializeDateTimeOffsetWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<DateTimeOffset>(DateTimeOffsetOutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] DateTimeOffsetOutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(DateTimeOffsetInput);
	[Benchmark]
	public DateTimeOffset DeserializeDateTimeOffsetWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<DateTimeOffset>(DateTimeOffsetOutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] DateTimeOffsetOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(DateTimeOffsetInput);
	[Benchmark]
	public DateTimeOffset DeserializeDateTimeOffsetWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<DateTimeOffset>(DateTimeOffsetOutputOfUtf8JsonSerializer);
	}
  
	private static readonly String TimeSpanOutputOfJilSerializer = JilSerializer.Serialize(TimeSpanInput);
	[Benchmark]
	public TimeSpan DeserializeTimeSpanWithJilSerializer()
	{
		return JilSerializer.Deserialize<TimeSpan>(TimeSpanOutputOfJilSerializer);
	}
  
	private static readonly String TimeSpanOutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(TimeSpanInput);
	[Benchmark]
	public TimeSpan DeserializeTimeSpanWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<TimeSpan>(TimeSpanOutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] TimeSpanOutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(TimeSpanInput);
	[Benchmark]
	public TimeSpan DeserializeTimeSpanWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<TimeSpan>(TimeSpanOutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] TimeSpanOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(TimeSpanInput);
	[Benchmark]
	public TimeSpan DeserializeTimeSpanWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<TimeSpan>(TimeSpanOutputOfUtf8JsonSerializer);
	}
  
	private static readonly String GuidOutputOfJilSerializer = JilSerializer.Serialize(GuidInput);
	[Benchmark]
	public Guid DeserializeGuidWithJilSerializer()
	{
		return JilSerializer.Deserialize<Guid>(GuidOutputOfJilSerializer);
	}
  
	private static readonly String GuidOutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(GuidInput);
	[Benchmark]
	public Guid DeserializeGuidWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<Guid>(GuidOutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] GuidOutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(GuidInput);
	[Benchmark]
	public Guid DeserializeGuidWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<Guid>(GuidOutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] GuidOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(GuidInput);
	[Benchmark]
	public Guid DeserializeGuidWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Guid>(GuidOutputOfUtf8JsonSerializer);
	}
  
	private static readonly String StringOutputOfJilSerializer = JilSerializer.Serialize(StringInput);
	[Benchmark]
	public String DeserializeStringWithJilSerializer()
	{
		return JilSerializer.Deserialize<String>(StringOutputOfJilSerializer);
	}
  
	private static readonly String StringOutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(StringInput);
	[Benchmark]
	public String DeserializeStringWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<String>(StringOutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] StringOutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(StringInput);
	[Benchmark]
	public String DeserializeStringWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<String>(StringOutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] StringOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(StringInput);
	[Benchmark]
	public String DeserializeStringWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<String>(StringOutputOfUtf8JsonSerializer);
	}
  
	private static readonly String DecimalOutputOfJilSerializer = JilSerializer.Serialize(DecimalInput);
	[Benchmark]
	public Decimal DeserializeDecimalWithJilSerializer()
	{
		return JilSerializer.Deserialize<Decimal>(DecimalOutputOfJilSerializer);
	}
  
	private static readonly String DecimalOutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(DecimalInput);
	[Benchmark]
	public Decimal DeserializeDecimalWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<Decimal>(DecimalOutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] DecimalOutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(DecimalInput);
	[Benchmark]
	public Decimal DeserializeDecimalWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<Decimal>(DecimalOutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] DecimalOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(DecimalInput);
	[Benchmark]
	public Decimal DeserializeDecimalWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Decimal>(DecimalOutputOfUtf8JsonSerializer);
	}
  
	private static readonly String VersionOutputOfJilSerializer = JilSerializer.Serialize(VersionInput);
	[Benchmark]
	public Version DeserializeVersionWithJilSerializer()
	{
		return JilSerializer.Deserialize<Version>(VersionOutputOfJilSerializer);
	}
  
	private static readonly String VersionOutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(VersionInput);
	[Benchmark]
	public Version DeserializeVersionWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<Version>(VersionOutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] VersionOutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(VersionInput);
	[Benchmark]
	public Version DeserializeVersionWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<Version>(VersionOutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] VersionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(VersionInput);
	[Benchmark]
	public Version DeserializeVersionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Version>(VersionOutputOfUtf8JsonSerializer);
	}
  
	private static readonly String UriOutputOfJilSerializer = JilSerializer.Serialize(UriInput);
	[Benchmark]
	public Uri DeserializeUriWithJilSerializer()
	{
		return JilSerializer.Deserialize<Uri>(UriOutputOfJilSerializer);
	}
  
	private static readonly String UriOutputOfSpanJsonSerializer = SpanJsonSerializer.Serialize(UriInput);
	[Benchmark]
	public Uri DeserializeUriWithSpanJsonSerializer()
	{
		return SpanJsonSerializer.Deserialize<Uri>(UriOutputOfSpanJsonSerializer);
	}
  
	private static readonly Byte[] UriOutputOfSpanJsonUtf8Serializer = SpanJsonUtf8Serializer.Serialize(UriInput);
	[Benchmark]
	public Uri DeserializeUriWithSpanJsonUtf8Serializer()
	{
		return SpanJsonUtf8Serializer.Deserialize<Uri>(UriOutputOfSpanJsonUtf8Serializer);
	}
  
	private static readonly Byte[] UriOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(UriInput);
	[Benchmark]
	public Uri DeserializeUriWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Uri>(UriOutputOfUtf8JsonSerializer);
	}
 
  }
}
  