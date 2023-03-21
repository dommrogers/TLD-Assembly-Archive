using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CraftingRequirementMultiTool : MonoBehaviour
{
	public delegate void SelectedToolChanged();

	public SelectedToolChanged m_OnSelectedToolChanged;

	public UILabel m_ConditionDisplay;

	public GameObject m_ControllerButtonRoot;

	public GameObject m_ConditionRoot;

	public UILabel m_DisplayName;

	public UITexture m_Icon;

	public float m_OffsetY;

	public float m_NextOffsetY;

	public string m_NoToolIcon;

	public string m_NoToolName;

	private List<GearItem> m_ToolOptions;

	private bool m_IsSelected;

	private int m_SelectedIndex;

	private GearItem m_SelectedTool;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Disable()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "RefreshDisplayed")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "AddToolOptions")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "AddToolOptions")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "Disable")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	public void Enable(BlueprintItem bpi)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	public GearItem GetSelectedTool()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 54)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsSelected()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "RefreshDisplayed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public void OnNextTool()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "RefreshDisplayed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void OnPreviousTool()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 0)]
	public void SetSelected(bool selected)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "Enable")]
	[Calls(Type = typeof(Inventory), Member = "GetItems")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void AddToolOptions(GearItem gi, bool mustHaveInInventory)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnNext")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnPrevious")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "OnNextTool")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "OnPreviousTool")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	private void RefreshDisplayed()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public CraftingRequirementMultiTool()
	{
	}
}
