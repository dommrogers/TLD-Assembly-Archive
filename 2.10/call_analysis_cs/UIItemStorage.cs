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
		[CalledBy(Type = typeof(UIItemStorage), Member = "GetItem")]
		[CalledBy(Type = typeof(UIItemStorage), Member = "Replace")]
		[CalledBy(Type = typeof(UIStorageSlot), Member = "get_observedItem")]
		[CalledBy(Type = typeof(UIStorageSlot), Member = "Replace")]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIItemStorage), Member = "get_items")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public InvGameItem GetItem(int slot)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIItemStorage), Member = "get_items")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public InvGameItem Replace(int slot, InvGameItem item)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public UIItemStorage()
	{
	}
}
