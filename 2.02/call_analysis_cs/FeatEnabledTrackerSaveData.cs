using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FeatEnabledTrackerSaveData
{
	public List<FeatType> m_FeatsEnabledThisSandbox;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public FeatEnabledTrackerSaveData()
	{
	}
}
