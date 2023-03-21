using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPC_NeedPrefab : MonoBehaviour
{
	public enum NPCNeedType
	{
		Food,
		Water,
		Fuel,
		Item
	}

	public NPCNeedType m_NeedType;

	public float m_NumCalories;

	public float m_NumLiters;

	public float m_NumHours;

	public int m_NumItems;

	public string m_ItemPrefabNameMain;

	public string m_ItemPrefabNameAlt;

	public int m_MinTrustToShowNeed;

	public int m_MaxTrustToShowNeed;

	public int m_TrustIncrease;

	public bool m_IsRepeatable;

	public float m_HoursBetweenRepeat;

	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "AddNeed")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public NPC_NeedPrefabInfo GetPrefabInfo()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public NPC_NeedPrefab()
	{
	}
}
