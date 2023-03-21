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
		[CallerCount(Count = 28)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(UIEquipmentSlot), Member = "Replace")]
	[Calls(Type = typeof(InvAttachmentPoint), Member = "Attach")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(InvAttachmentPoint), Member = "Attach")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvGameItem), Member = "get_name")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(InvEquipment), Member = "Unequip")]
	[CalledBy(Type = typeof(InvEquipment), Member = "Equip")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(InvEquipment), Member = "Unequip")]
	public InvGameItem Replace(InvBaseItem.Slot slot, InvGameItem item)
	{
		return null;
	}

	[Calls(Type = typeof(InvEquipment), Member = "Replace")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(EquipItems), Member = "Start")]
	[CalledBy(Type = typeof(EquipRandomItem), Member = "OnClick")]
	public InvGameItem Equip(InvGameItem item)
	{
		return null;
	}

	[Calls(Type = typeof(InvEquipment), Member = "Replace")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallerCount(Count = 0)]
	public InvGameItem Unequip(InvGameItem item)
	{
		return null;
	}

	[Calls(Type = typeof(InvEquipment), Member = "Replace")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	public bool HasEquipped(InvBaseItem.Slot slot)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public InvGameItem GetItem(InvBaseItem.Slot slot)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InvEquipment()
	{
	}
}
