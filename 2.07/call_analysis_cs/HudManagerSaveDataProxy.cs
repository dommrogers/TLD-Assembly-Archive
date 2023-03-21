using Cpp2ILInjected.CallAnalysis;

public class HudManagerSaveDataProxy
{
	public bool m_ShowDebugInfo;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public HudManagerSaveDataProxy()
	{
	}
}
