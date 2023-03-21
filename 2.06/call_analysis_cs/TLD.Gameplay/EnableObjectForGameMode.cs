using Cpp2ILInjected.CallAnalysis;
using TLD.GameplayTags;
using UnityEngine;

namespace TLD.Gameplay;

public class EnableObjectForGameMode : MonoBehaviour, IShouldDisableForCurrentMode
{
	private GameplayTag[] m_EnableIfAnyActive;

	private GameObject m_ObjectToEnable;

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EnableObjectForGameMode), Member = "ShouldDisableForCurrentMode")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(EnableObjectForGameMode), Member = "Update")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "IsGunOrAmmoOrCasingOfType")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsGunOrAmmoOrCasingOfType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public bool ShouldDisableForCurrentMode()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public EnableObjectForGameMode()
	{
	}
}
