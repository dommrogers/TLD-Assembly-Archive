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
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(fsBaseConverter), Member = "CheckType")]
		[CalledBy(Type = typeof(fsBaseConverter), Member = "CheckType")]
		[CalledBy(Type = typeof(fsBaseConverter), Member = "FailExpectedType")]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(fsData), Member = "op_Equality")]
		[CalledBy(Type = typeof(fsData), Member = "op_Equality")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		get
		{
			return default(bool);
		}
	}

	public bool IsInt64
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(fsEnumConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		get
		{
			return default(bool);
		}
	}

	public bool IsBool
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool IsString
	{
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TrySerialize")]
		[CalledBy(Type = typeof(fsEnumConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsTypeConverter), Member = "TryDeserialize")]
		get
		{
			return default(bool);
		}
	}

	public bool IsDictionary
	{
		[CalledBy(Type = typeof(fsSerializer), Member = "IsWrappedData")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsSerializer), Member = "EnsureDictionary")]
		[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsSerializer), Member = "IsVersioned")]
		[CalledBy(Type = typeof(fsSerializer), Member = "IsObjectDefinition")]
		[CalledBy(Type = typeof(fsSerializer), Member = "IsObjectReference")]
		[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
		[CalledBy(Type = typeof(fsBBParameterProcessor), Member = "OnBeforeDeserializeAfterInstanceCreation")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 13)]
		[CalledBy(Type = typeof(fsSerializer), Member = "IsTypeSpecified")]
		get
		{
			return default(bool);
		}
	}

	public bool IsList
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public double AsDouble
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CalledBy(Type = typeof(fsData), Member = "op_Equality")]
		[CalledBy(Type = typeof(fsData), Member = "op_Equality")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		get
		{
			return default(double);
		}
	}

	public long AsInt64
	{
		[CalledBy(Type = typeof(fsEnumConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsUnityObjectConverter), Member = "TryDeserialize")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		get
		{
			return default(long);
		}
	}

	public bool AsBool
	{
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		get
		{
			return default(bool);
		}
	}

	public string AsString
	{
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsTypeConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsTypeConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsEnumConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
		[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
		[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 16)]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		get
		{
			return null;
		}
	}

	public Dictionary<string, fsData> AsDictionary
	{
		[CallerCount(Count = 32)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public List<fsData> AsList
	{
		[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsListConverter), Member = "TrySerialize")]
		[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TrySerialize")]
		[CalledBy(Type = typeof(fsListConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsListConverter), Member = "TryDeserialize")]
		[CalledBy(Type = typeof(fsArrayConverter), Member = "TryDeserialize")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CallerCount(Count = 11)]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		[CalledBy(Type = typeof(fsArrayConverter), Member = "TrySerialize")]
		[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
		[CalledBy(Type = typeof(fsData), Member = "Equals")]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public fsData()
	{
	}

	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseFalse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseTrue")]
	[CalledBy(Type = typeof(fsData), Member = ".cctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(fsData), Member = ".cctor")]
	public fsData(bool boolean)
	{
	}

	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseNumber")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	public fsData(double f)
	{
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseNumber")]
	[CalledBy(Type = typeof(fsEnumConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsUnityObjectConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(fsUnityObjectConverter), Member = "TrySerialize")]
	[CallerCount(Count = 5)]
	public fsData(long i)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101)]
	public fsData(string str)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101)]
	public fsData(Dictionary<string, fsData> dict)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101)]
	public fsData(List<fsData> list)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[CallsUnknownMethods(Count = 17)]
	public static fsData CreateDictionary()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static fsData CreateList()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsListConverter), Member = "TrySerialize")]
	[CallsUnknownMethods(Count = 14)]
	public static fsData CreateList(int capacity)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(fsSerializer), Member = "EnsureDictionary")]
	[CallsUnknownMethods(Count = 9)]
	internal void BecomeDictionary()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(fsSerializer), Member = "EnsureDictionary")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	internal fsData Clone()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 32)]
	private T Cast<T>()
	{
		return (T)null;
	}

	[Calls(Type = typeof(fsJsonPrinter), Member = "CompressedJson")]
	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CalledBy(Type = typeof(fsData), Member = "Equals")]
	[CalledBy(Type = typeof(fsData), Member = "Equals")]
	[CalledBy(Type = typeof(fsData), Member = "op_Equality")]
	[Calls(Type = typeof(fsData), Member = "get_AsInt64")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[Calls(Type = typeof(fsData), Member = "op_Equality")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[Calls(Type = typeof(fsData), Member = "get_AsList")]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[Calls(Type = typeof(fsData), Member = "Equals")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsData), Member = "Equals")]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[Calls(Type = typeof(fsData), Member = "get_AsList")]
	public bool Equals(fsData other)
	{
		return default(bool);
	}

	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[CalledBy(Type = typeof(fsData), Member = "Equals")]
	[Calls(Type = typeof(fsData), Member = "Equals")]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[CalledBy(Type = typeof(fsData), Member = "op_Inequality")]
	[Calls(Type = typeof(fsData), Member = "get_IsDouble")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(fsData), Member = "get_IsDouble")]
	public static bool operator ==(fsData a, fsData b)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsData), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	public static bool operator !=(fsData a, fsData b)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override int GetHashCode()
	{
		return default(int);
	}
}
