using Cpp2ILInjected.CallAnalysis;

public class BootSaveGameFormat
{
	public string m_SceneName;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public BootSaveGameFormat()
	{
	}
}
