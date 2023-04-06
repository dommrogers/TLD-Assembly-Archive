using Cpp2ILInjected.CallAnalysis;
using TLD.GameplayTags;
using UnityEngine;

namespace TLD.Gameplay;

public class DisableObjectForGameMode : MonoBehaviour, IShouldDisableForCurrentMode
{
	private GameplayTag[] m_DisableIfAnyActive;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DisableObjectForGameMode), Member = "ShouldDisableForCurrentMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(DisableObjectForGameMode), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsGunOrAmmoOrCasingOfType")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public bool ShouldDisableForCurrentMode()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DisableObjectForGameMode()
	{
	}
}
