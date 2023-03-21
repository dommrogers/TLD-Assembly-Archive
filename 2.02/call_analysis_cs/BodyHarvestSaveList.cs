using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class BodyHarvestSaveList
{
	public List<BodyHarvestSaveData> m_SerializedBodyHarvests;

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public BodyHarvestSaveList()
	{
	}
}
