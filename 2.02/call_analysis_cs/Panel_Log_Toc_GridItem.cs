using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Log_Toc_GridItem : MonoBehaviour
{
	public UILabel m_LabelTitle;

	public UISprite m_SpriteSelection;

	public UISprite m_SpriteBoarder;

	private bool m_IsSelected;

	private bool m_IsHover;

	public float m_TextAlphaSelected;

	public float m_TextAlphaHover;

	public float m_TextAlphaUnselected;

	public float m_AlphaSelected;

	public float m_AlphaUnselected;

	public float m_AlphaHover;

	private float m_DoubleClickTimer;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetSelected(bool selected)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnHover(bool hover)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[CallsUnknownMethods(Count = 1)]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public Panel_Log_Toc_GridItem()
	{
	}
}
