using Cpp2ILInjected.CallAnalysis;

public class PackManagerGlobalDataProxy
{
	public bool m_IsPackNearbyFlag;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public PackManagerGlobalDataProxy()
	{
	}
}
