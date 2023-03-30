using Cpp2ILInjected.CallAnalysis;

public class Feat_FreeRunnerSaveData
{
	public float m_ElapsedKilometers;

	public float m_MetersAccumulator;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Feat_FreeRunnerSaveData()
	{
	}
}
