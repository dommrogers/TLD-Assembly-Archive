using Cpp2ILInjected.CallAnalysis;

public class HudManagerSaveDataProxy
{
	public bool m_ShowDebugInfo;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public HudManagerSaveDataProxy()
	{
	}
}
