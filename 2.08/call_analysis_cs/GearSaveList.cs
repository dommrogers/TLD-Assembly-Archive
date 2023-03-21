using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class GearSaveList
{
	public List<GearSaveData> m_SerializedItems;

	public List<string> m_SpawnedGearInOldSavesGUIDs;

	[CalledBy(Type = typeof(GearManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "Serialize")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItemInteractabilityControlSaveData), Member = ".ctor")]
	public GearSaveList()
	{
	}
}
