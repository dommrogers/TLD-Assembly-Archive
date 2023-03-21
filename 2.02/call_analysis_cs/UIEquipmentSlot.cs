using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIEquipmentSlot : UIItemSlot
{
	public InvEquipment equipment;

	public InvBaseItem.Slot slot;

	protected override InvGameItem observedItem
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InvEquipment), Member = "Replace")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override InvGameItem Replace(InvGameItem item)
	{
		return null;
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(UIItemSlot), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public UIEquipmentSlot()
	{
	}
}
