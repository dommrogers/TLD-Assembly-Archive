using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SnowShelterSaveList
{
	public List<SnowShelterSaveData> m_SerializedSnowShelters;

	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public SnowShelterSaveList()
	{
	}
}
