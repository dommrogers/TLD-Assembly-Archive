using Cpp2ILInjected.CallAnalysis;

public class Feat_ExpertTrapperSaveData
{
	public int m_RabbitSnaredCount;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Feat_ExpertTrapperSaveData()
	{
	}
}
