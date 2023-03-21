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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	public bool Setup(string localizationKey, string iconName, UIAtlas atlas, int priority, bool localize)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int CompareTo(ButtonLegendItem b)
	{
		return 0;
	}

	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "OverrideDepthOfAllItems")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsUnknownMethods(Count = 1)]
	public void SetDepth(int depth)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetDepth()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	private void OnLocalize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ButtonLegendItem()
	{
	}
}
