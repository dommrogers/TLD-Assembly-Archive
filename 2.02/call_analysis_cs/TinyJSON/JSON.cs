using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace TinyJSON;

public static class JSON
{
	private static readonly Type includeAttrType;

	private static readonly Type excludeAttrType;

	private static Dictionary<string, Type> typeCache;

	private static BindingFlags instanceBindingFlags;

	private static BindingFlags staticBindingFlags;

	private static MethodInfo decodeTypeMethod;

	private static MethodInfo decodeListMethod;

	private static MethodInfo decodeDictionaryMethod;

	private static MethodInfo decodeArrayMethod;

	private static MethodInfo decodeMultiRankArrayMethod;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decoder), Member = "Decode")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Variant Load(string json)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static string Dump(object data)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Extensions), Member = "AnyOfType")]
	[Calls(Type = typeof(Encoder), Member = "Encode")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	public static string Dump(object data, EncodeOptions options)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void MakeInto<T>(Variant data, out T item)
	{
		item = default(T);
	}

	[CalledBy(Type = typeof(JSON), Member = "DecodeType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	private static Type FindType(string fullName)
	{
		return null;
	}

	[Preserve]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ProxyObject), Member = "get_TypeHint")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(JSON), Member = "FindType")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(Type), Member = "GetProperty")]
	[Calls(Type = typeof(Extensions), Member = "AnyOfType")]
	[Calls(Type = typeof(ProxyArray), Member = "CanBeMultiRankArray")]
	[Calls(Type = typeof(Array), Member = "CreateInstance")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor")]
	[Calls(Type = typeof(DecodeException), Member = ".ctor")]
	[Calls(Type = typeof(DecodeException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 48)]
	[CallsUnknownMethods(Count = 154)]
	private static T DecodeType<T>(Variant data)
	{
		return default(T);
	}

	[Preserve]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	private static List<T> DecodeList<T>(Variant data)
	{
		return null;
	}

	[Preserve]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 22)]
	private static Dictionary<K, V> DecodeDictionary<K, V>(Variant data)
	{
		return null;
	}

	[Preserve]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProxyArray), Member = "get_Count")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private static T[] DecodeArray<T>(Variant data)
	{
		return null;
	}

	[Preserve]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProxyArray), Member = "get_Count")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	private static void DecodeMultiRankArray<T>(ProxyArray arrayData, Array array, int arrayRank, int[] indices)
	{
	}

	[Preserve]
	[DeduplicatedMethod]
	[CalledBy(Type = typeof(JSON), Member = "SupportValueTypesForAOT")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 15)]
	public static void SupportTypeForAOT<T>()
	{
	}

	[Preserve]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JSON), Member = "SupportTypeForAOT")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void SupportValueTypesForAOT()
	{
	}
}
