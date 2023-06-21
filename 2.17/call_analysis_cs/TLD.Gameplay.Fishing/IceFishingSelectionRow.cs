using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay.Fishing;

public class IceFishingSelectionRow : MonoBehaviour
{
	private GameObject m_SelectedBackground;

	private UITexture m_Sprite;

	private UITexture m_NoSelectionSprite;

	private UILabel m_Label;

	private GameObject m_ButtonIncrease;

	private GameObject m_ButtonDecrease;

	private List<GearItem> m_Items;

	private int m_SelectedIndex;

	public GearItem SelectedItem
	{
		[CalledBy(Type = typeof(IceFishingSelectionRow), Member = "UpdateSelection")]
		[CallerCount(Count = 4)]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "RefreshRows")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(IceFishingSelectionRow), Member = "UpdateSelection")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	public void RefreshRow(Predicate<GearItem> validationPredicate)
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "UpdateTackleController")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "SwitchFocus")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsUnknownMethods(Count = 2)]
	public void SetSelected(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingSelectionRow), Member = "ChangeSelectedGearItem")]
	public void DecreaseSelection()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void IncreaseSelection()
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "UpdateTackleController")]
	[CalledBy(Type = typeof(IceFishingSelectionRow), Member = "DecreaseSelection")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IceFishingSelectionRow), Member = "UpdateSelection")]
	[CallsUnknownMethods(Count = 1)]
	private void ChangeSelectedGearItem(int indexChange)
	{
	}

	[CalledBy(Type = typeof(IceFishingSelectionRow), Member = "RefreshRow")]
	[CalledBy(Type = typeof(IceFishingSelectionRow), Member = "ChangeSelectedGearItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IceFishingSelectionRow), Member = "get_SelectedItem")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateSelection()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public IceFishingSelectionRow()
	{
	}
}
