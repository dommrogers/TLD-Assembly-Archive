using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public struct GearItemObject
{
	public readonly GearItem m_GearItem;

	public readonly string m_GearItemName;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[CalledBy(Type = typeof(CraftingRequirementTool), Member = "Enable")]
	[CalledBy(Type = typeof(Container), Member = "AddGear")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	public GearItemObject(GearItem gearItem)
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "RemoveGameObjectInInventory")]
	[CalledBy(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[CalledBy(Type = typeof(Inventory), Member = "QuickSelectionHandleInventoryItemRemoval")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "RefreshTools")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public static implicit operator GameObject(GearItemObject gearItemObject)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static implicit operator GearItem(GearItemObject gearItemObject)
	{
		return null;
	}
}
