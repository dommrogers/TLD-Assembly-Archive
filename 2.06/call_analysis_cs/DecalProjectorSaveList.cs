using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class DecalProjectorSaveList
{
	public List<DecalProjectorSaveData> m_SerializedDecalProjectors;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public DecalProjectorSaveList()
	{
	}
}
