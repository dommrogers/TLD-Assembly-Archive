using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnableObjectForXPMode : MonoBehaviour
{
	public List<ExperienceModeType> m_XPModesToEnable;

	public bool m_HandleStoryModesSeparately;

	public GameObject m_ObjectToEnable;

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "RecheckDisableObjectForXPMode")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "RecheckDisableObjectForXPMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(EnableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "ReviewObjectFiltering")]
	[CalledBy(Type = typeof(EnableObjectForXPMode), Member = "Update")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Serialize")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomLootXPType")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Utils), Member = "IsGunOrAmmoOrCasingOfType")]
	[Calls(Type = typeof(Utils), Member = "IsGunOrAmmoOrCasingOfType")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	public bool ShouldDisableForCurrentMode()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public EnableObjectForXPMode()
	{
	}
}
