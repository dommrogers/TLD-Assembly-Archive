using Cpp2ILInjected.CallAnalysis;

public class Feat_NightWalkerSaveData
{
	public bool m_Unlocked;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public Feat_NightWalkerSaveData()
	{
	}
}
