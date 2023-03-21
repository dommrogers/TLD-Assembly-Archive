using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public struct GearItemObject
{
	public readonly GearItem m_GearItem;

	public readonly string m_GearItemName;

	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Container), Member = "InstantiateGearPrefabInContainer")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Container), Member = "AddGear")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CraftingRequirementTool), Member = "Enable")]
	public GearItemObject(GearItem gearItem)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Inventory), Member = "QuickSelectionHandleInventoryItemRemoval")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "RefreshTools")]
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
