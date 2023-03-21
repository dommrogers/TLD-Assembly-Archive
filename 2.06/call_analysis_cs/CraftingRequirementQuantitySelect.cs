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

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Disable()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Enable(BlueprintData bp)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetCurrent()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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

	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[CallerCount(Count = 0)]
	public void ManualUpdate()
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnDecrease()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	public void OnIncrease()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "SetHighlightedItem")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void SetSelected(bool selected)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[CalledBy(Type = typeof(CraftingRequirementQuantitySelect), Member = "OnIncrease")]
	[CalledBy(Type = typeof(CraftingRequirementQuantitySelect), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(CraftingRequirementQuantitySelect), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnPrevious")]
	[CalledBy(Type = typeof(CraftingRequirementQuantitySelect), Member = "OnDecrease")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "ManualUpdate")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnNext")]
	private void Refresh()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public CraftingRequirementQuantitySelect()
	{
	}
}
