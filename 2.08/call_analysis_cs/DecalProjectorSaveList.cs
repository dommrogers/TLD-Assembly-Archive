using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class DecalProjectorSaveList
{
	public List<DecalProjectorSaveData> m_SerializedDecalProjectors;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DecalProjectorSaveList()
	{
	}
}
