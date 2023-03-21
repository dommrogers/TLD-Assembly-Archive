using Cpp2ILInjected.CallAnalysis;

public class NeedTrackerSaveData
{
	public NeedPrefabSaveData[] m_NeedPrefabsActive;

	public string m_NPCTrustID;

	public bool m_HasBeenInteractedWith;

	public bool m_NoTrustDecayUntilPlayerInteraction;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public NeedTrackerSaveData()
	{
	}
}
