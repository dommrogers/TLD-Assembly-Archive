using Cpp2ILInjected.CallAnalysis;

public class RockCacheDestroyedInfo
{
	public string m_SceneName;

	public string m_Guid;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public RockCacheDestroyedInfo()
	{
	}
}
