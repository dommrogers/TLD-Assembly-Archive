using Cpp2ILInjected.CallAnalysis;

public class BootSaveGameFormat
{
	public string m_SceneName;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public BootSaveGameFormat()
	{
	}
}
