using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ButtonLegendItem : MonoBehaviour
{
	public UISprite m_Sprite;

	public UILabel m_Label;

	private string m_LocalizationKey;

	private int m_Priority;

	private bool m_Localize;

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public bool Setup(string localizationKey, string iconName, UIAtlas atlas, int priority, bool localize)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int CompareTo(ButtonLegendItem b)
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "OverrideDepthOfAllItems")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	[CallsUnknownMethods(Count = 1)]
	public void SetDepth(int depth)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public int GetDepth()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void OnLocalize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ButtonLegendItem()
	{
	}
}
