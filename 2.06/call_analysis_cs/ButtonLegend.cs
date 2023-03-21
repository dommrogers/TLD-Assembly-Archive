using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ButtonLegend : MonoBehaviour
{
	public GameObject ButtonLegendItemPrefab;

	public ButtonLegendAtlas m_ButtonLegendAtlas;

	public bool m_OverrideIsControllerActive;

	public UITable m_Table;

	public bool m_OverrideDepth;

	public int m_Depth;

	private Dictionary<string, ButtonLegendItem> m_ButtonLegendItems;

	private bool m_UpdateInProgress;

	private bool m_Reposition;

	private bool m_LastFrameWasController;

	private bool m_IsDirty;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CallsUnknownMethods(Count = 6)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 8)]
	public void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UITable), Member = "GetChildList")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	public void BeginUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegend), Member = "RemoveButton")]
	[Calls(Type = typeof(ButtonLegend), Member = "AddButton")]
	public void UpdateButton(string action, string localizationKey, bool active, int priority, bool localize)
	{
	}

	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public ButtonIcon GetButtonIconSpriteName(string action)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateKeyBindingLabels")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateKeyBindingLabels")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	public void ConfigureButtonIconSpriteName(string action, ref UISprite buttonSprite)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsUnknownMethods(Count = 1)]
	public void ForceButtonSpriteName(string spriteName, ref UISprite buttonSprite)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendItem), Member = "Setup")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "UpdateButton")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "AddButton")]
	[Calls(Type = typeof(ButtonLegend), Member = "RepositionTable")]
	[Calls(Type = typeof(ButtonLegendItem), Member = "SetDepth")]
	[Calls(Type = typeof(ButtonLegend), Member = "CreatePrefab")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void AddButton(string action, string localizationKey, int priority, bool localize)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ButtonLegend), Member = "UpdateButton")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "RemoveButton")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UITable), Member = "GetChildList")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void RemoveButton(string action)
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 0)]
	public void EndUpdate()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	private ButtonLegendItem CreatePrefab()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	private int OnSort(Transform a, Transform b)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void RepositionTable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public ButtonLegend()
	{
	}
}
