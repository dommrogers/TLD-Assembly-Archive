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

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 14)]
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

	[CallerCount(Count = 58)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ButtonLegend), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public void Clear()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegend), Member = "AddButton")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void AddButton(string action, string localizationKey, int priority, bool localize = true)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ButtonLegend), Member = "RemoveButton")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveButton(string action)
	{
	}

	[CallerCount(Count = 88)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public void BeginUpdate()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegend), Member = "AddButton")]
	[CallerCount(Count = 245)]
	[Calls(Type = typeof(ButtonLegend), Member = "RemoveButton")]
	public void UpdateButton(string action, string localizationKey, bool active, int priority, bool localize = true)
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 87)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public void EndUpdate()
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ButtonLegendItem), Member = "SetDepth")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "ResetDefaultDepthOfAllItems")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
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
