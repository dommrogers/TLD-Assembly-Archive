using Cpp2ILInjected.CallAnalysis;

public class Feat_SnowWalkerSaveData
{
	public float m_ElapsedKilometers;

	public float m_MetersAccumulator;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public Feat_SnowWalkerSaveData()
	{
	}
}
