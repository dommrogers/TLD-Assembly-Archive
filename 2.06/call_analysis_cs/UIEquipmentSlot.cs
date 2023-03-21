using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIEquipmentSlot : UIItemSlot
{
	public InvEquipment equipment;

	public InvBaseItem.Slot slot;

	protected override InvGameItem observedItem
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InvEquipment), Member = "Replace")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	protected override InvGameItem Replace(InvGameItem item)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(UIItemSlot), Member = ".ctor")]
	public UIEquipmentSlot()
	{
	}
}
