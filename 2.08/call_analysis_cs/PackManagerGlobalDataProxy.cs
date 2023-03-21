using Cpp2ILInjected.CallAnalysis;

public class PackManagerGlobalDataProxy
{
	public bool m_IsPackNearbyFlag;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PackManagerGlobalDataProxy()
	{
	}
}
