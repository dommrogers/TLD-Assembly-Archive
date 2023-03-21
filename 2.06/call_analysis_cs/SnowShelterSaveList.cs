using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SnowShelterSaveList
{
	public List<SnowShelterSaveData> m_SerializedSnowShelters;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public SnowShelterSaveList()
	{
	}
}
