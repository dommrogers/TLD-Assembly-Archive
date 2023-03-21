using Cpp2ILInjected.CallAnalysis;
using TLD.GameplayTags;
using UnityEngine;

namespace TLD.Gameplay;

public class DisableObjectForGameMode : MonoBehaviour, IShouldDisableForCurrentMode
{
	private GameplayTag[] m_DisableIfAnyActive;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DisableObjectForGameMode), Member = "ShouldDisableForCurrentMode")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(GearItem), Member = "IsGunOrAmmoOrCasingOfType")]
	[Calls(Type = typeof(GearItem), Member = "IsGunOrAmmoOrCasingOfType")]
	[CalledBy(Type = typeof(DisableObjectForGameMode), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public bool ShouldDisableForCurrentMode()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public DisableObjectForGameMode()
	{
	}
}
