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
		[Calls(Type = typeof(Localization), Member = "Get")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public float value
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
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
	[CallsUnknownMethods(Count = 6)]
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
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeAudioMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeAudioMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeAudioMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeAudioMenuItems")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeControlsMenuItems")]
	public void Start()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUISlider")]
	public void OnDragFinished()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUISlider")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public void OnValueChanged()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallsUnknownMethods(Count = 2)]
	public void OnIncrease()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	public void OnDecrease()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public ConsoleSlider()
	{
	}
}
