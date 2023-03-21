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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshButtonConfigure")]
	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "RefreshButtonConfigure")]
	[Calls(Type = typeof(ButtonLegendConfigure), Member = "RefreshReferences")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	public void ConfigureButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	private void RefreshReferences()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ButtonLegendConfigure()
	{
	}
}
