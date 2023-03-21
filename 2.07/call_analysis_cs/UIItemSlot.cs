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
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	protected abstract InvGameItem Replace(InvGameItem item);

	[Calls(Type = typeof(InvGameItem), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvGameItem), Member = "CalculateStats")]
	[Calls(Type = typeof(InvGameItem), Member = "get_color")]
	[Calls(Type = typeof(NGUIText), Member = "EncodeColor24")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString")]
	private void OnTooltip(bool show)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[Calls(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnClick()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnDrop(GameObject go)
	{
	}

	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(UICursor), Member = "Set")]
	[Calls(Type = typeof(UICursor), Member = "Clear")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "OnClick")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "OnDrag")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	private void UpdateCursor()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(InvGameItem), Member = "get_name")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvGameItem), Member = "get_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
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
