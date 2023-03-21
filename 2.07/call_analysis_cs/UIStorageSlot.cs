using System;
using Cpp2ILInjected.CallAnalysis;

public class UIStorageSlot : UIItemSlot
{
	public UIItemStorage storage;

	public int slot;

	protected override InvGameItem observedItem
	{
		[Calls(Type = typeof(UIItemStorage), Member = "get_items")]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(UIItemStorage), Member = "get_items")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	protected override InvGameItem Replace(InvGameItem item)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIItemSlot), Member = ".ctor")]
	public UIStorageSlot()
	{
	}
}
