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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public static string[] GetNames()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(CustomTunableLookup_LMH), Member = ".ctor")]
	[CalledBy(Type = typeof(CustomPackSettingsLookup_LMH), Member = ".ctor")]
	[CalledBy(Type = typeof(CustomTunableLookup_NLH), Member = ".ctor")]
	[CalledBy(Type = typeof(CustomTunableLookup_LMHV), Member = ".ctor")]
	[CalledBy(Type = typeof(CustomTunableLookup_NLMH), Member = ".ctor")]
	[CalledBy(Type = typeof(CustomTunableLookup_NLMHV), Member = ".ctor")]
	[CalledBy(Type = typeof(CustomTunableLookup_DayNightMultiplier), Member = ".ctor")]
	[CalledBy(Type = typeof(CustomTunableLookup_TimeOfDay), Member = ".ctor")]
	[CalledBy(Type = typeof(CustomTunableLookup_Distance), Member = ".ctor")]
	[CalledBy(Type = typeof(CustomTunableLookup_Weather), Member = ".ctor")]
	[CalledBy(Type = typeof(CustomTunableLookup_ProportionalMaxItems), Member = ".ctor")]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 4)]
	public CustomTunableLookup()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ValueType), Member = "DefaultEquals")]
	[CallsUnknownMethods(Count = 8)]
	public TElement GetValue(TKey index)
	{
		return default(TElement);
	}
}
