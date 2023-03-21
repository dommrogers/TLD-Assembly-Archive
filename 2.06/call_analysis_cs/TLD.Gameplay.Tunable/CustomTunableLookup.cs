using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay.Tunable;

public abstract class CustomTunableLookup<TKey, TElement> where TKey : Enum
{
	private static readonly TKey[] s_enumValues;

	private static readonly string[] s_enumNames;

	public TElement[] m_values;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetNames")]
	[CallsUnknownMethods(Count = 18)]
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

	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static string[] GetNames()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 4)]
	public CustomTunableLookup()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ValueType), Member = "DefaultEquals")]
	public TElement GetValue(TKey index)
	{
		return (TElement)null;
	}
}
