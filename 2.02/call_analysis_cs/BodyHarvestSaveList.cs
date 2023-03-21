using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class BodyHarvestSaveList
{
	public List<BodyHarvestSaveData> m_SerializedBodyHarvests;

	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public BodyHarvestSaveList()
	{
	}
}
