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
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UIStorageSlot), Member = "Replace")]
		[CalledBy(Type = typeof(UIStorageSlot), Member = "get_observedItem")]
		[CalledBy(Type = typeof(UIItemStorage), Member = "Replace")]
		[CalledBy(Type = typeof(UIItemStorage), Member = "GetItem")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIItemStorage), Member = "get_items")]
	public InvGameItem GetItem(int slot)
	{
		return null;
	}

	[Calls(Type = typeof(UIItemStorage), Member = "get_items")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	public InvGameItem Replace(int slot, InvGameItem item)
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public UIItemStorage()
	{
	}
}
