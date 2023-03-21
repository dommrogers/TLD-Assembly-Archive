using Cpp2ILInjected.CallAnalysis;

public class UIEquipmentSlot : UIItemSlot
{
	public InvEquipment equipment;

	public InvBaseItem.Slot slot;

	protected override InvGameItem observedItem
	{
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(InvEquipment), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override InvGameItem Replace(InvGameItem item)
	{
		return null;
	}

	[Calls(Type = typeof(UIItemSlot), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UIEquipmentSlot()
	{
	}
}
