using Cpp2ILInjected.CallAnalysis;

public class Feat_BlizzardWalkerSaveData
{
	public float m_BlizzardHoursOutside;

	public float m_BlizzardHoursOutsideAccumulator;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public Feat_BlizzardWalkerSaveData()
	{
	}
}
