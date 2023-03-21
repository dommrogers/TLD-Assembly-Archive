using Cpp2ILInjected.CallAnalysis;

public class HudManagerSaveDataProxy
{
	public bool m_ShowDebugInfo;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public HudManagerSaveDataProxy()
	{
	}
}
