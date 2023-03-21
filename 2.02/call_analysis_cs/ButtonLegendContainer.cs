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

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 70)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void Create(GameObject owner)
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "DisablePanel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void Show(bool show)
	{
	}

	[CallerCount(Count = 59)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegend), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void Clear()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegend), Member = "AddButton")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	public void AddButton(string action, string localizationKey, int priority, bool localize = true)
	{
	}

	[Calls(Type = typeof(ButtonLegend), Member = "RemoveButton")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveButton(string action)
	{
	}

	[CallerCount(Count = 100)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void BeginUpdate()
	{
	}

	[CallerCount(Count = 272)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ButtonLegend), Member = "RemoveButton")]
	[Calls(Type = typeof(ButtonLegend), Member = "AddButton")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UpdateButton(string action, string localizationKey, bool active, int priority, bool localize = true)
	{
	}

	[CallerCount(Count = 100)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void EndUpdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "ResetDefaultDepthOfAllItems")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ButtonLegendItem), Member = "SetDepth")]
	public void OverrideDepthOfAllItems(int depthAmount)
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "OverrideDepthOfAllItems")]
	[CallerCount(Count = 0)]
	public void ResetDefaultDepthOfAllItems()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
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
