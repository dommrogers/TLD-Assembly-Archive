using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Serialization.FullSerializer.Internal;

namespace ParadoxNotion.Serialization.FullSerializer;

public sealed class fsData
{
	private object _value;

	public static readonly fsData True;

	public static readonly fsData False;

	public static readonly fsData Null;

	public fsDataType Type
	{
		[CalledBy(Type = typeof(fsBaseConverter), Member = "FailExpectedType")]
		[CalledBy(Type = typeof(fsBaseConverter), Member = "CheckType")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CallerCount(Count = 9)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return default(fsDataType);
		}
	}

	public bool IsNull
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public bool IsDouble
	{
		[CalledBy(Type = typeof(fsData), Member = "op_Equality")]
		[CallerCount(Count = 2)]
		get
		{
			return false;
		}
	}

	public bool IsInt64
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public bool IsBool
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public bool IsString
	{
		[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TrySerialize")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CallerCount(Count = 2)]
		get
		{
			return false;
		}
	}

	public bool IsDictionary
	{
		[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
		[CalledBy(Type = typeof(fsSerializer), Member = "IsObjectReference")]
		[CalledBy(Type = typeof(fsSerializer), Member = "IsObjectDefinition")]
		[CalledBy(Type = typeof(fsSerializer), Member = "IsVersioned")]
		[CalledBy(Type = typeof(fsSerializer), Member = "IsTypeSpecified")]
		[CalledBy(Type = typeof(fsSerializer), Member = "IsWrappedData")]
		[CalledBy(Type = typeof(fsSerializer), Member = "EnsureDictionary")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsBBParameterProcessor), Member = "OnBeforeDeserializeAfterInstanceCreation")]
		[CallerCount(Count = 13)]
		get
		{
			return false;
		}
	}

	public bool IsList
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public double AsDouble
	{
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsData), Member = "op_Equality")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(fsData), Member = "Cast")]
		get
		{
			return 0.0;
		}
	}

	public long AsInt64
	{
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(fsData), Member = "Cast")]
		get
		{
			return 0L;
		}
	}

	public bool AsBool
	{
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(fsData), Member = "Cast")]
		get
		{
			return false;
		}
	}

	public string AsString
	{
		[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(fsData), Member = "Cast")]
		get
		{
			return null;
		}
	}

	public Dictionary<string, fsData> AsDictionary
	{
		[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(fsData), Member = "Cast")]
		get
		{
			return null;
		}
	}

	public List<fsData> AsList
	{
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(fsData), Member = "Cast")]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public fsData()
	{
	}

	[CalledBy(Type = typeof(fsData), Member = ".cctor")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseTrue")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseFalse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	[CallerCount(Count = 7)]
	public fsData(bool boolean)
	{
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseNumber")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	[CallerCount(Count = 3)]
	public fsData(double f)
	{
	}

	[CalledBy(Type = typeof(fsUnityObjectConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseNumber")]
	[CalledBy(Type = typeof(fsEnumConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	[CallerCount(Count = 5)]
	public fsData(long i)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 283)]
	public fsData(string str)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 283)]
	public fsData(Dictionary<string, fsData> dict)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 283)]
	public fsData(List<fsData> list)
	{
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static fsData CreateDictionary()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static fsData CreateList()
	{
		return null;
	}

	[CalledBy(Type = typeof(fsArrayConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsListConverter), Member = "TrySerialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public static fsData CreateList(int capacity)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void BecomeDictionary()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal fsData Clone()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 41)]
	private T Cast<T>()
	{
		return default(T);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsJsonPrinter), Member = "CompressedJson")]
	public override string ToString()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override bool Equals(object obj)
	{
		return false;
	}

	[CalledBy(Type = typeof(fsData), Member = "Equals")]
	[CalledBy(Type = typeof(fsData), Member = "op_Equality")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(fsData), Member = "op_Equality")]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[Calls(Type = typeof(fsData), Member = "get_AsList")]
	[Calls(Type = typeof(fsData), Member = "Equals")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[Calls(Type = typeof(fsData), Member = "get_AsInt64")]
	[Calls(Type = typeof(fsData), Member = "get_AsBool")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public bool Equals(fsData other)
	{
		return false;
	}

	[CalledBy(Type = typeof(fsData), Member = "Equals")]
	[CalledBy(Type = typeof(fsData), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(fsData), Member = "get_IsDouble")]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[Calls(Type = typeof(fsData), Member = "Equals")]
	public static bool operator ==(fsData a, fsData b)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsData), Member = "op_Equality")]
	public static bool operator !=(fsData a, fsData b)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override int GetHashCode()
	{
		return 0;
	}
}
