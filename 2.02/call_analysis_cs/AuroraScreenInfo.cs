using Cpp2ILInjected.CallAnalysis;

public class AuroraScreenInfo
{
	public string m_PrefabName;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public AuroraScreenInfo()
	{
	}
}
