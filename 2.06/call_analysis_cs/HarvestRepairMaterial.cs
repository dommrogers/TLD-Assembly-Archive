using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HarvestRepairMaterial : MonoBehaviour
{
	public UITexture m_GearSprite;

	public UILabel m_GearLabel;

	public UILabel m_StackLabel;

	public UISprite m_DontHaveSprite;

	public UILabel m_LiquidLabel;

	public Color m_RedColorToUse;

	private Color m_GearLabelOrigColor;

	private bool m_HasGottenOrigColor;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	public void ShowItem(GearItem gearItem, int stackNum)
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHarvest")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "RefreshRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdateRequiredMaterialsObject")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "RefreshRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "RefreshRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRequiredMaterialsObject")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHarvest")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMaterialsTable")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "RefreshYield")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Refresh")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void ShowItem(GearItem gearItem, int stackNum, bool hasItem)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	public void ShowLiquid(GearLiquidTypeEnum liquidType, float amount, bool hasItem)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHarvest")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	public void ShowPowder(GearPowderType type, float amount)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	public void ShowItemFractionalStack(GearItem gearItem, int stackNum, int stackInInventory)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void ShowLiquidFractionalStack(GearLiquidTypeEnum liquidType, float amount, float amountInInventory)
	{
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshDismantlePanel")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshDismantlePanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshDismantlePanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshDismantlePanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHarvest")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "RefreshYield")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMaterialsTable")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "RefreshYield")]
	public void Hide()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void GetOrigColor()
	{
	}

	[CallerCount(Count = 0)]
	public HarvestRepairMaterial()
	{
	}
}
