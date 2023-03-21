using Cpp2ILInjected.CallAnalysis;

public class RockCacheDataProxy
{
	public string m_Guid;

	public string m_RegionName;

	public string m_SceneName;

	public bool m_UserPlaced;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public RockCacheDataProxy()
	{
	}
}
