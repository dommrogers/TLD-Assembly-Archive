using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
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
	public void Start()
	{
	}

	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	public void Disable()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "Disable")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "AddToolOptions")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "RefreshDisplayed")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "AddToolOptions")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	public void Enable(BlueprintData bp)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	public GearItem GetSelectedTool()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsSelected()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "RefreshDisplayed")]
	[CallsUnknownMethods(Count = 1)]
	public void OnNextTool()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "RefreshDisplayed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnPreviousTool()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	public void SetSelected(bool selected)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "Enable")]
	[Calls(Type = typeof(Inventory), Member = "GetItems")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void AddToolOptions(GearItem gi, bool mustHaveInInventory)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "OnPreviousTool")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "OnNextTool")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnPrevious")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnNext")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 5)]
	private void RefreshDisplayed()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CraftingRequirementMultiTool()
	{
	}
}
