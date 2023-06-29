using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class BodyHarvestSaveList
{
	public List<BodyHarvestSaveData> m_SerializedBodyHarvests;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BodyHarvestSaveList()
	{
	}
}
