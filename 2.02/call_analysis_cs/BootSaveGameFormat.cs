using Cpp2ILInjected.CallAnalysis;

public class BootSaveGameFormat
{
	public string m_SceneName;

	public int m_Version;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public BootSaveGameFormat()
	{
	}
}
