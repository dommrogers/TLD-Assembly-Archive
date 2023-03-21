using Cpp2ILInjected.CallAnalysis;

public class Feat_NightWalkerSaveData
{
	public bool m_Unlocked;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Feat_NightWalkerSaveData()
	{
	}
}
