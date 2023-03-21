using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CraftingRequirementTimeSelect : MonoBehaviour
{
	public List<GameObject> m_ControllerButtons;

	public UILabel m_TimeText;

	public int m_Timestep;

	public int m_MinimumTimeForDisplay;

	public float m_OffsetY;

	private int m_DisplayedCraftingTime;

	private bool m_IsSelected;

	private int m_TotalCraftingTime;

	private Vector3 m_InitialPosition;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(CraftingRequirementTimeSelect), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "RefreshCraftingTimeDisplay")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 2)]
	public void Disable()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Refresh")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Disable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "RefreshCraftingTimeDisplay")]
	public void Enable(int craftingTime, bool offset)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int GetCraftingTime()
	{
		return default(int);
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Refresh")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Refresh")]
	public void OnDecrease()
	{
	}

	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Refresh")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Refresh")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public void OnIncrease()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "SetHighlightedItem")]
	[CallsUnknownMethods(Count = 2)]
	public void SetSelected(bool selected)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(CraftingRequirementTimeSelect), Member = "OnIncrease")]
	[CalledBy(Type = typeof(CraftingRequirementTimeSelect), Member = "OnDecrease")]
	[CalledBy(Type = typeof(CraftingRequirementTimeSelect), Member = "OnDecrease")]
	[CalledBy(Type = typeof(CraftingRequirementTimeSelect), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnPrevious")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnPrevious")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnNext")]
	[CalledBy(Type = typeof(CraftingRequirementTimeSelect), Member = "OnIncrease")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "TrimEnd")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnNext")]
	private void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public CraftingRequirementTimeSelect()
	{
	}
}
