using Cpp2ILInjected.CallAnalysis;

public class AuroraScreenInfo
{
	public string m_PrefabName;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AuroraScreenInfo()
	{
	}
}
