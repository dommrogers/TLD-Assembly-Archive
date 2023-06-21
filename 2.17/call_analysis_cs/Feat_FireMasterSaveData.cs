using Cpp2ILInjected.CallAnalysis;

public class Feat_FireMasterSaveData
{
	public int m_NumFiresStarted;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Feat_FireMasterSaveData()
	{
	}
}
