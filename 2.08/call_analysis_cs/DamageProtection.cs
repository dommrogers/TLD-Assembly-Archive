using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class DamageProtection : MonoBehaviour
{
	private PanelReference<Panel_HUD> m_HUD;

	private bool m_ShouldShowNewBuff;

	private ProtectionBuff m_ProtectionBuff;

	private const float NEUTRAL_MODIFIER = 0f;

	private Dictionary<ProtectionType, GearItem> m_DamageProtectionItems;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DamageProtection), Member = "ShouldUpdateBuffNotification")]
	[Calls(Type = typeof(DamageProtection), Member = "RemoveProtectionBuff")]
	[Calls(Type = typeof(DamageProtection), Member = "ApplyProtectionBuff")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TakeOffClothingItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void MaybeUpdateDamageProtection(GearItem gearItem)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyPercentDamageToTopMostLayer")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyPercentDamageToWornClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float MaybeApplyClothingDamageProtection(DamageReason damageReason, GearItem gi)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DamageProtection), Member = "GetTotalAnimalDamageModifier")]
	[CallsUnknownMethods(Count = 1)]
	public float MaybeApplyAnimalDamageProtection(DamageReason damageReason, WildlifeType wildlifeType)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DamageProtection), Member = "GetTotalBrokenRibModifier")]
	public float MaybeApplyBrokenRibModifier(DamageReason damageReason, WildlifeType wildlifeTyp)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	public List<AfflictionBodyArea> GetBodyAreasToPreventBloodLoss()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasDamageProtection()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public string GetAfflictionDescription(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetAfflictionCause(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public AfflictionBodyArea GetAfflictionBodyArea(int index)
	{
		return default(AfflictionBodyArea);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetDamageAfflictionsCount()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(DamageProtection), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldUpdateBuffNotification()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	[CalledBy(Type = typeof(DamageProtection), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void ApplyProtectionBuff()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[CalledBy(Type = typeof(DamageProtection), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveProtectionBuff()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasBallisticVest()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private GearItem GetBallisticVestItem()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(DamageProtection), Member = "MaybeApplyAnimalDamageProtection")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CallsUnknownMethods(Count = 9)]
	private float GetTotalAnimalDamageModifier()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[CalledBy(Type = typeof(DamageProtection), Member = "MaybeApplyBrokenRibModifier")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	private float GetTotalBrokenRibModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DamageProtection), Member = "GetAfflictionDescription")]
	[CalledBy(Type = typeof(DamageProtection), Member = "GetAfflictionCause")]
	[CalledBy(Type = typeof(DamageProtection), Member = "GetAfflictionBodyArea")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CallsUnknownMethods(Count = 1)]
	private GearItem GetAfflictionGearItem(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DamageProtection()
	{
	}
}
