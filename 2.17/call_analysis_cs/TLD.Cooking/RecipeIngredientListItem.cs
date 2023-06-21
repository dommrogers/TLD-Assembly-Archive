using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Gear;
using TLD.SaveState;
using UnityEngine;

namespace TLD.Cooking;

public class RecipeIngredientListItem : MonoBehaviour
{
	private UIButton m_Button;

	private TweenScale m_TweenScale;

	private GameObject m_ItemElements;

	private GameObject m_Selected;

	private GameObject m_RuinedState;

	private UILabel m_NameLabel;

	private UITexture m_Icon;

	private UILabel m_RequirementLabel;

	private GameObject m_RequirementsMetIndicator;

	private Color m_HasIngredientColor;

	private Color m_MissingIngredientColor;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetSelected(bool isSelected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetRequirementByQuantity")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetRequirementByCount")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItemData), Member = "get_DisplayName")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetName")]
	[CallsUnknownMethods(Count = 1)]
	public void SetRecipeRequirement(BlueprintData.RequiredGearItem requiredGear, Inventory inventory)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetTotalPowderWeight")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetLabels")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetRequirementMet")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetIconFromGearItemData")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetName")]
	[CallsUnknownMethods(Count = 1)]
	public void SetRecipeRequirement(BlueprintData.RequiredPowder requiredPowder, Inventory inventory)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetTotalLiquidVolume")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetLabels")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetRequirementMet")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetIconFromGearItemData")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetName")]
	[CallsUnknownMethods(Count = 1)]
	public void SetRecipeRequirement(BlueprintData.RequiredLiquid requiredLiquid, Inventory inventory)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetLabels")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetRequirementMet")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetIconFromGearItem")]
	[Calls(Type = typeof(GearItemData), Member = "get_DisplayName")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetRecipeRequirement(float cookableRequiredWater, Inventory inventory)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateRecipeIngredients")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRecipeRequirement")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRecipeRequirement")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRecipeRequirement")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRequirementByCount")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRequirementByQuantity")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetRequirementMet(bool isMet)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateRecipeIngredients")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRecipeRequirement")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRecipeRequirement")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRecipeRequirement")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRecipeRequirement")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void SetName(string ingredientName)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateRecipeIngredients")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRecipeRequirement")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRecipeRequirement")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRecipeRequirement")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRequirementByQuantity")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void SetLabels(float inventoryAmount, float requiredAmount, bool isMass)
	{
	}

	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRequirementByCount")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetLabels(int inventoryCount, int ruinedCount, int requirementCount)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateRecipeIngredients")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRecipeRequirement")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRequirementByCount")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRequirementByQuantity")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetIconFromGearItem(GearItem gearItem)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateRecipeIngredients")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRecipeRequirement")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRecipeRequirement")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void SetIconFromGearItemData(GearItemData gearItemData)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateRecipeIngredients")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRecipeRequirement")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetLabels")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetRequirementMet")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetIconFromGearItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private int SetRequirementByCount(GearItem item, int count, Inventory inventory)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateRecipeIngredients")]
	[CalledBy(Type = typeof(RecipeIngredientListItem), Member = "SetRecipeRequirement")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetLabels")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetRequirementMet")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetIconFromGearItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private float SetRequirementByQuantity(GearItem item, float quantity, Inventory inventory)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public RecipeIngredientListItem()
	{
	}
}
