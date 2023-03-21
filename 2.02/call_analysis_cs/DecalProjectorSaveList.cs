using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class DecalProjectorSaveList
{
	public List<DecalProjectorSaveData> m_SerializedDecalProjectors;

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public DecalProjectorSaveList()
	{
	}
}
