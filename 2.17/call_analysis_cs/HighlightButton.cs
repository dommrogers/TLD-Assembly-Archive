using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HighlightButton
{
	private readonly UIButton m_Button;

	private readonly string m_DisabledSprite;

	private readonly string m_NormalSprite;

	private readonly UISprite m_TweenSprite;

	private Color m_DisabledColour;

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Initialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public HighlightButton(UIButton button)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateSortButtons")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void SetHighlighted(bool highlighted)
	{
	}
}
