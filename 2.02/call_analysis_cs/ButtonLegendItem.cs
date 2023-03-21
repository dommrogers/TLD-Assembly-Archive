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
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnLocalize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ButtonLegendItem()
	{
	}
}
