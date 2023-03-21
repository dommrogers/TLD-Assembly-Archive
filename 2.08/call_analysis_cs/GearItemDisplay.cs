using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GearItemDisplay : MonoBehaviour
{
	public delegate void OnClicked(int index);

	public UISprite m_Available;

	public UISprite m_Background;

	public UIButton m_Button;

	public UILabel m_DisplayName;

	public UITexture m_Icon;

	public UIWidget m_Root;

	public UISprite m_Unavailable;

	public Color m_Disabled;

	public Color m_Normal;

	public Color m_Selected;

	[NonSerialized]
	public int m_Index;

	[NonSerialized]
	public OnClicked m_ClickedDelegate;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[CallsUnknownMethods(Count = 4)]
	public void Clear()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnButtonClicked()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public void SetSelected(bool selected)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[CallsUnknownMethods(Count = 4)]
	public void Setup(GearItem gi)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GearItemDisplay()
	{
	}
}
