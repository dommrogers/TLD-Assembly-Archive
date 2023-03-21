using Cpp2ILInjected.CallAnalysis;

public class PackManagerGlobalDataProxy
{
	public bool m_IsPackNearbyFlag;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public PackManagerGlobalDataProxy()
	{
	}
}
