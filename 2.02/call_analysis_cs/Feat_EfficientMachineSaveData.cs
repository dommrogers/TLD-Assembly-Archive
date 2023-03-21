using Cpp2ILInjected.CallAnalysis;

public class Feat_EfficientMachineSaveData
{
	public float m_ElapsedHours;

	public float m_HoursAccumulator;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Feat_EfficientMachineSaveData()
	{
	}
}
