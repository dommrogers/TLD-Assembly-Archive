using Cpp2ILInjected.CallAnalysis;

public class RegionInfo
{
	public string m_SceneName;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public RegionInfo()
	{
	}
}
