using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using UnityEngine;

public class CraftingRequirementMaterial : MonoBehaviour
{
	public UILabel m_Display;

	public UITexture m_Icon;

	private Color m_DisplayTint;

	private Color m_IconTint;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 1)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void Disable()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "RefreshMaterialDisplay")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "ApplyTints")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(BlueprintData), Member = "NumNeedsConsuming")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	public void Enable(Panel_Crafting panel, BlueprintData bp, InProgressCraftItem wip, int requiredIndex, int quantity)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "RefreshMaterialDisplay")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "ApplyTints")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityString")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	public void EnableForKerosene(Panel_Crafting panel, BlueprintData bp, InProgressCraftItem wip, int quantity)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "RefreshMaterialDisplay")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "ApplyTints")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalPowderWeight")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public void EnableForGunpowder(Panel_Crafting panel, BlueprintData bp, InProgressCraftItem wip, int quantity)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForGunpowder")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "Enable")]
	private void ApplyTints(bool requirementsMet, Color requirementsNotMetTint)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CraftingRequirementMaterial()
	{
	}
}
