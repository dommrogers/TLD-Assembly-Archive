using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class GearSaveList
{
	public List<GearSaveData> m_SerializedItems;

	public List<string> m_SpawnedGearInOldSavesGUIDs;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(GearManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 14)]
	public GearSaveList()
	{
	}
}
