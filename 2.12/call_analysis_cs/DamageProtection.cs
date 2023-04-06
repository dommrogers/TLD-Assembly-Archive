using System.Collections.Generic;
using System.Linq;
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

	[CalledBy(Type = typeof(PlayerManager), Member = "TakeOffClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void MaybeUpdateDamageProtection(GearItem gearItem)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyPercentDamageToWornClothing")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyPercentDamageToTopMostLayer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float MaybeApplyClothingDamageProtection(DamageReason damageReason, GearItem gi)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DamageProtection), Member = "GetTotalAnimalDamageModifier")]
	[CallsUnknownMethods(Count = 1)]
	public float MaybeApplyAnimalDamageProtection(DamageReason damageReason, WildlifeType wildlifeType)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DamageProtection), Member = "GetTotalBrokenRibModifier")]
	[CallsUnknownMethods(Count = 1)]
	public float MaybeApplyBrokenRibModifier(DamageReason damageReason, WildlifeType wildlifeTyp)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public List<AfflictionBodyArea> GetBodyAreasToPreventBloodLoss()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasDamageProtection()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetAfflictionDescription(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetAfflictionCause(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public AfflictionBodyArea GetAfflictionBodyArea(int index)
	{
		return default(AfflictionBodyArea);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetDamageAfflictionsCount()
	{
		return 0;
	}

	[CalledBy(Type = typeof(DamageProtection), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldUpdateBuffNotification()
	{
		return false;
	}

	[CalledBy(Type = typeof(DamageProtection), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyProtectionBuff()
	{
	}

	[CalledBy(Type = typeof(DamageProtection), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveProtectionBuff()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasBallisticVest()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private GearItem GetBallisticVestItem()
	{
		return null;
	}

	[CalledBy(Type = typeof(DamageProtection), Member = "MaybeApplyAnimalDamageProtection")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private float GetTotalAnimalDamageModifier()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(DamageProtection), Member = "MaybeApplyBrokenRibModifier")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private float GetTotalBrokenRibModifier()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(DamageProtection), Member = "GetAfflictionDescription")]
	[CalledBy(Type = typeof(DamageProtection), Member = "GetAfflictionCause")]
	[CalledBy(Type = typeof(DamageProtection), Member = "GetAfflictionBodyArea")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt")]
	[CallsUnknownMethods(Count = 1)]
	private GearItem GetAfflictionGearItem(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DamageProtection()
	{
	}
}
