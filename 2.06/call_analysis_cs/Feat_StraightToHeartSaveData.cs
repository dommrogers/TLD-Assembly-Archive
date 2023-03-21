using Cpp2ILInjected.CallAnalysis;

public class Feat_StraightToHeartSaveData
{
	public int m_ItemConsumedCount;

	public float m_ItemConsumedAccumulator;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Feat_StraightToHeartSaveData()
	{
	}
}
