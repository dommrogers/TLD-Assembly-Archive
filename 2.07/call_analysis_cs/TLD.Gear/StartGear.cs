using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

namespace TLD.Gear;

public class StartGear : MonoBehaviour
{
	public StartGearData m_DefaultStartGear;

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(Action_OverrideStartGear), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void AddAllToInventory()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public StartGear()
	{
	}
}
