using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HeldItemRestriction : ScriptableObject
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public GearItem gi;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Equals")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CIsRestricted_003Eb__0(GearItem i)
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Equals")]
		internal bool _003CIsRestricted_003Eb__1(GearItem i)
		{
			return default(bool);
		}
	}

	public HeldItemRestrictionType m_Type;

	public List<GearItem> m_List;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	[CallsUnknownMethods(Count = 24)]
	public bool IsRestricted(GearItem gi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public HeldItemRestriction()
	{
	}
}
