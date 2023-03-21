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

	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "OverrideDepthOfAllItems")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	public void SetDepth(int depth)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetDepth()
	{
		return default(int);
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void OnLocalize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ButtonLegendItem()
	{
	}
}
