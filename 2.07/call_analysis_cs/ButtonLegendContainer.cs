using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class ButtonLegendContainer
{
	public GameObject m_ButtonLegendParent;

	public GameObject m_ButtonLegendParentPrefab;

	public GameObject m_ButtonLegendPrefab;

	private GameObject m_Parent;

	public ButtonLegend m_ButtonLegend;

	public bool m_OverrideDepth;

	public int m_Depth;

	private static Dictionary<GameObject, ButtonLegendContainer> m_OwnerDictionnary;

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 60)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public void Create(GameObject owner)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void Show(bool show)
	{
	}

	[Calls(Type = typeof(ButtonLegend), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 58)]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegend), Member = "AddButton")]
	[CallsUnknownMethods(Count = 1)]
	public void AddButton(string action, string localizationKey, int priority, bool localize = true)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegend), Member = "RemoveButton")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveButton(string action)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 86)]
	public void BeginUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegend), Member = "AddButton")]
	[CallerCount(Count = 241)]
	[Calls(Type = typeof(ButtonLegend), Member = "RemoveButton")]
	public void UpdateButton(string action, string localizationKey, bool active, int priority, bool localize = true)
	{
	}

	[CallerCount(Count = 85)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsUnknownMethods(Count = 1)]
	public void EndUpdate()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "ResetDefaultDepthOfAllItems")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendItem), Member = "SetDepth")]
	public void OverrideDepthOfAllItems(int depthAmount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "OverrideDepthOfAllItems")]
	public void ResetDefaultDepthOfAllItems()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static ButtonLegendContainer TryGetButtonLegendContainer(GameObject owner)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public ButtonLegendContainer()
	{
	}
}
