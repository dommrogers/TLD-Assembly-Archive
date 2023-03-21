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

	protected abstract InvGameItem observedItem { get; }

	protected abstract InvGameItem Replace(InvGameItem item);

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(InvGameItem), Member = "get_color")]
	[Calls(Type = typeof(NGUIText), Member = "EncodeColor24")]
	[Calls(Type = typeof(InvGameItem), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(InvGameItem), Member = "CalculateStats")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 42)]
	private void OnTooltip(bool show)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[Calls(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[Calls(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnDrop(GameObject go)
	{
	}

	[CalledBy(Type = typeof(UIItemSlot), Member = "OnClick")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "OnDrag")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(UICursor), Member = "Set")]
	[Calls(Type = typeof(UICursor), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateCursor()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(InvGameItem), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(InvGameItem), Member = "get_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(UIEquipmentSlot), Member = ".ctor")]
	[CalledBy(Type = typeof(UIStorageSlot), Member = ".ctor")]
	[CallerCount(Count = 2)]
	protected UIItemSlot()
	{
	}
}
