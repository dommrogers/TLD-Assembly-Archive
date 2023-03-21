using System.Globalization;
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

	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "RefreshYield")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMaterialsTable")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHarvest")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "RefreshRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdateRequiredMaterialsObject")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "RefreshRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRequiredMaterialsObject")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 19)]
	public void ShowItem(GearItem gearItem, int stackNum, bool hasItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 20)]
	public void ShowLiquid(GearLiquidTypeEnum liquidType, float amount, bool hasItem)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHarvest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 26)]
	public void ShowPowder(GearPowderType type, float amount)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "RefreshCraftingRequiredMaterials")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 19)]
	public void ShowItemFractionalStack(GearItem gearItem, int stackNum, int stackInInventory)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "RefreshCraftingRequiredMaterials")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 22)]
	public void ShowLiquidFractionalStack(GearLiquidTypeEnum liquidType, float amount, float amountInInventory)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "RefreshCraftingRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "RefreshYield")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMaterialsTable")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHarvest")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshDismantlePanel")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshDismantlePanel")]
	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Hide()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void GetOrigColor()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HarvestRepairMaterial()
	{
	}
}
