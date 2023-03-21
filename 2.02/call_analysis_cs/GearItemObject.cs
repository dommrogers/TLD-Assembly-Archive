using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public struct GearItemObject
{
	public readonly GearItem m_GearItem;

	public readonly string m_GearItemName;

	[CalledBy(Type = typeof(CraftingRequirementTool), Member = "Enable")]
	[CalledBy(Type = typeof(Container), Member = "AddGear")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GearItemObject(GearItem gearItem)
	{
	}

	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "RefreshTools")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[CalledBy(Type = typeof(Inventory), Member = "QuickSelectionHandleInventoryItemRemoval")]
	[CalledBy(Type = typeof(Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveGameObjectInInventory")]
	[CalledBy(Type = typeof(Inventory), Member = "DestroyAllGear")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
