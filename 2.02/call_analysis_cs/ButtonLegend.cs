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

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UITable), Member = "GetChildList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 6)]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	public void BeginUpdate()
	{
	}

	[Calls(Type = typeof(ButtonLegend), Member = "AddButton")]
	[Calls(Type = typeof(ButtonLegend), Member = "RemoveButton")]
	[CallerCount(Count = 0)]
	public void UpdateButton(string action, string localizationKey, bool active, int priority, bool localize)
	{
	}

	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public ButtonIcon GetButtonIconSpriteName(string action)
	{
		return null;
	}

	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
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

	[CalledBy(Type = typeof(ButtonLegend), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegend), Member = "CreatePrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ButtonLegendItem), Member = "Setup")]
	[Calls(Type = typeof(ButtonLegend), Member = "RepositionTable")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "AddButton")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendItem), Member = "SetDepth")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void AddButton(string action, string localizationKey, int priority, bool localize)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "UpdateButton")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "RemoveButton")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UITable), Member = "GetChildList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void RemoveButton(string action)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public void EndUpdate()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	private ButtonLegendItem CreatePrefab()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private int OnSort(Transform a, Transform b)
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	[CallsUnknownMethods(Count = 1)]
	private void RepositionTable()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public ButtonLegend()
	{
	}
}
