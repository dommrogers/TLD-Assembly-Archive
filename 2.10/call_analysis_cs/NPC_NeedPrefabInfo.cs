using Cpp2ILInjected.CallAnalysis;

public class NPC_NeedPrefabInfo
{
	public NPC_NeedPrefab.NPCNeedType m_NeedType;

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

	[CallerCount(Count = 0)]
	public NPC_NeedPrefabInfo()
	{
	}
}
