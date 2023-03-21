using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

namespace TLD.Gear;

public class StartGear : MonoBehaviour
{
	public StartGearData m_DefaultStartGear;

	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Action_OverrideStartGear), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public void AddAllToInventory()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public StartGear()
	{
	}
}
