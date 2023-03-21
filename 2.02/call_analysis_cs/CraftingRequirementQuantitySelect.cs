using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CraftingRequirementQuantitySelect : MonoBehaviour
{
	public delegate void SelectedQunatityChanged();

	public SelectedQunatityChanged m_OnSelectedQuantityChanged;

	public List<GameObject> m_ControllerButtons;

	public UILabel m_QuantityText;

	public UILabel m_UnitsText;

	public LocalizedString m_DefaultMultipleUnit;

	public LocalizedString m_DefaultSingleUnit;

	public const int MINIMUM = 1;

	private bool m_IsSelected;

	private int m_Current;

	private int m_Maximum;

	private int m_UnitsPerItem;

	private Vector3 m_InitialPosition;

	private string m_StackMultipleLocID;

	private string m_StackSingleLocID;

	private bool m_NeedsRefresh;

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Disable()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "NumGearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 21)]
	public void Enable(BlueprintItem bpi)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetCurrent()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 54)]
	[DeduplicatedMethod]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsMinimumSelected()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsSelected()
	{
		return default(bool);
	}

	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[CallerCount(Count = 0)]
	public void ManualUpdate()
	{
	}

	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void OnDecrease()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnIncrease()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "SetHighlightedItem")]
	[CallsUnknownMethods(Count = 2)]
	public void SetSelected(bool selected)
	{
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnNext")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "ManualUpdate")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnPrevious")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CraftingRequirementQuantitySelect), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(CraftingRequirementQuantitySelect), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementQuantitySelect), Member = "OnIncrease")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CraftingRequirementQuantitySelect), Member = "OnDecrease")]
	[CallerCount(Count = 8)]
	private void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public CraftingRequirementQuantitySelect()
	{
	}
}
