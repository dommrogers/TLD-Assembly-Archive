using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SnowShelterSaveList
{
	public List<SnowShelterSaveData> m_SerializedSnowShelters;

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "SerializeAll")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public SnowShelterSaveList()
	{
	}
}
