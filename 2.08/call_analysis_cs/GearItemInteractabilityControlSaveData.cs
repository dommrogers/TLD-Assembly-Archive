using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class GearItemInteractabilityControlSaveData
{
	public string m_Guid;

	public GearSaveList m_GearSaveList;

	public List<GearItemInteractabilityControlSpawnTransformSaveData> m_SpawnTransforms;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearSaveList), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GearItemInteractabilityControlSaveData()
	{
	}
}
