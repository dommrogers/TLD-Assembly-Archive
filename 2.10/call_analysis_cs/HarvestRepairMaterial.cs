using Cpp2ILInjected.CallAnalysis;
using TLD.SaveState;
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
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	public void ShowItem(GearItem gearItem, int stackNum, bool hasItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	public void ShowLiquid(GearLiquidTypeEnum liquidType, float amount, bool hasItem)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHarvest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 8)]
	public void ShowPowder(GearPowderType type, float amount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	public void ShowItemFractionalStack(GearItem gearItem, int stackNum, int stackInInventory)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	public void ShowLiquidFractionalStack(GearLiquidTypeEnum liquidType, float amount, float amountInInventory)
	{
	}

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
	[CallerCount(Count = 15)]
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
	public HarvestRepairMaterial()
	{
	}
}
