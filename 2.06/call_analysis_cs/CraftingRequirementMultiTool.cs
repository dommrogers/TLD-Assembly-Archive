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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	public void Disable()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "Disable")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "RefreshDisplayed")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "AddToolOptions")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "AddToolOptions")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void Enable(BlueprintData bp)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	public GearItem GetSelectedTool()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
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
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public void OnPreviousTool()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	public void SetSelected(bool selected)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetItems")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "Enable")]
	[CallsUnknownMethods(Count = 17)]
	private void AddToolOptions(GearItem gi, bool mustHaveInInventory)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnNext")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "OnNextTool")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "OnPreviousTool")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnPrevious")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void RefreshDisplayed()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public CraftingRequirementMultiTool()
	{
	}
}
