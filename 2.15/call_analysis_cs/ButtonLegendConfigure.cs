using System.Collections.Generic;
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

	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshButtonConfigure")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "RefreshButtonConfigure")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendConfigure), Member = "RefreshReferences")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[CallsUnknownMethods(Count = 1)]
	public void ConfigureButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "Awake")]
	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshReferences()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ButtonLegendConfigure()
	{
	}
}
