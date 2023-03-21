using Cpp2ILInjected.CallAnalysis;

public class RegionInfo
{
	public string m_SceneName;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public RegionInfo()
	{
	}
}
