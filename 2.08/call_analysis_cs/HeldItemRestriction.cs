using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HeldItemRestriction : ScriptableObject
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public GearItem gi;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal bool _003CIsRestricted_003Eb__0(GearItem i)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CIsRestricted_003Eb__1(GearItem i)
		{
			return default(bool);
		}
	}

	public HeldItemRestrictionType m_Type;

	public List<GearItem> m_List;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsRestricted(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public HeldItemRestriction()
	{
	}
}
