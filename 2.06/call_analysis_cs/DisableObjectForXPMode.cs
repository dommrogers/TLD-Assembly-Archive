using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Gameplay;
using UnityEngine;

public class DisableObjectForXPMode : MonoBehaviour, IShouldDisableForCurrentMode
{
	public List<ExperienceModeType> m_XPModesToDisable;

	public bool m_HandleStoryModesSeparately;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(LootTable), Member = "DisableForXPMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomLootXPType")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(DisableObjectForXPMode), Member = "Update")]
	[Calls(Type = typeof(GearItem), Member = "IsGunOrAmmoOrCasingOfType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "IsGunOrAmmoOrCasingOfType")]
	public bool ShouldDisableForCurrentMode()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CalledBy(Type = typeof(GearManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(Container), Member = "DeserializeAdditive")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "SpawnAndFire")]
	[CalledBy(Type = typeof(GearItem), Member = "InstantiateStackable")]
	[CalledBy(Type = typeof(Action_RestorePlayerInventory), Member = "OnExecute")]
	[CalledBy(Type = typeof(ArrowItem), Member = "Break")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(GearItem), Member = "InstantiateWater")]
	[CallsUnknownMethods(Count = 1)]
	public static void RemoveDisabler(GameObject gameObject)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public DisableObjectForXPMode()
	{
	}
}
