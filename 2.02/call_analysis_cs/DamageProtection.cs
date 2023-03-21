using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DamageProtection : MonoBehaviour
{
	private bool m_ShouldShowNewBuff;

	private ProtectionBuff m_ProtectionBuff;

	private const float NEUTRAL_MODIFIER = 0f;

	private Dictionary<ProtectionType, GearItem> m_DamageProtectionItems;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(DamageProtection), Member = "ApplyProtectionBuff")]
	[Calls(Type = typeof(DamageProtection), Member = "RemoveProtectionBuff")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TakeOffClothingItem")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	public void MaybeUpdateDamageProtection(GearItem gearItem)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyPercentDamageToTopMostLayer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyPercentDamageToWornClothing")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DamageProtection), Member = "HasDamageProtection")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public float MaybeApplyClothingDamageProtection(DamageReason damageReason, GearItem gi)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DamageProtection), Member = "HasDamageProtection")]
	[Calls(Type = typeof(DamageProtection), Member = "GetTotalAnimalDamageModifier")]
	public float MaybeApplyAnimalDamageProtection(DamageReason damageReason, WildlifeType wildlifeType)
	{
		return default(float);
	}

	[Calls(Type = typeof(DamageProtection), Member = "GetTotalBrokenRibModifier")]
	[Calls(Type = typeof(DamageProtection), Member = "HasDamageProtection")]
	[CallerCount(Count = 0)]
	public float MaybeApplyBrokenRibModifier(DamageReason damageReason, WildlifeType wildlifeTyp)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[CallsUnknownMethods(Count = 13)]
	public List<AfflictionBodyArea> GetBodyAreasToPreventBloodLoss()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(DamageProtection), Member = "MaybeApplyAnimalDamageProtection")]
	[CalledBy(Type = typeof(DamageProtection), Member = "MaybeApplyClothingDamageProtection")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DamageProtection), Member = "MaybeApplyBrokenRibModifier")]
	public bool HasDamageProtection()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public string GetAfflictionDescription(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 3)]
	public string GetAfflictionCause(int index)
	{
		return null;
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	public AfflictionBodyArea GetAfflictionBodyArea(int index)
	{
		return default(AfflictionBodyArea);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int GetDamageAfflictionsCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private bool ShouldUpdateBuffNotification()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DamageProtection), Member = "Update")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	private void ApplyProtectionBuff()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[CalledBy(Type = typeof(DamageProtection), Member = "Update")]
	private void RemoveProtectionBuff()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool HasBallisticVest()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private GearItem GetBallisticVestItem()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(DamageProtection), Member = "MaybeApplyAnimalDamageProtection")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CallsUnknownMethods(Count = 5)]
	private float GetTotalAnimalDamageModifier()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(DamageProtection), Member = "MaybeApplyBrokenRibModifier")]
	private float GetTotalBrokenRibModifier()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(DamageProtection), Member = "GetAfflictionDescription")]
	[CalledBy(Type = typeof(DamageProtection), Member = "GetAfflictionCause")]
	[CalledBy(Type = typeof(DamageProtection), Member = "GetAfflictionBodyArea")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	private GearItem GetAfflictionGearItem(int index)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public DamageProtection()
	{
	}
}
