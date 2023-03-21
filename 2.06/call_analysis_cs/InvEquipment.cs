using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InvEquipment : MonoBehaviour
{
	private InvGameItem[] mItems;

	private InvAttachmentPoint[] mAttachments;

	public InvGameItem[] equippedItems
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CalledBy(Type = typeof(UIEquipmentSlot), Member = "Replace")]
	[CalledBy(Type = typeof(InvEquipment), Member = "Equip")]
	[CalledBy(Type = typeof(InvEquipment), Member = "Unequip")]
	[CalledBy(Type = typeof(InvEquipment), Member = "Unequip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(InvAttachmentPoint), Member = "Attach")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InvGameItem), Member = "get_name")]
	public InvGameItem Replace(InvBaseItem.Slot slot, InvGameItem item)
	{
		return null;
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(InvEquipment), Member = "Replace")]
	[CalledBy(Type = typeof(EquipItems), Member = "Start")]
	[CalledBy(Type = typeof(EquipRandomItem), Member = "OnClick")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	public InvGameItem Equip(InvGameItem item)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvEquipment), Member = "Replace")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	public InvGameItem Unequip(InvGameItem item)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvEquipment), Member = "Replace")]
	public InvGameItem Unequip(InvBaseItem.Slot slot)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasEquipped(InvGameItem item)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallsUnknownMethods(Count = 2)]
	public bool HasEquipped(InvBaseItem.Slot slot)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public InvGameItem GetItem(InvBaseItem.Slot slot)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public InvEquipment()
	{
	}
}
