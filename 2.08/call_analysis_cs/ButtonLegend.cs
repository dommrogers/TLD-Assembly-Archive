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

	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UITable), Member = "GetChildList")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsUnknownMethods(Count = 6)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[CallsUnknownMethods(Count = 1)]
	public ButtonIcon GetButtonIconSpriteName(string action)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateButtonLegend")]
	public void ConfigureButtonIconSpriteName(string action, ref UISprite buttonSprite)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	public void ForceButtonSpriteName(string spriteName, ref UISprite buttonSprite)
	{
	}

	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "AddButton")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendItem), Member = "Setup")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegend), Member = "CreatePrefab")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ButtonLegendItem), Member = "SetDepth")]
	[CallsDeduplicatedMethods(Count = 3)]
	public void AddButton(string action, string localizationKey, int priority, bool localize)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UITable), Member = "GetChildList")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "RemoveButton")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 7)]
	public void RemoveButton(string action)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public void EndUpdate()
	{
	}

	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	private ButtonLegendItem CreatePrefab()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private int OnSort(Transform a, Transform b)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void RepositionTable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ButtonLegend()
	{
	}
}
