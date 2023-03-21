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
		[CalledBy(Type = typeof(UIStorageSlot), Member = "Replace")]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(UIItemStorage), Member = "GetItem")]
		[CalledBy(Type = typeof(UIItemStorage), Member = "Replace")]
		[CalledBy(Type = typeof(UIStorageSlot), Member = "get_observedItem")]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIItemStorage), Member = "get_items")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public InvGameItem GetItem(int slot)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIItemStorage), Member = "get_items")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	public InvGameItem Replace(int slot, InvGameItem item)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public UIItemStorage()
	{
	}
}
