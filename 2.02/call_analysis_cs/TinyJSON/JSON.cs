using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Decoder), Member = "Decode")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	public static Variant Load(string json)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static string Dump(object data)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Encoder), Member = "Encode")]
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
		System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref item) = null;
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(JSON), Member = "DecodeType")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	private static Type FindType(string fullName)
	{
		return null;
	}

	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 154)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[Calls(Type = typeof(DecodeException), Member = ".ctor")]
	[Calls(Type = typeof(DecodeException), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor")]
	[Calls(Type = typeof(ProxyArray), Member = "CanBeMultiRankArray")]
	[Calls(Type = typeof(Array), Member = "CreateInstance")]
	[Calls(Type = typeof(Type), Member = "GetProperty")]
	[Preserve]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 50)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ProxyObject), Member = "get_TypeHint")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(JSON), Member = "FindType")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static T DecodeType<T>(Variant data)
	{
		return (T)null;
	}

	[CallsUnknownMethods(Count = 18)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Preserve]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static List<T> DecodeList<T>(Variant data)
	{
		return null;
	}

	[Preserve]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[CallsUnknownMethods(Count = 22)]
	private static Dictionary<K, V> DecodeDictionary<K, V>(Variant data)
	{
		return null;
	}

	[Calls(Type = typeof(ProxyArray), Member = "get_Count")]
	[CallsUnknownMethods(Count = 16)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Preserve]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static T[] DecodeArray<T>(Variant data)
	{
		return null;
	}

	[Preserve]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ProxyArray), Member = "get_Count")]
	[CallsUnknownMethods(Count = 11)]
	private static void DecodeMultiRankArray<T>(ProxyArray arrayData, Array array, int arrayRank, int[] indices)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Preserve]
	[DeduplicatedMethod]
	public static void SupportTypeForAOT<T>()
	{
	}

	[Preserve]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private static void SupportValueTypesForAOT()
	{
	}
}
