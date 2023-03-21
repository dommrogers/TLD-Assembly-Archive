using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using ExampleNS;
using UnityEngine;

public static class FastJson
{
	public enum EnumSerializationMethod
	{
		Name,
		UnderlyingValue
	}

	public delegate void Serializer(StringBuilder sb, object obj);

	public delegate object Deserializer(Type type, JsonParser parser);

	private class FieldSerializer
	{
		public string nameAndColon;

		public FieldInfo fieldInfo;

		public Serializer serializer;

		[CallerCount(Count = 34)]
		[DeduplicatedMethod]
		public FieldSerializer(string nameAndColon, FieldInfo fieldInfo, Serializer serializer)
		{
		}
	}

	public class JsonParser
	{
		private int count;

		private readonly int textLength;

		private readonly string jsonText;

		private const int JSONPARSER_STRING_BUILDER_INITIAL_CAPACITY = 1048576;

		private static StringBuilder subStringBuilder;

		public bool End
		{
			[CallerCount(Count = 0)]
			get
			{
				return default(bool);
			}
		}

		[CalledBy(Type = typeof(FastJson), Member = "Deserialize")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 1)]
		public JsonParser(string jsonText)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public char Peek()
		{
			return default(char);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsUnknownMethods(Count = 1)]
		public char Read()
		{
			return default(char);
		}

		[CalledBy(Type = typeof(JsonParser), Member = "SkipValue")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeArray")]
		[CallsUnknownMethods(Count = 1)]
		public char PeekWithTrim()
		{
			return default(char);
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallerCount(Count = 0)]
		public char ReadWithTrim()
		{
			return default(char);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsUnknownMethods(Count = 1)]
		public void Trim()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(FastJson), Member = "IsJsonSeparator")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		private void _Skip()
		{
		}

		[Calls(Type = typeof(FastJson), Member = "IsJsonSeparator")]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "Substring")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 26)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		public string ReadToken()
		{
			return null;
		}

		[CallAnalysisFailed]
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(JsonParser), Member = "SkipValue")]
		public bool ReadIfNull()
		{
			return default(bool);
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeHashSet")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadString")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeObject")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeDictionary")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeList")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeArray")]
		private bool _ReadIfNull()
		{
			return default(bool);
		}

		[CallerCount(Count = 35)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "Substring")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 27)]
		public void ReadSpecifyChar(char spec)
		{
		}

		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeEnum")]
		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeObject")]
		[Calls(Type = typeof(FastJson), Member = "HexToInt")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeColor32")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeHash128")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeDate")]
		[CalledBy(Type = typeof(JsonParser), Member = "SkipValue")]
		[CallsUnknownMethods(Count = 22)]
		[Calls(Type = typeof(FastJson), Member = "HexToInt")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeString")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(FastJson), Member = "HexToInt")]
		[CallerCount(Count = 7)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
		[Calls(Type = typeof(JsonParser), Member = "_ReadIfNull")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(FastJson), Member = "HexToInt")]
		public string ReadString()
		{
			return null;
		}

		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "SkipValue")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "ReadString")]
		[CalledBy(Type = typeof(JsonParser), Member = "SkipValue")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeArray")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeObject")]
		[CalledBy(Type = typeof(JsonParser), Member = "SkipValue")]
		[CalledBy(Type = typeof(JsonParser), Member = "SkipValue")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsUnknownMethods(Count = 12)]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[Calls(Type = typeof(JsonParser), Member = "SkipValue")]
		[Calls(Type = typeof(JsonParser), Member = "ReadIfNull")]
		[Calls(Type = typeof(JsonParser), Member = "SkipValue")]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
		[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
		[Calls(Type = typeof(System.Number), Member = "TryParseDecimal")]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
		[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "PeekWithTrim")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
		public void SkipValue()
		{
		}

		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt64")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt16")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt32")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt8")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt8")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt32")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt64")]
		[CalledBy(Type = typeof(DeserializeEnumerator<>), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt16")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadBool")]
		[CalledBy(Type = typeof(JsonParser), Member = "SkipValue")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadString")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeObject")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeDictionary")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeList")]
		[CalledBy(Type = typeof(FastJson), Member = "_ParseArray")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeArray")]
		[Calls(Type = typeof(SystemException), Member = ".ctor")]
		[Calls(Type = typeof(JsonParser), Member = "_GetExceptionText")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 17)]
		public FormatException CreateFormatException()
		{
			return null;
		}

		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt64")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt32")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt16")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt8")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt64")]
		[Calls(Type = typeof(JsonParser), Member = "_GetExceptionText")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt16")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt8")]
		[Calls(Type = typeof(SystemException), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt32")]
		public OverflowException CreateOverflowException()
		{
			return null;
		}

		[CalledBy(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[CalledBy(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 22)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "Substring")]
		private string _GetExceptionText()
		{
			return null;
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeBoolean")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsUnknownMethods(Count = 9)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		public bool ReadBool()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt64")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt32")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt16")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt8")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt32")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt16")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt8")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt64")]
		private bool _ReadNegativeSign()
		{
			return default(bool);
		}

		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeSByte")]
		[Calls(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "_ReadNegativeSign")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		public sbyte ReadInt8()
		{
			return default(sbyte);
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeInt16")]
		[Calls(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "_ReadNegativeSign")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		public short ReadInt16()
		{
			return default(short);
		}

		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeInt32")]
		[Calls(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "_ReadNegativeSign")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		public int ReadInt32()
		{
			return default(int);
		}

		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeInt64")]
		[Calls(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "_ReadNegativeSign")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		public long ReadInt64()
		{
			return default(long);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsUnknownMethods(Count = 1)]
		public byte ReadUInt8_Fast()
		{
			return default(byte);
		}

		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeByte")]
		[Calls(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "_ReadNegativeSign")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		public byte ReadUInt8()
		{
			return default(byte);
		}

		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeChar")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeUInt16")]
		[Calls(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "_ReadNegativeSign")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		public ushort ReadUInt16()
		{
			return default(ushort);
		}

		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeUInt32")]
		[CalledBy(Type = typeof(CustomExample2.CipherInt), Member = "Deserialize")]
		[CalledBy(Type = typeof(CustomExample.CipherInt), Member = "FromJson")]
		[Calls(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "_ReadNegativeSign")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		public uint ReadUInt32()
		{
			return default(uint);
		}

		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeUInt64")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "_ReadNegativeSign")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		public ulong ReadUInt64()
		{
			return default(ulong);
		}
	}

	public class DeserializeEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable, IEnumerable<T>, IEnumerable
	{
		private T current;

		private Deserializer deserializer;

		private JsonParser parser;

		private Type type;

		public T Current
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 52)]
			get
			{
				return (T)null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 52)]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 1949)]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 1949)]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(FastJson), Member = "_GetDeserializer")]
		[CallsUnknownMethods(Count = 4)]
		public DeserializeEnumerator(JsonParser parser, Type type)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[CallsUnknownMethods(Count = 10)]
		public bool MoveNext()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void Dispose()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public void Reset()
		{
		}
	}

	public static EnumSerializationMethod enumSerializationMethod;

	public static bool errorOnSerializeObjectFail;

	private const int FASTJSON_STRING_BUILDER_INITIAL_CAPACITY = 2097152;

	private static StringBuilder m_StringBuilder;

	private static Mutex s_SerializeMutex;

	private static Type[] serializerrArgs;

	private static Type[] deserializerArgs;

	private static Dictionary<Type, List<FieldSerializer>> fieldSerializerCache;

	private static Dictionary<Type, Serializer> serializerCache;

	private static Dictionary<Type, Deserializer> deserializerCache;

	private static byte[] encodeCharaTable;

	private static byte[] decodeCharaTable;

	private static byte[] hexDecodeTable;

	private static bool[] jsonSeparator;

	private static char[] hexBuff;

	public const string DATE_FORMAT = "yyyy-MM-dd HH:mm:ss";

	public const BindingFlags BINDING_FLAGS = (BindingFlags)52;

	private static char[] numberBuff;

	private static FieldInfo[] hash128Fields;

	private static char[] hash128Buff;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void RegisterSerializer(Type type, Serializer serializer)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void RegisterDeserializer(Type type, Deserializer deserializer)
	{
	}

	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(CustomExample), Member = "Start")]
	[CalledBy(Type = typeof(CustomExample2), Member = "Start")]
	[CalledBy(Type = typeof(PerformanceTest), Member = "Test1")]
	[CalledBy(Type = typeof(PerformanceTest), Member = "Test2")]
	[CalledBy(Type = typeof(PerformanceTest._003C_003Ec__DisplayClass12_0<, >), Member = "<Test1>b__0")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(FastJson), Member = "_SerializeIfNull")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(PerformanceTest._003C_003Ec__DisplayClass15_0<>), Member = "<Test2>b__0")]
	[CalledBy(Type = typeof(Example), Member = "Start")]
	[CalledBy(Type = typeof(Example), Member = "Start")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[CalledBy(Type = typeof(Utils), Member = "SerializeObject")]
	public static string Serialize(object obj)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(FastJson), Member = "_SerializeIfNull")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	private static void _Serialize(StringBuilder sb, object obj)
	{
	}

	[CalledBy(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate")]
	[CalledBy(Type = typeof(FastJson), Member = "_GetSerializer")]
	[CalledBy(Type = typeof(FastJson), Member = "_Serialize")]
	[CalledBy(Type = typeof(FastJson), Member = "_GetSerializer")]
	[CalledBy(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[CalledBy(Type = typeof(FastJson), Member = "_GetSerializer")]
	[CalledBy(Type = typeof(FastJson), Member = "Serialize")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeArray")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeList")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeDictionary")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeDictionary")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeHashSet")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeObject")]
	[CallsUnknownMethods(Count = 58)]
	[CalledBy(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(Enum), Member = "GetUnderlyingType")]
	[Calls(Type = typeof(Type), Member = "get_IsClass")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static Serializer _GetSerializer(Type type)
	{
		return null;
	}

	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(FastJson), Member = "_SerializeIfNull")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Array), Member = "GetValue")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Array), Member = "GetValue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	private static void _SerializeArray(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[CallsUnknownMethods(Count = 30)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[Calls(Type = typeof(FastJson), Member = "_SerializeIfNull")]
	private static void _SerializeList(StringBuilder sb, object obj)
	{
	}

	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(FastJson), Member = "_SerializeIfNull")]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 46)]
	private static void _SerializeDictionary(StringBuilder sb, object obj)
	{
	}

	[Calls(Type = typeof(FastJson), Member = "_SerializeIfNull")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 34)]
	[CallsDeduplicatedMethods(Count = 8)]
	private static void _SerializeHashSet(StringBuilder sb, object obj)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "IsDefaultType")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 37)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(FastJson), Member = "_SerializeIfNull")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	private static void _SerializeObject(StringBuilder sb, object obj)
	{
	}

	[CalledBy(Type = typeof(FastJson), Member = "Serialize")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeObject")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeHashSet")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeDictionary")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeList")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeArray")]
	[CalledBy(Type = typeof(FastJson), Member = "_Serialize")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 7)]
	private static bool _SerializeIfNull(StringBuilder sb, object obj)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 23)]
	private static void _Register(Type type, Serializer serializer, Deserializer deserializer)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[CallsUnknownMethods(Count = 520)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_GetFieldInfo")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_GetFieldInfo")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_GetFieldInfo")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_GetFieldInfo")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 43)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(Mutex), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	static FastJson()
	{
	}

	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeColor32")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeColor32")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeColor32")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeColor32")]
	[CalledBy(Type = typeof(FastJson), Member = "ParseHash128")]
	[CalledBy(Type = typeof(JsonParser), Member = "ReadString")]
	[CalledBy(Type = typeof(JsonParser), Member = "ReadString")]
	[CalledBy(Type = typeof(JsonParser), Member = "ReadString")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeColor32")]
	[CalledBy(Type = typeof(JsonParser), Member = "ReadString")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeHash128")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeColor32")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeColor32")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeColor32")]
	public static int HexToInt(char ch)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public static char IntToHex(int i)
	{
		return default(char);
	}

	[CallerCount(Count = 0)]
	public static char IntToHex(uint i)
	{
		return default(char);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool IsDigit(char ch)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool IsSpace(char ch)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(JsonParser), Member = "ReadToken")]
	[CalledBy(Type = typeof(JsonParser), Member = "_Skip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static bool IsJsonSeparator(char ch)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static char ToUpper(char ch)
	{
		return default(char);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(Convert), Member = "ToString")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 1)]
	private static void _ToString(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	private static void _SerializeSByte(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 15)]
	private static void _SerializeInt16(StringBuilder sb, object obj)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallerCount(Count = 0)]
	private static void _SerializeInt32(StringBuilder sb, object obj)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void _SerializeInt64(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 9)]
	private static void _SerializeByte(StringBuilder sb, object obj)
	{
	}

	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void _SerializeUInt16(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	private static void _SerializeUInt32(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void _SerializeUInt64(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	private static void _SerializeBool(StringBuilder sb, object obj)
	{
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	private static void _SerializeChar(StringBuilder sb, object obj)
	{
	}

	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	private static void _SerializeString(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void _SerializeEnumName(StringBuilder sb, object obj)
	{
	}

	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	private static void _SerializeVector2(StringBuilder sb, object vec)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static void _SerializeVector3(StringBuilder sb, object vec)
	{
	}

	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void _SerializeVector4(StringBuilder sb, object vec)
	{
	}

	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 20)]
	private static void _SerializeQuaternion(StringBuilder sb, object q)
	{
	}

	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsUnknownMethods(Count = 20)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static void _SerializeRect(StringBuilder sb, object rect)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	private static void _SerializeColor(StringBuilder sb, object color)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 28)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	private static void _SerializeColor32(StringBuilder sb, object color)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(string), Member = "CreateString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static string Hash128ToString(Hash128 hash)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	private static void _SerializeHash128(StringBuilder sb, object hash)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(DateTime), Member = "ToString")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void _SerializeDate(StringBuilder sb, object date)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = ".ctor")]
	[Calls(Type = typeof(FastJson), Member = "_Deserialize")]
	[CallsUnknownMethods(Count = 10)]
	public static T Deserialize<T>(string jsonText)
	{
		return (T)null;
	}

	[CalledBy(Type = typeof(Example), Member = "Start")]
	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	public static object Deserialize(string jsonText, Type type)
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeEnum")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(FastJson), Member = "_GetDefault")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeObject")]
	[CalledBy(Type = typeof(FastJson), Member = "Deserialize")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static object _Deserialize(Type type, JsonParser parser)
	{
		return null;
	}

	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FastJson), Member = "_Deserialize")]
	private static object _GetDefault(Type type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 58)]
	[CalledBy(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[Calls(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[Calls(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate")]
	[CalledBy(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[CalledBy(Type = typeof(FastJson), Member = "_Deserialize")]
	[CalledBy(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[CalledBy(Type = typeof(DeserializeEnumerator<>), Member = ".ctor")]
	[Calls(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeDictionary")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeDictionary")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeList")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeArray")]
	[CalledBy(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[CalledBy(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[Calls(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[Calls(Type = typeof(Type), Member = "get_IsClass")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static Deserializer _GetDeserializer(Type type)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(Array), Member = "CreateInstance")]
	[Calls(Type = typeof(Array), Member = "SetValue")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(JsonParser), Member = "SkipValue")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(Array), Member = "CreateInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(JsonParser), Member = "PeekWithTrim")]
	[Calls(Type = typeof(FastJson), Member = "_ParseArray")]
	[Calls(Type = typeof(FastJson), Member = "_SetArray")]
	[Calls(Type = typeof(Array), Member = "CreateInstance")]
	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[Calls(Type = typeof(JsonParser), Member = "_ReadIfNull")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	private static object _DeserializeArray(Type type, JsonParser parser)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeArray")]
	[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(FastJson), Member = "_ParseArray")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[CalledBy(Type = typeof(FastJson), Member = "_ParseArray")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	private static List<object> _ParseArray(JsonParser parser, Type elementType, Deserializer deserializer, int nest, ref int[] length)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(FastJson), Member = "_SetArray")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeArray")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(FastJson), Member = "_SetArray")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private static void _SetArray(Array array, int[] indices, List<object> listList, int nest)
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "_ReadIfNull")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallerCount(Count = 0)]
	private static object _DeserializeList(Type type, JsonParser parser)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(JsonParser), Member = "_ReadIfNull")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private static object _DeserializeHashSet(Type type, JsonParser parser)
	{
		return null;
	}

	[Calls(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(JsonParser), Member = "_ReadIfNull")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	private static object _DeserializeDictionary(Type type, JsonParser parser)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(Enum), Member = "GetUnderlyingType")]
	[Calls(Type = typeof(FastJson), Member = "_Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = "ReadString")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private static object _DeserializeEnum(Type type, JsonParser parser)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
	[Calls(Type = typeof(JsonParser), Member = "ReadString")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(FastJson), Member = "_GetFieldInfo")]
	[Calls(Type = typeof(FastJson), Member = "_Deserialize")]
	[Calls(Type = typeof(JsonParser), Member = "SkipValue")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "_ReadIfNull")]
	private static object _DeserializeObject(Type type, JsonParser parser)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = "ReadInt16")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static object _DeserializeInt16(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = "ReadInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static object _DeserializeInt32(Type type, JsonParser parser)
	{
		return null;
	}

	[Calls(Type = typeof(JsonParser), Member = "ReadInt64")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static object _DeserializeInt64(Type type, JsonParser parser)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = "ReadUInt16")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static object _DeserializeUInt16(Type type, JsonParser parser)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = "ReadUInt32")]
	[CallerCount(Count = 0)]
	private static object _DeserializeUInt32(Type type, JsonParser parser)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadUInt64")]
	private static object _DeserializeUInt64(Type type, JsonParser parser)
	{
		return null;
	}

	[Calls(Type = typeof(JsonParser), Member = "ReadString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeString(Type type, JsonParser parser)
	{
		return null;
	}

	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static object _DeserializeFloat(Type type, JsonParser parser)
	{
		return null;
	}

	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToDouble")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static object _DeserializeDouble(Type type, JsonParser parser)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadUInt8")]
	private static object _DeserializeByte(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = "ReadInt8")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static object _DeserializeSByte(Type type, JsonParser parser)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = "ReadBool")]
	private static object _DeserializeBoolean(Type type, JsonParser parser)
	{
		return null;
	}

	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(Convert), Member = "ToDecimal")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[CallerCount(Count = 0)]
	private static object _DeserializeDecimal(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadUInt16")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static object _DeserializeChar(Type type, JsonParser parser)
	{
		return null;
	}

	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	private static object _DeserializeVector2(Type type, JsonParser parser)
	{
		return null;
	}

	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	private static object _DeserializeVector3(Type type, JsonParser parser)
	{
		return null;
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	private static object _DeserializeVector4(Type type, JsonParser parser)
	{
		return null;
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	private static object _DeserializeQuaternion(Type type, JsonParser parser)
	{
		return null;
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static object _DeserializeRect(Type type, JsonParser parser)
	{
		return null;
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	private static object _DeserializeColor(Type type, JsonParser parser)
	{
		return null;
	}

	[Calls(Type = typeof(FastJson), Member = "HexToInt")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(FastJson), Member = "HexToInt")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(FastJson), Member = "HexToInt")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(FastJson), Member = "HexToInt")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(FastJson), Member = "HexToInt")]
	[Calls(Type = typeof(FastJson), Member = "HexToInt")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(FastJson), Member = "HexToInt")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(FastJson), Member = "HexToInt")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(JsonParser), Member = "ReadString")]
	private static object _DeserializeColor32(Type type, JsonParser parser)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(FastJson), Member = "HexToInt")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static Hash128 ParseHash128(string hex)
	{
		return default(Hash128);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(FastJson), Member = "HexToInt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(JsonParser), Member = "ReadString")]
	private static object _DeserializeHash128(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo")]
	[Calls(Type = typeof(DateTime), Member = "ParseExact")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = "ReadString")]
	private static object _DeserializeDate(Type type, JsonParser parser)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeObject")]
	[CalledBy(Type = typeof(FastJson), Member = ".cctor")]
	[CalledBy(Type = typeof(FastJson), Member = ".cctor")]
	[CalledBy(Type = typeof(FastJson), Member = ".cctor")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(FastJson), Member = ".cctor")]
	private static FieldInfo _GetFieldInfo(Type type, string fieldName, BindingFlags bindingFlags)
	{
		return null;
	}
}
