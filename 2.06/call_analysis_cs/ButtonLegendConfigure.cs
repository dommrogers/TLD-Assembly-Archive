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
	[CalledBy(Type = typeof(Panel_Rest), Member = "RefreshButtonConfigure")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshButtonConfigure")]
	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "Update")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ButtonLegendConfigure), Member = "RefreshReferences")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public void ConfigureButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "Awake")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshReferences()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ButtonLegendConfigure()
	{
	}
}
