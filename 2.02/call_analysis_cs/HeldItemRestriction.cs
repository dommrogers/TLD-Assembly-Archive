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
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Equals")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CIsRestricted_003Eb__0(GearItem i)
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Equals")]
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
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Enumerable), Member = "Any")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	public bool IsRestricted(GearItem gi)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public HeldItemRestriction()
	{
	}
}
