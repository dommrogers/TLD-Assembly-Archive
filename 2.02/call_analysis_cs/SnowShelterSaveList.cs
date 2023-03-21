using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SnowShelterSaveList
{
	public List<SnowShelterSaveData> m_SerializedSnowShelters;

	[CalledBy(Type = typeof(SnowShelterManager), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public SnowShelterSaveList()
	{
	}
}
