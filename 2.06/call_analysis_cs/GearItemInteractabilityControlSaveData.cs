using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class GearItemInteractabilityControlSaveData
{
	public string m_Guid;

	public GearSaveList m_GearSaveList;

	public List<GearItemInteractabilityControlSpawnTransformSaveData> m_SpawnTransforms;

	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearSaveList), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public GearItemInteractabilityControlSaveData()
	{
	}
}
