using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using UnityEngine;

public class EnableObjectForXPMode : MonoBehaviour, IShouldDisableForCurrentMode
{
	public List<ExperienceModeType> m_XPModesToEnable;

	public bool m_HandleStoryModesSeparately;

	public GameObject m_ObjectToEnable;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EnableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	public void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(EnableObjectForXPMode), Member = "Update")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomLootXPType")]
	[Calls(Type = typeof(GearItem), Member = "IsGunOrAmmoOrCasingOfType")]
	[Calls(Type = typeof(GearItem), Member = "IsGunOrAmmoOrCasingOfType")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	public bool ShouldDisableForCurrentMode()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public EnableObjectForXPMode()
	{
	}
}
