using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GearItemListEntry : MonoBehaviour
{
	public UILabel m_NameLabel;

	public UISprite m_ConditionSprite;

	public UILabel m_ConditionLabel;

	public UILabel m_ItemCountLabel;

	private GearItem m_GearItem;

	private bool m_IsSelected;

	public bool m_DisplayItemCount;

	public bool m_DisplayCondition;

	public bool m_UpdateLabels;

	public bool m_UpdateColorsOnly;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void Awake()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(GearItemListEntry), Member = "SetGearItem")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFood")]
	private void Update()
	{
	}

	[Calls(Type = typeof(GearItemListEntry), Member = "Update")]
	[CallerCount(Count = 0)]
	public void SetGearItem(GearItem gi)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetSelected(bool isSelected)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateColors()
	{
	}

	[CallerCount(Count = 0)]
	public GearItemListEntry()
	{
	}
}
