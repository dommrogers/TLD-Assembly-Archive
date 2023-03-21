using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	public void Disable()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	public void Enable(BlueprintData bp)
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
	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	public void ManualUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	public void OnDecrease()
	{
	}

	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public void OnIncrease()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "SetHighlightedItem")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetSelected(bool selected)
	{
	}

	[CalledBy(Type = typeof(CraftingRequirementQuantitySelect), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(CraftingRequirementQuantitySelect), Member = "OnDecrease")]
	[CalledBy(Type = typeof(CraftingRequirementQuantitySelect), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnPrevious")]
	[CalledBy(Type = typeof(CraftingRequirementQuantitySelect), Member = "OnIncrease")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "ManualUpdate")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnNext")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public CraftingRequirementQuantitySelect()
	{
	}
}
