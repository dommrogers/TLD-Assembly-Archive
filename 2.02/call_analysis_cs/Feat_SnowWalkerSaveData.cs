using Cpp2ILInjected.CallAnalysis;

public class Feat_SnowWalkerSaveData
{
	public float m_ElapsedKilometers;

	public float m_MetersAccumulator;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Feat_SnowWalkerSaveData()
	{
	}
}
