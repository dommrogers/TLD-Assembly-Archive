using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FeatEnabledTrackerSaveData
{
	public List<FeatType> m_FeatsEnabledThisSandbox;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public FeatEnabledTrackerSaveData()
	{
	}
}
