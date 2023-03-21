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
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsBaseConverter), Member = "FailExpectedType")]
		[CalledBy(Type = typeof(fsBaseConverter), Member = "CheckType")]
		[CalledBy(Type = typeof(fsBaseConverter), Member = "CheckType")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
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
			return default(bool);
		}
	}

	public bool IsDouble
	{
		[CalledBy(Type = typeof(fsData), Member = "op_Equality")]
		[CalledBy(Type = typeof(fsData), Member = "op_Equality")]
		[CallerCount(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	public bool IsInt64
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool IsBool
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool IsString
	{
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TrySerialize")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		get
		{
			return default(bool);
		}
	}

	public bool IsDictionary
	{
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsBBParameterProcessor), Member = "OnBeforeDeserializeAfterInstanceCreation")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsSerializer), Member = "EnsureDictionary")]
		[CalledBy(Type = typeof(fsSerializer), Member = "IsObjectDefinition")]
		[CalledBy(Type = typeof(fsSerializer), Member = "IsTypeSpecified")]
		[CalledBy(Type = typeof(fsSerializer), Member = "IsVersioned")]
		[CalledBy(Type = typeof(fsSerializer), Member = "IsObjectReference")]
		[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
		[CallerCount(Count = 13)]
		[CalledBy(Type = typeof(fsSerializer), Member = "IsWrappedData")]
		get
		{
			return default(bool);
		}
	}

	public bool IsList
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public double AsDouble
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
		[CalledBy(Type = typeof(fsData), Member = "op_Equality")]
		[CalledBy(Type = typeof(fsData), Member = "op_Equality")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		get
		{
			return default(double);
		}
	}

	public long AsInt64
	{
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
		get
		{
			return default(long);
		}
	}

	public bool AsBool
	{
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		get
		{
			return default(bool);
		}
	}

	public string AsString
	{
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
		[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
		[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
		[CallerCount(Count = 11)]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		get
		{
			return null;
		}
	}

	public Dictionary<string, fsData> AsDictionary
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
		get
		{
			return null;
		}
	}

	public List<fsData> AsList
	{
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseFalse")]
	[CalledBy(Type = typeof(fsData), Member = ".cctor")]
	[CalledBy(Type = typeof(fsData), Member = ".cctor")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseTrue")]
	public fsData(bool boolean)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	public fsData(double f)
	{
	}

	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsEnumConverter), Member = "TrySerialize")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(fsUnityObjectConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsUnityObjectConverter), Member = "TrySerialize")]
	public fsData(long i)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 279)]
	public fsData(string str)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 279)]
	public fsData(Dictionary<string, fsData> dict)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 279)]
	public fsData(List<fsData> list)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TrySerialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
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

	[CalledBy(Type = typeof(fsListConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TrySerialize")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "TrySerialize")]
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

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private T Cast<T>()
	{
		return (T)null;
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
		return default(bool);
	}

	[Calls(Type = typeof(fsData), Member = "get_AsInt64")]
	[Calls(Type = typeof(fsData), Member = "get_AsBool")]
	[Calls(Type = typeof(fsData), Member = "get_AsBool")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(fsData), Member = "Equals")]
	[CalledBy(Type = typeof(fsData), Member = "Equals")]
	[CalledBy(Type = typeof(fsData), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(fsData), Member = "get_AsInt64")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(fsData), Member = "op_Equality")]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[Calls(Type = typeof(fsData), Member = "get_AsList")]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[Calls(Type = typeof(fsData), Member = "Equals")]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[Calls(Type = typeof(fsData), Member = "Equals")]
	[Calls(Type = typeof(fsData), Member = "get_AsList")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	public bool Equals(fsData other)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(fsData), Member = "op_Inequality")]
	[Calls(Type = typeof(fsData), Member = "Equals")]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[CalledBy(Type = typeof(fsData), Member = "Equals")]
	[Calls(Type = typeof(fsData), Member = "get_IsDouble")]
	[Calls(Type = typeof(fsData), Member = "get_IsDouble")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	public static bool operator ==(fsData a, fsData b)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsData), Member = "op_Equality")]
	public static bool operator !=(fsData a, fsData b)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override int GetHashCode()
	{
		return default(int);
	}
}
