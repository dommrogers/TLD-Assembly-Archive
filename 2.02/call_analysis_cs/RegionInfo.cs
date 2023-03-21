using Cpp2ILInjected.CallAnalysis;

public class RegionInfo
{
	public string m_SceneName;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public RegionInfo()
	{
	}
}
