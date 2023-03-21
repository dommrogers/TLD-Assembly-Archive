using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ConsoleSlider : MonoBehaviour
{
	public GameObject m_Background;

	public GameObject m_SliderObject;

	public UILabel m_LableName;

	public LocalizedString m_LocalizedToolTip;

	public List<EventDelegate> onChange;

	public UISlider m_Slider;

	public string m_ToolTip
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
	}

	public float value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeControlsMenuItems")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeQualityMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeQualityMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeQualityMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeQualityMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeQualityMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitSlider")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeDisplayMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeControlsMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeAutosaveMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeBrightnessMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeBrightnessMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeControlsMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeAudioMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeAudioMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeAudioMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeAudioMenuItems")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 17)]
	public void Start()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUISlider")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnDragFinished()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUISlider")]
	[CallsUnknownMethods(Count = 3)]
	public void OnValueChanged()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	public void OnIncrease()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallsUnknownMethods(Count = 2)]
	public void OnDecrease()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public ConsoleSlider()
	{
	}
}
