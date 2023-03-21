using Cpp2ILInjected.CallAnalysis;

public class UnlockableTrackerSaveData
{
	public UnlockablePrefabSaveData[] m_UnlockablePrefabsActive;

	public string m_NPCTrustID;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public UnlockableTrackerSaveData()
	{
	}
}
