using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FeatEnabledTrackerSaveData
{
	public List<FeatType> m_FeatsEnabledThisSandbox;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public FeatEnabledTrackerSaveData()
	{
	}
}
