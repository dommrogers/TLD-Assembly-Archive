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
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		get;
	}

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	protected abstract InvGameItem Replace(InvGameItem item);

	[Calls(Type = typeof(InvGameItem), Member = "CalculateStats")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 47)]
	[Calls(Type = typeof(InvGameItem), Member = "get_name")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(InvGameItem), Member = "get_color")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIText), Member = "EncodeColor24")]
	private void OnTooltip(bool show)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIItemSlot), Member = "OnDrop")]
	[Calls(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[Calls(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(UIItemSlot), Member = "OnClick")]
	[CallerCount(Count = 1)]
	private void OnDrop(GameObject go)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "OnClick")]
	[Calls(Type = typeof(UICursor), Member = "Set")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICursor), Member = "Set")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "OnDrag")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateCursor()
	{
	}

	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InvGameItem), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(InvGameItem), Member = "get_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(UIStorageSlot), Member = ".ctor")]
	[CalledBy(Type = typeof(UIEquipmentSlot), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected UIItemSlot()
	{
	}
}
