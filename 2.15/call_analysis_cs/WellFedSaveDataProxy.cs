using Cpp2ILInjected.CallAnalysis;

public class WellFedSaveDataProxy
{
	public bool m_Active;

	public float m_ElapsedHoursNotStarving;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public WellFedSaveDataProxy()
	{
	}
}
