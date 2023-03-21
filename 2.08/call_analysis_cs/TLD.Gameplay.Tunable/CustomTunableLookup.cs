using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay.Tunable;

public abstract class CustomTunableLookup<TKey, TElement> where TKey : Enum
{
	private static readonly TKey[] s_enumValues;

	private static readonly string[] s_enumNames;

	public TElement[] m_values;

	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	static CustomTunableLookup()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public static TKey[] GetValues()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static string[] GetNames()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 11)]
	public CustomTunableLookup()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ValueType), Member = "DefaultEquals")]
	[CallsUnknownMethods(Count = 8)]
	public TElement GetValue(TKey index)
	{
		return (TElement)null;
	}
}
