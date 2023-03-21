using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RemedyDefinition : ScriptableObject
{
	public GameObject m_GearItemPrefab;

	private FirstAidItem m_FirstAidItem;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsWaterSupply()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public string GetDisplayName()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public FirstAidItem GetFirstAidItem()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public RemedyDefinition()
	{
	}
}
