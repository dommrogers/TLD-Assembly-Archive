using Cpp2ILInjected.CallAnalysis;

public class LightsourceSaveDataProxy
{
	public string m_Guid;

	public bool m_IsOn;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public LightsourceSaveDataProxy()
	{
	}
}
