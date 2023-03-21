using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisableObjectForXPMode : MonoBehaviour
{
	public List<ExperienceModeType> m_XPModesToDisable;

	public bool m_HandleStoryModesSeparately;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "RecheckDisableObjectForXPMode")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "RecheckDisableObjectForXPMode")]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(LootTable), Member = "DisableForXPMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomLootXPType")]
	[CalledBy(Type = typeof(Container), Member = "GetPrefabFromScriptedItems")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CalledBy(Type = typeof(DisableObjectForXPMode), Member = "Update")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "ReviewObjectFiltering")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Serialize")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Utils), Member = "IsGunOrAmmoOrCasingOfType")]
	[Calls(Type = typeof(Utils), Member = "IsGunOrAmmoOrCasingOfType")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	public bool ShouldDisableForCurrentMode()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InstatiateItemAtLocation")]
	[CalledBy(Type = typeof(GearManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryInternal")]
	[CalledBy(Type = typeof(GearItem), Member = "InstantiateStackable")]
	[CalledBy(Type = typeof(GearItem), Member = "InstantiateWater")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "SpawnAndFire")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 7)]
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
