using Cpp2ILInjected.CallAnalysis;

public class LightsourceSaveDataProxy
{
	public string m_Guid;

	public bool m_IsOn;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public LightsourceSaveDataProxy()
	{
	}
}
