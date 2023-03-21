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
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DamageProtection), Member = "RemoveProtectionBuff")]
	[Calls(Type = typeof(DamageProtection), Member = "ApplyProtectionBuff")]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TakeOffClothingItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	public void MaybeUpdateDamageProtection(GearItem gearItem)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyPercentDamageToWornClothing")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyPercentDamageToTopMostLayer")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
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

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	public List<AfflictionBodyArea> GetBodyAreasToPreventBloodLoss()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CallsUnknownMethods(Count = 1)]
	public bool HasDamageProtection()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 1)]
	public string GetAfflictionDescription(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public string GetAfflictionCause(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public AfflictionBodyArea GetAfflictionBodyArea(int index)
	{
		return default(AfflictionBodyArea);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public int GetDamageAfflictionsCount()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private bool ShouldUpdateBuffNotification()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	[CalledBy(Type = typeof(DamageProtection), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyProtectionBuff()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DamageProtection), Member = "Update")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private GearItem GetBallisticVestItem()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(DamageProtection), Member = "MaybeApplyAnimalDamageProtection")]
	[CallerCount(Count = 3)]
	private float GetTotalAnimalDamageModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(DamageProtection), Member = "MaybeApplyBrokenRibModifier")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[CallsUnknownMethods(Count = 6)]
	private float GetTotalBrokenRibModifier()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DamageProtection), Member = "GetAfflictionBodyArea")]
	[CalledBy(Type = typeof(DamageProtection), Member = "GetAfflictionCause")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(DamageProtection), Member = "GetAfflictionDescription")]
	private GearItem GetAfflictionGearItem(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DamageProtection()
	{
	}
}
