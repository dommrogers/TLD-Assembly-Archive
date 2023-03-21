using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIStorageSlot : UIItemSlot
{
	public UIItemStorage storage;

	public int slot;

	protected override InvGameItem observedItem
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UIItemStorage), Member = "get_items")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIItemStorage), Member = "get_items")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	protected override InvGameItem Replace(InvGameItem item)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIItemSlot), Member = ".ctor")]
	[DeduplicatedMethod]
	public UIStorageSlot()
	{
	}
}
