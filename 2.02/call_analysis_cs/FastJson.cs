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

		[DeduplicatedMethod]
		[CallerCount(Count = 34)]
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
				return false;
			}
		}

		[CalledBy(Type = typeof(FastJson), Member = "Deserialize")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public JsonParser(string jsonText)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsUnknownMethods(Count = 1)]
		public char Peek()
		{
			return '\0';
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsUnknownMethods(Count = 1)]
		public char Read()
		{
			return '\0';
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeArray")]
		[CalledBy(Type = typeof(JsonParser), Member = "SkipValue")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsUnknownMethods(Count = 1)]
		public char PeekWithTrim()
		{
			return '\0';
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsUnknownMethods(Count = 1)]
		public char ReadWithTrim()
		{
			return '\0';
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsUnknownMethods(Count = 1)]
		public void Trim()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(FastJson), Member = "IsJsonSeparator")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void _Skip()
		{
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeFloat")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeDouble")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeDecimal")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeVector2")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeVector3")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeVector4")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeQuaternion")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeRect")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeColor")]
		[CalledBy(Type = typeof(JsonParser), Member = "SkipValue")]
		[CallerCount(Count = 26)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(FastJson), Member = "IsJsonSeparator")]
		[Calls(Type = typeof(string), Member = "Substring")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public string ReadToken()
		{
			return null;
		}

		[CallAnalysisFailed]
		[CalledBy(Type = typeof(JsonParser), Member = "SkipValue")]
		[CallerCount(Count = 1)]
		public bool ReadIfNull()
		{
			return false;
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeArray")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeList")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeHashSet")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeDictionary")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeObject")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadString")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsUnknownMethods(Count = 1)]
		private bool _ReadIfNull()
		{
			return false;
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeArray")]
		[CalledBy(Type = typeof(FastJson), Member = "_ParseArray")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeList")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeDictionary")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeObject")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeVector2")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeVector3")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeVector4")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeQuaternion")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeRect")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeColor")]
		[CalledBy(Type = typeof(DeserializeEnumerator<>), Member = ".ctor")]
		[CallerCount(Count = 35)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(string), Member = "Substring")]
		[Calls(Type = typeof(char), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 25)]
		public void ReadSpecifyChar(char spec)
		{
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeEnum")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeObject")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeString")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeColor32")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeHash128")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeDate")]
		[CalledBy(Type = typeof(JsonParser), Member = "SkipValue")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "_ReadIfNull")]
		[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		[Calls(Type = typeof(FastJson), Member = "HexToInt")]
		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 22)]
		public string ReadString()
		{
			return null;
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeArray")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeObject")]
		[CalledBy(Type = typeof(JsonParser), Member = "SkipValue")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
		[Calls(TypeFullName = "System.Number", Member = "TryParseDecimal")]
		[Calls(Type = typeof(double), Member = "TryParse")]
		[Calls(Type = typeof(bool), Member = "TryParse")]
		[Calls(Type = typeof(JsonParser), Member = "ReadIfNull")]
		[Calls(Type = typeof(JsonParser), Member = "PeekWithTrim")]
		[Calls(Type = typeof(JsonParser), Member = "SkipValue")]
		[Calls(Type = typeof(JsonParser), Member = "ReadString")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 10)]
		public void SkipValue()
		{
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeArray")]
		[CalledBy(Type = typeof(FastJson), Member = "_ParseArray")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeList")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeDictionary")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeObject")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadString")]
		[CalledBy(Type = typeof(JsonParser), Member = "SkipValue")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadBool")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt8")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt16")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt32")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt64")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt8")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt16")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt32")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt64")]
		[CalledBy(Type = typeof(DeserializeEnumerator<>), Member = "MoveNext")]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(JsonParser), Member = "_GetExceptionText")]
		[Calls(Type = typeof(SystemException), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public FormatException CreateFormatException()
		{
			return null;
		}

		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt8")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt16")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt32")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt64")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt8")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt16")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt32")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt64")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(JsonParser), Member = "_GetExceptionText")]
		[Calls(Type = typeof(SystemException), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public OverflowException CreateOverflowException()
		{
			return null;
		}

		[CalledBy(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[CalledBy(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "Substring")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 22)]
		private string _GetExceptionText()
		{
			return null;
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeBoolean")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		public bool ReadBool()
		{
			return false;
		}

		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt8")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt16")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt32")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadInt64")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt8")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt16")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt32")]
		[CalledBy(Type = typeof(JsonParser), Member = "ReadUInt64")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsUnknownMethods(Count = 1)]
		private bool _ReadNegativeSign()
		{
			return false;
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeSByte")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(JsonParser), Member = "_ReadNegativeSign")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[Calls(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public sbyte ReadInt8()
		{
			return 0;
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeInt16")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(JsonParser), Member = "_ReadNegativeSign")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[Calls(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public short ReadInt16()
		{
			return 0;
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeInt32")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(JsonParser), Member = "_ReadNegativeSign")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[Calls(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public int ReadInt32()
		{
			return 0;
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeInt64")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(JsonParser), Member = "_ReadNegativeSign")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[Calls(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public long ReadInt64()
		{
			return 0L;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[CallsUnknownMethods(Count = 1)]
		public byte ReadUInt8_Fast()
		{
			return 0;
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeByte")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(JsonParser), Member = "_ReadNegativeSign")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[Calls(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public byte ReadUInt8()
		{
			return 0;
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeUInt16")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeChar")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(JsonParser), Member = "_ReadNegativeSign")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[Calls(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public ushort ReadUInt16()
		{
			return 0;
		}

		[CalledBy(TypeFullName = "CustomExample.CipherInt", Member = "FromJson")]
		[CalledBy(TypeFullName = "CustomExample2.CipherInt", Member = "Deserialize")]
		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeUInt32")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(JsonParser), Member = "_ReadNegativeSign")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[Calls(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public uint ReadUInt32()
		{
			return 0u;
		}

		[CalledBy(Type = typeof(FastJson), Member = "_DeserializeUInt64")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(JsonParser), Member = "_ReadNegativeSign")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[Calls(Type = typeof(JsonParser), Member = "CreateOverflowException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public ulong ReadUInt64()
		{
			return 0uL;
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
			[CallerCount(Count = 59)]
			get
			{
				return default(T);
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 59)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2043)]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2043)]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(FastJson), Member = "_GetDeserializer")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public DeserializeEnumerator(JsonParser parser, Type type)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		public bool MoveNext()
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public void Dispose()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterSerializer(Type type, Serializer serializer)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterDeserializer(Type type, Deserializer deserializer)
	{
	}

	[CalledBy(Type = typeof(CustomExample), Member = "Start")]
	[CalledBy(Type = typeof(CustomExample2), Member = "Start")]
	[CalledBy(Type = typeof(PerformanceTest), Member = "Test1")]
	[CalledBy(Type = typeof(PerformanceTest), Member = "Test2")]
	[CalledBy(TypeFullName = "PerformanceTest.<>c__DisplayClass12_0`2", Member = "<Test1>b__0")]
	[CalledBy(TypeFullName = "PerformanceTest.<>c__DisplayClass15_0`1", Member = "<Test2>b__0")]
	[CalledBy(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(Example), Member = "Start")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[Calls(Type = typeof(FastJson), Member = "_SerializeIfNull")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	public static string Serialize(object obj)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastJson), Member = "_SerializeIfNull")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void _Serialize(StringBuilder sb, object obj)
	{
	}

	[CalledBy(Type = typeof(FastJson), Member = "Serialize")]
	[CalledBy(Type = typeof(FastJson), Member = "_Serialize")]
	[CalledBy(Type = typeof(FastJson), Member = "_GetSerializer")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeArray")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeList")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeDictionary")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeHashSet")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeObject")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(Type), Member = "get_IsClass")]
	[Calls(Type = typeof(Enum), Member = "GetUnderlyingType")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 58)]
	private static Serializer _GetSerializer(Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastJson), Member = "_SerializeIfNull")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Array), Member = "GetValue")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Array), Member = "GetValue")]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 39)]
	private static void _SerializeArray(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastJson), Member = "_SerializeIfNull")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 30)]
	private static void _SerializeList(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastJson), Member = "_SerializeIfNull")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 46)]
	private static void _SerializeDictionary(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastJson), Member = "_SerializeIfNull")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 34)]
	private static void _SerializeHashSet(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastJson), Member = "_SerializeIfNull")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(FastJson), Member = "_GetSerializer")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Utils), Member = "IsDefaultType")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 37)]
	private static void _SerializeObject(StringBuilder sb, object obj)
	{
	}

	[CalledBy(Type = typeof(FastJson), Member = "Serialize")]
	[CalledBy(Type = typeof(FastJson), Member = "_Serialize")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeArray")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeList")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeDictionary")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeHashSet")]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeObject")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool _SerializeIfNull(StringBuilder sb, object obj)
	{
		return false;
	}

	[CalledBy(Type = typeof(FastJson), Member = ".cctor")]
	[CallerCount(Count = 23)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static void _Register(Type type, Serializer serializer, Deserializer deserializer)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(Mutex), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_Register")]
	[Calls(Type = typeof(FastJson), Member = "_GetFieldInfo")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsDeduplicatedMethods(Count = 43)]
	[CallsUnknownMethods(Count = 520)]
	static FastJson()
	{
	}

	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeColor32")]
	[CalledBy(Type = typeof(FastJson), Member = "ParseHash128")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeHash128")]
	[CalledBy(Type = typeof(JsonParser), Member = "ReadString")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static int HexToInt(char ch)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	public static char IntToHex(int i)
	{
		return '\0';
	}

	[CallerCount(Count = 0)]
	public static char IntToHex(uint i)
	{
		return '\0';
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool IsDigit(char ch)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool IsSpace(char ch)
	{
		return false;
	}

	[CalledBy(Type = typeof(JsonParser), Member = "_Skip")]
	[CalledBy(Type = typeof(JsonParser), Member = "ReadToken")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static bool IsJsonSeparator(char ch)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static char ToUpper(char ch)
	{
		return '\0';
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(Convert), Member = "ToString")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void _ToString(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	private static void _SerializeSByte(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	private static void _SerializeInt16(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	private static void _SerializeInt32(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	private static void _SerializeInt64(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private static void _SerializeByte(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private static void _SerializeUInt16(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private static void _SerializeUInt32(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private static void _SerializeUInt64(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void _SerializeBool(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void _SerializeChar(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	private static void _SerializeString(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void _SerializeEnumName(StringBuilder sb, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void _SerializeVector2(StringBuilder sb, object vec)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void _SerializeVector3(StringBuilder sb, object vec)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private static void _SerializeVector4(StringBuilder sb, object vec)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private static void _SerializeQuaternion(StringBuilder sb, object q)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private static void _SerializeRect(StringBuilder sb, object rect)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private static void _SerializeColor(StringBuilder sb, object color)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 28)]
	private static void _SerializeColor32(StringBuilder sb, object color)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public static string Hash128ToString(Hash128 hash)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private static void _SerializeHash128(StringBuilder sb, object hash)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(DateTime), Member = "ToString")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private static void _SerializeDate(StringBuilder sb, object date)
	{
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(CustomExample), Member = "Start")]
	[CalledBy(Type = typeof(CustomExample2), Member = "Start")]
	[CalledBy(Type = typeof(Example), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "_Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public static T Deserialize<T>(string jsonText)
	{
		return default(T);
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Example), Member = "Start")]
	[CallerCount(Count = 1)]
	public static object Deserialize(string jsonText, Type type)
	{
		return null;
	}

	[CalledBy(Type = typeof(FastJson), Member = "Deserialize")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeEnum")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeObject")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(FastJson), Member = "_GetDefault")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	private static object _Deserialize(Type type, JsonParser parser)
	{
		return null;
	}

	[CalledBy(Type = typeof(FastJson), Member = "_Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static object _GetDefault(Type type)
	{
		return null;
	}

	[CalledBy(Type = typeof(FastJson), Member = "_Deserialize")]
	[CalledBy(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeArray")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeList")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeDictionary")]
	[CalledBy(Type = typeof(DeserializeEnumerator<>), Member = ".ctor")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(Type), Member = "get_IsClass")]
	[Calls(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 58)]
	private static Deserializer _GetDeserializer(Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(JsonParser), Member = "_ReadIfNull")]
	[Calls(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[Calls(Type = typeof(FastJson), Member = "_ParseArray")]
	[Calls(Type = typeof(Array), Member = "CreateInstance")]
	[Calls(Type = typeof(FastJson), Member = "_SetArray")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "PeekWithTrim")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Array), Member = "CreateInstance")]
	[Calls(Type = typeof(Array), Member = "SetValue")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(JsonParser), Member = "SkipValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 45)]
	private static object _DeserializeArray(Type type, JsonParser parser)
	{
		return null;
	}

	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeArray")]
	[CalledBy(Type = typeof(FastJson), Member = "_ParseArray")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(FastJson), Member = "_ParseArray")]
	[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 27)]
	private static List<object> _ParseArray(JsonParser parser, Type elementType, Deserializer deserializer, int nest, ref int[] length)
	{
		return null;
	}

	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeArray")]
	[CalledBy(Type = typeof(FastJson), Member = "_SetArray")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FastJson), Member = "_SetArray")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private static void _SetArray(Array array, int[] indices, List<object> listList, int nest)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(JsonParser), Member = "_ReadIfNull")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	private static object _DeserializeList(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(JsonParser), Member = "_ReadIfNull")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 21)]
	private static object _DeserializeHashSet(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(JsonParser), Member = "_ReadIfNull")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(FastJson), Member = "_GetDeserializer")]
	[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 19)]
	private static object _DeserializeDictionary(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(Enum), Member = "GetUnderlyingType")]
	[Calls(Type = typeof(FastJson), Member = "_Deserialize")]
	[Calls(Type = typeof(JsonParser), Member = "ReadString")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static object _DeserializeEnum(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(JsonParser), Member = "_ReadIfNull")]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(JsonParser), Member = "ReadString")]
	[Calls(Type = typeof(FastJson), Member = "_GetFieldInfo")]
	[Calls(Type = typeof(FastJson), Member = "_Deserialize")]
	[Calls(Type = typeof(JsonParser), Member = "SkipValue")]
	[Calls(Type = typeof(JsonParser), Member = "CreateFormatException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private static object _DeserializeObject(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadInt16")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeInt16(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeInt32(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadInt64")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeInt64(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadUInt16")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeUInt16(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadUInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeUInt32(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadUInt64")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeUInt64(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(JsonParser), Member = "ReadString")]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeString(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(TypeFullName = "System.Number", Member = "ParseSingle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeFloat(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(Convert), Member = "ToDouble")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeDouble(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadUInt8")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeByte(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadInt8")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeSByte(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadBool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeBoolean(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(Convert), Member = "ToDecimal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeDecimal(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadUInt16")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeChar(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(TypeFullName = "System.Number", Member = "ParseSingle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeVector2(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(TypeFullName = "System.Number", Member = "ParseSingle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeVector3(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(TypeFullName = "System.Number", Member = "ParseSingle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeVector4(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(TypeFullName = "System.Number", Member = "ParseSingle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeQuaternion(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(TypeFullName = "System.Number", Member = "ParseSingle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeRect(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadSpecifyChar")]
	[Calls(Type = typeof(JsonParser), Member = "ReadToken")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(TypeFullName = "System.Number", Member = "ParseSingle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeColor(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadString")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(FastJson), Member = "HexToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static object _DeserializeColor32(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(FastJson), Member = "HexToInt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static Hash128 ParseHash128(string hex)
	{
		return default(Hash128);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadString")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(FastJson), Member = "HexToInt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private static object _DeserializeHash128(Type type, JsonParser parser)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ReadString")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo")]
	[Calls(Type = typeof(DateTime), Member = "ParseExact")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object _DeserializeDate(Type type, JsonParser parser)
	{
		return null;
	}

	[CalledBy(Type = typeof(FastJson), Member = ".cctor")]
	[CalledBy(Type = typeof(FastJson), Member = "_DeserializeObject")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static FieldInfo _GetFieldInfo(Type type, string fieldName, BindingFlags bindingFlags)
	{
		return null;
	}
}
