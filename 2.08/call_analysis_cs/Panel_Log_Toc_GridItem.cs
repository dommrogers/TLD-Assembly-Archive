using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_Log_Toc_GridItem : MonoBehaviour
{
	private PanelReference<Panel_Log> m_Log;

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

	[CalledBy(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetSelected(bool selected)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnHover(bool hover)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[CallsUnknownMethods(Count = 1)]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Panel_Log_Toc_GridItem()
	{
	}
}
