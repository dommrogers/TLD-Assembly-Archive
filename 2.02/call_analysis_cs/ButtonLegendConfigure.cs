using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ButtonLegendConfigure : MonoBehaviour
{
	public string m_ActionName;

	private ButtonLegendContainer m_ButtonLegendContainer;

	private UISprite m_ButtonSprite;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendConfigure), Member = "RefreshReferences")]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "RefreshButtonConfigure")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshButtonConfigure")]
	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "Update")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(ButtonLegendConfigure), Member = "RefreshReferences")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ConfigureButton()
	{
	}

	[Calls(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "Awake")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 6)]
	private void RefreshReferences()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ButtonLegendConfigure()
	{
	}
}
