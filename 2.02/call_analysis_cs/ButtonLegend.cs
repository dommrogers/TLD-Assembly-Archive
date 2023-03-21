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
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 13)]
	public void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(UITable), Member = "GetChildList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
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

	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsUnknownMethods(Count = 1)]
	public void ConfigureButtonIconSpriteName(string action, ref UISprite buttonSprite)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsUnknownMethods(Count = 1)]
	public void ForceButtonSpriteName(string spriteName, ref UISprite buttonSprite)
	{
	}

	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "AddButton")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "UpdateButton")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(ButtonLegend), Member = "CreatePrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ButtonLegendItem), Member = "SetDepth")]
	[Calls(Type = typeof(ButtonLegendItem), Member = "Setup")]
	[Calls(Type = typeof(ButtonLegend), Member = "RepositionTable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void AddButton(string action, string localizationKey, int priority, bool localize)
	{
	}

	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "RemoveButton")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "UpdateButton")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(UITable), Member = "GetChildList")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 16)]
	public void RemoveButton(string action)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EndUpdate()
	{
	}

	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 14)]
	private ButtonLegendItem CreatePrefab()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private int OnSort(Transform a, Transform b)
	{
		return 0;
	}

	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void RepositionTable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public ButtonLegend()
	{
	}
}
