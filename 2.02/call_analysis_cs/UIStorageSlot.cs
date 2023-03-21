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
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIItemStorage), Member = "get_items")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIItemStorage), Member = "get_items")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override InvGameItem Replace(InvGameItem item)
	{
		return null;
	}

	[Calls(Type = typeof(UIItemSlot), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIStorageSlot()
	{
	}
}
