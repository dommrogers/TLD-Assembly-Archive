using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public struct GearItemObject
{
	public readonly GearItem m_GearItem;

	public readonly string m_GearItemName;

	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CraftingRequirementTool), Member = "Enable")]
	public GearItemObject(GearItem gearItem)
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[CalledBy(Type = typeof(Inventory), Member = "DestroyAllGear")]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveGameObjectInInventory")]
	[CalledBy(Type = typeof(Inventory), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[CalledBy(Type = typeof(Inventory), Member = "QuickSelectionHandleInventoryItemRemoval")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "RefreshTools")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static implicit operator GameObject(GearItemObject gearItemObject)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static implicit operator GearItem(GearItemObject gearItemObject)
	{
		return null;
	}
}
