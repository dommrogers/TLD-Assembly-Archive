using Cpp2ILInjected.CallAnalysis;

public class Feat_BlizzardWalkerSaveData
{
	public float m_BlizzardHoursOutside;

	public float m_BlizzardHoursOutsideAccumulator;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Feat_BlizzardWalkerSaveData()
	{
	}
}
