using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InvEquipment : MonoBehaviour
{
	private InvGameItem[] mItems;

	private InvAttachmentPoint[] mAttachments;

	public InvGameItem[] equippedItems
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(UIEquipmentSlot), Member = "Replace")]
	[CalledBy(Type = typeof(InvEquipment), Member = "Equip")]
	[CalledBy(Type = typeof(InvEquipment), Member = "Unequip")]
	[CalledBy(Type = typeof(InvEquipment), Member = "Unequip")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(InvGameItem), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(InvAttachmentPoint), Member = "Attach")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	public InvGameItem Replace(InvBaseItem.Slot slot, InvGameItem item)
	{
		return null;
	}

	[CalledBy(Type = typeof(EquipItems), Member = "Start")]
	[CalledBy(Type = typeof(EquipRandomItem), Member = "OnClick")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(InvEquipment), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	public InvGameItem Equip(InvGameItem item)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(InvEquipment), Member = "Replace")]
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
	[CallsUnknownMethods(Count = 2)]
	public bool HasEquipped(InvGameItem item)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallsUnknownMethods(Count = 3)]
	public bool HasEquipped(InvBaseItem.Slot slot)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
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
