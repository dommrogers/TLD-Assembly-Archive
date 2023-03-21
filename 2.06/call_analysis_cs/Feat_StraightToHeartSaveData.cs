using Cpp2ILInjected.CallAnalysis;

public class Feat_StraightToHeartSaveData
{
	public int m_ItemConsumedCount;

	public float m_ItemConsumedAccumulator;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public Feat_StraightToHeartSaveData()
	{
	}
}
