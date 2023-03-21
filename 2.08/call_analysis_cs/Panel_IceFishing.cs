using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using UnityEngine;

public class Panel_IceFishing : Panel_AutoReferenced
{
	public GameObject m_TimeWidgetPos;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public int m_MaxHoursToFish;

	public int m_MinHoursToFish;

	public int m_HoursToFishDefault;

	public float m_SecondsProgressBarPerHour;

	public GameObject m_HoursToFishLabel;

	public GameObject m_EstimatedCaloriesBurnedLabel;

	public GameObject m_CurrentCaloriesLabel;

	public GameObject m_ButtonHoursIncrease;

	public GameObject m_ButtonHoursDecrease;

	private int m_HoursToFish;

	private bool m_SkipRestoreItemInHandsOnExit;

	private IceFishingHole m_IceFishingHole;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_IceFishing), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "UpdateCurrentCaloriesLabel")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "UpdateHoursToFishLabel")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(IceFishingHole), Member = "StartFishing")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Launch(IceFishingHole ifh)
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "UpdateCurrentCaloriesLabel")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "UpdateHoursToFishLabel")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public override void Enable(bool enable)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallerCount(Count = 0)]
	public void OnCancel()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(IceFishingHole), Member = "StartFishing")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	public void OnFish()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 0)]
	public void OnIncreaseHours()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnDecreaseHours()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeRollRandomWeightAndCalories")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ShouldEnableMousePointer")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsFishing()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString")]
	private void UpdateHoursToFishLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	private void UpdateEstimatedCaloriesBurnedLabel()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void UpdateCurrentCaloriesLabel()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_IceFishing()
	{
	}
}
