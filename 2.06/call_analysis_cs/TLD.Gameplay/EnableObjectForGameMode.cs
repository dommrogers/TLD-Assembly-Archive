using Cpp2ILInjected.CallAnalysis;
using TLD.GameplayTags;
using UnityEngine;

namespace TLD.Gameplay;

public class EnableObjectForGameMode : MonoBehaviour, IShouldDisableForCurrentMode
{
	private GameplayTag[] m_EnableIfAnyActive;

	private GameObject m_ObjectToEnable;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnableObjectForGameMode), Member = "ShouldDisableForCurrentMode")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(EnableObjectForGameMode), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GearItem), Member = "IsGunOrAmmoOrCasingOfType")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool ShouldDisableForCurrentMode()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public EnableObjectForGameMode()
	{
	}
}
