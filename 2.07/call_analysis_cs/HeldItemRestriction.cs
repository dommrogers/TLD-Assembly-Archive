using System.Collections.Generic;
using System.Linq;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CIsRestricted_003Eb__0(GearItem i)
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CIsRestricted_003Eb__1(GearItem i)
		{
			return false;
		}
	}

	public HeldItemRestrictionType m_Type;

	public List<GearItem> m_List;

	[CalledBy(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Any")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsRestricted(GearItem gi)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public HeldItemRestriction()
	{
	}
}
