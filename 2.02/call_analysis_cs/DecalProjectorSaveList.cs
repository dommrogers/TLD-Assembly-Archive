using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class DecalProjectorSaveList
{
	public List<DecalProjectorSaveData> m_SerializedDecalProjectors;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 7)]
	public DecalProjectorSaveList()
	{
	}
}
