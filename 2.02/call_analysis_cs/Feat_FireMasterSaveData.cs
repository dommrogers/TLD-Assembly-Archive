using Cpp2ILInjected.CallAnalysis;

public class Feat_FireMasterSaveData
{
	public int m_NumFiresStarted;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Feat_FireMasterSaveData()
	{
	}
}
