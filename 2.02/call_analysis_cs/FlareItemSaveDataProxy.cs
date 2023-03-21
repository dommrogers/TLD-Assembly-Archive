using Cpp2ILInjected.CallAnalysis;

public class FlareItemSaveDataProxy
{
	public float m_HoursPlayed;

	public FlareState m_StateProxy;

	public float m_ElapsedBurnMinutesProxy;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public FlareItemSaveDataProxy()
	{
	}
}
