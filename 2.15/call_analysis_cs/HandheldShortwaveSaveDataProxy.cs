using Cpp2ILInjected.CallAnalysis;

public class HandheldShortwaveSaveDataProxy
{
	public string m_TrackingModeName;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public HandheldShortwaveSaveDataProxy()
	{
	}
}
