using Cpp2ILInjected.CallAnalysis;

public class WellFedSaveDataProxy
{
	public bool m_Active;

	public float m_ElapsedHoursNotStarving;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public WellFedSaveDataProxy()
	{
	}
}
