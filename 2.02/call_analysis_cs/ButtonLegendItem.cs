using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ButtonLegendItem : MonoBehaviour
{
	public UISprite m_Sprite;

	public UILabel m_Label;

	private string m_LocalizationKey;

	private int m_Priority;

	private bool m_Localize;

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public bool Setup(string localizationKey, string iconName, UIAtlas atlas, int priority, bool localize)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public int CompareTo(ButtonLegendItem b)
	{
		return default(int);
	}

	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ButtonLegendContainer), Member = "OverrideDepthOfAllItems")]
	public void SetDepth(int depth)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetDepth()
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnLocalize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public ButtonLegendItem()
	{
	}
}
