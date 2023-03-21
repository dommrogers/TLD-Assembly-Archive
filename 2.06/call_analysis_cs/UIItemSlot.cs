using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class UIItemSlot : MonoBehaviour
{
	public UISprite icon;

	public UIWidget background;

	public UILabel label;

	public AudioClip grabSound;

	public AudioClip placeSound;

	public AudioClip errorSound;

	private InvGameItem mItem;

	private string mText;

	private static InvGameItem mDraggedItem;

	protected abstract InvGameItem observedItem
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	protected abstract InvGameItem Replace(InvGameItem item);

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvGameItem), Member = "CalculateStats")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(NGUIMath), Member = "ColorToInt")]
	[Calls(Type = typeof(InvGameItem), Member = "get_color")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvGameItem), Member = "get_name")]
	private void OnTooltip(bool show)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void OnDrop(GameObject go)
	{
	}

	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UICursor), Member = "Set")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "OnClick")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "OnDrag")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UICursor), Member = "Set")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallerCount(Count = 2)]
	private void UpdateCursor()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(InvGameItem), Member = "get_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(InvGameItem), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	private void Update()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIEquipmentSlot), Member = ".ctor")]
	[CalledBy(Type = typeof(UIStorageSlot), Member = ".ctor")]
	protected UIItemSlot()
	{
	}
}
