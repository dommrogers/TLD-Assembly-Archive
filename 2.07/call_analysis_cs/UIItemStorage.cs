using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIItemStorage : MonoBehaviour
{
	public int maxItemCount;

	public int maxRows;

	public int maxColumns;

	public GameObject template;

	public UIWidget background;

	public int spacing;

	public int padding;

	private List<InvGameItem> mItems;

	public List<InvGameItem> items
	{
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(UIItemStorage), Member = "GetItem")]
		[CalledBy(Type = typeof(UIItemStorage), Member = "Replace")]
		[CalledBy(Type = typeof(UIStorageSlot), Member = "Replace")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UIStorageSlot), Member = "get_observedItem")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(UIItemStorage), Member = "get_items")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public InvGameItem GetItem(int slot)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UIItemStorage), Member = "get_items")]
	public InvGameItem Replace(int slot, InvGameItem item)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public UIItemStorage()
	{
	}
}
