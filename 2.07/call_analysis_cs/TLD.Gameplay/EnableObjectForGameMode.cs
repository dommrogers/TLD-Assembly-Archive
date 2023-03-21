using Cpp2ILInjected.CallAnalysis;
using TLD.GameplayTags;
using UnityEngine;

namespace TLD.Gameplay;

public class EnableObjectForGameMode : MonoBehaviour, IShouldDisableForCurrentMode
{
	private GameplayTag[] m_EnableIfAnyActive;

	private GameObject m_ObjectToEnable;

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(EnableObjectForGameMode), Member = "ShouldDisableForCurrentMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsGunOrAmmoOrCasingOfType")]
	[Calls(Type = typeof(GearItem), Member = "IsGunOrAmmoOrCasingOfType")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[CalledBy(Type = typeof(EnableObjectForGameMode), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	public bool ShouldDisableForCurrentMode()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public EnableObjectForGameMode()
	{
	}
}
