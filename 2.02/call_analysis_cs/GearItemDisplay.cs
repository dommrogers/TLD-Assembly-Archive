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
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[CallsUnknownMethods(Count = 9)]
	public void Clear()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnButtonClicked()
	{
	}

	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	public void SetSelected(bool selected)
	{
	}

	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	public void Setup(GearItem gi)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GearItemDisplay()
	{
	}
}
