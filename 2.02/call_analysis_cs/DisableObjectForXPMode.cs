using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisableObjectForXPMode : MonoBehaviour
{
	public List<ExperienceModeType> m_XPModesToDisable;

	public bool m_HandleStoryModesSeparately;

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "RecheckDisableObjectForXPMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(LootTable), Member = "DisableForXPMode")]
	[CalledBy(Type = typeof(Container), Member = "GetPrefabFromScriptedItems")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Serialize")]
	[CalledBy(Type = typeof(DisableObjectForXPMode), Member = "Update")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "ReviewObjectFiltering")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(Utils), Member = "IsGunOrAmmoOrCasingOfType")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomLootXPType")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public bool ShouldDisableForCurrentMode()
	{
		return false;
	}

	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "SpawnAndFire")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "InstantiateStackable")]
	[CalledBy(Type = typeof(GearItem), Member = "InstantiateWater")]
	[CalledBy(Type = typeof(GearManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstatiateItemAtLocation")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryInternal")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void RemoveDisabler(GameObject gameObject)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DisableObjectForXPMode()
	{
	}
}
