using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class GearSaveList
{
	public List<GearSaveData> m_SerializedItems;

	public List<string> m_SpawnedGearInOldSavesGUIDs;

	[CalledBy(Type = typeof(GearItemInteractabilityControlSaveData), Member = ".ctor")]
	[CalledBy(Type = typeof(GearManager), Member = "Serialize")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public GearSaveList()
	{
	}
}
