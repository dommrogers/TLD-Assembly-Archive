using Cpp2ILInjected.CallAnalysis;

public class RestSaveDataProxy
{
	public int m_LastDisplayedDayNumberOnAwake;

	public int[] m_LastTwentyFourHoursOfSleep;

	public bool m_PassTimeIsLocked;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public RestSaveDataProxy()
	{
	}
}
