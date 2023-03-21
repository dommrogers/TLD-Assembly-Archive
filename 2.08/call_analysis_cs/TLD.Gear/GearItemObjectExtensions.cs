using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

namespace TLD.Gear;

public static class GearItemObjectExtensions
{
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_use_best_gearitem")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestGearItemWithName")]
	[CalledBy(Type = typeof(CraftingRequirementTool), Member = "Enable")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public static GearItem GetBestGearItemWithName(this List<GearItemObject> items, string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[CalledBy(Type = typeof(Action_GetContainerItemCount), Member = "DoContainerCheck")]
	[CalledBy(Type = typeof(Action_GetContainerItemCount), Member = "DoContainerCheck")]
	[CalledBy(Type = typeof(Inventory), Member = "GetNumGearWithName")]
	[CalledBy(Type = typeof(Inventory), Member = "NumGearInInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "HasMaterialsForRepair")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "HasMaterialsForRepair")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshWaterSources")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[CalledBy(Type = typeof(AfflictionRemedy), Member = "PlayerHasRequiredRemedy")]
	[CalledBy(Type = typeof(BowItem), Member = "GetNumArrowsInInventory")]
	[CalledBy(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[CalledBy(Type = typeof(CraftingRequirementQuantitySelect), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(Container), Member = "GetNumGearWithName")]
	public static int NumGearInList(this List<GearItemObject> items, string gearName)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Inventory), Member = "NumGearInInventory")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetNumClothInInventory")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetNumSticksInInventory")]
	public static int NumGearInList(this List<GearItemObject> items, GearItemData gearItemData)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "CanMoveAllToContainer")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[CalledBy(Type = typeof(Container), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	public static float GetTotalWeightKG(this List<GearItemObject> items)
	{
		return default(float);
	}

	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetMeatAmount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetLiquidItemAmount")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetLiquidItemAmount")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetLiquidItemAmount")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetMeatAmount")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetMeatAmount")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetMeatAmount")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetMeatAmount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetWaterAmount")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Container), Member = "GetMeasurableTotalByType")]
	[CalledBy(Type = typeof(Inventory), Member = "GetMeasurableTotalByType")]
	[CalledBy(Type = typeof(Action_GetContainerItemCount), Member = "DoContainerCheck")]
	[CalledBy(Type = typeof(Action_GetInvItemCount), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetMeatAmount")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	public static int GetMeasurableTotalByTypeInList(this List<GearItemObject> items, string type)
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
	[CallsUnknownMethods(Count = 2)]
	private static float GetWaterAmount(List<GearItemObject> items, bool includeNonPotable, bool includePotable)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CallerCount(Count = 6)]
	private static float GetMeatAmount(List<GearItemObject> items, bool includeFish, bool includeRawFish, bool includeMeat, bool includeRawMeat, bool includeMeatType, GearMeatTypeEnum meatType)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private static float GetLiquidItemAmount(this List<GearItemObject> items, GearLiquidTypeEnum type)
	{
		return default(float);
	}
}
