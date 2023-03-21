using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InvEquipment : MonoBehaviour
{
	private InvGameItem[] mItems;

	private InvAttachmentPoint[] mAttachments;

	public InvGameItem[] equippedItems
	{
		[CallerCount(Count = 29)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(InvEquipment), Member = "Unequip")]
	[Calls(Type = typeof(InvAttachmentPoint), Member = "Attach")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CalledBy(Type = typeof(UIEquipmentSlot), Member = "Replace")]
	[CalledBy(Type = typeof(InvEquipment), Member = "Equip")]
	[CalledBy(Type = typeof(InvEquipment), Member = "Unequip")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvGameItem), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	public InvGameItem Replace(InvBaseItem.Slot slot, InvGameItem item)
	{
		return null;
	}

	[CalledBy(Type = typeof(EquipRandomItem), Member = "OnClick")]
	[CalledBy(Type = typeof(EquipItems), Member = "Start")]
	[Calls(Type = typeof(InvEquipment), Member = "Replace")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public InvGameItem Equip(InvGameItem item)
	{
		return null;
	}

	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvEquipment), Member = "Replace")]
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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool HasEquipped(InvGameItem item)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public bool HasEquipped(InvBaseItem.Slot slot)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public InvGameItem GetItem(InvBaseItem.Slot slot)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public InvEquipment()
	{
	}
}
