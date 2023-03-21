using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Rest : Panel_Base
{
	public GameObject m_TimeWidgetPos;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public int m_MaxSleepHours;

	public int m_MinSleepHours;

	public int m_DefaultSleepHours;

	public Transform m_OffsetTransform;

	public Vector3 m_OffsetValueController;

	public GameObject m_RestDurationLabel;

	public GameObject m_WakeTimeLabel;

	public GameObject m_EstimatedCaloriesBurnedLabel;

	public GameObject m_CurrentCaloriesLabel;

	public GameObject m_WarmthBonusLabel;

	public GameObject m_WarmthBonusValLabel;

	public GameObject m_RestOnlyObject;

	public GameObject m_PassTimeOnlyObject;

	public GameObject m_PassTimeNavButtons;

	public GameObject m_PassTimeButtonObject;

	public GameObject m_PassTimeCancelButtonObject;

	public GameObject[] m_ObjectsToDisableDuringPassTime;

	public GameObject m_RestNavButtons;

	public GameObject m_SleepButton;

	public GameObject m_PickUpButton;

	public UIButton m_DefaultSelectedButton;

	public float m_AllowRestFatigueThreshold;

	public UILabel m_TemperatureLabel;

	public UILabel m_ConditionLabel;

	public UILabel m_ConditionDebuffLabel;

	public UILabel m_CalorieReservesLabel;

	public Color m_NegativeTemperatureColor;

	private int m_SleepHours;

	private int m_CurrentTimeHours;

	private int m_CurrentTimeMinutes;

	private Bed m_Bed;

	private bool m_SkipRestoreItemInHandsOnExit;

	private bool m_ShowPassTime;

	private bool m_ShowPassTimeOnly;

	private bool m_ShowUIDuringPassTime;

	private Vector3 m_SleepButtonOrigPos;

	private Vector3 m_SleepButtonCenteredPos;

	private bool m_PassTimeIsAllowed;

	public GameObject m_ButtonIncrease;

	public GameObject m_ButtonDecrease;

	private ButtonLegendConfigure[] m_ButtonLegendConfigureArray_Rest;

	private ButtonLegendConfigure[] m_ButtonLegendConfigureArray_PassTime;

	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	public override void Initialize()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Rest), Member = "UpdateWarmthBonusLabel")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "Enable")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Rest), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Rest), Member = "UpdateFeelsLikeLabel")]
	[Calls(Type = typeof(Condition), Member = "GetConditionValueForInterfaceDisplay")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Rest), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(Panel_Rest), Member = "UpdateCurrentCaloriesLabel")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateVisuals()
	{
	}

	[CalledBy(Type = typeof(SnowShelterManager), Member = "OnBedroll")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "OnBedroll")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "OnBedroll")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessBedInteraction")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "OnBedroll")]
	[CalledBy(Type = typeof(LeanToManager), Member = "OnBedroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(LeanToManager), Member = "OnBedroll")]
	public void StartRest(Bed b)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 40)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoPassTime")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void Enable(bool enable, bool passTimeOnly)
	{
	}

	[CallerCount(Count = 0)]
	public void SetPassTimeAllowed(bool allowed)
	{
	}

	[CallerCount(Count = 0)]
	public bool GetPassTimeAllowed()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "DoClickHoldCancel")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "DoClickHoldCancel")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ItemProgressBarCheck")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ShouldEnableMousePointer")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsPassingTimeOnly()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 4)]
	public void OnSelectRest()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnSelectPassTime()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Rest), Member = "DoRest")]
	public void OnRest()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void OnFullRest()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnPassTime()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[Calls(Type = typeof(PassTime), Member = "Begin")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Rest), Member = "CheckPassTimeErrorMessage")]
	public bool DoPassTime(float sleepHours)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Bed), Member = "SetState")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CallsUnknownMethods(Count = 7)]
	public void OnPickUp()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnIncreaseHours()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnDecreaseHours()
	{
	}

	[CalledBy(Type = typeof(Panel_Rest), Member = "DoPassTime")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Anxiety), Member = "CanPassTime")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "InHibernationPreventionIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	public static bool CheckPassTimeErrorMessage()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateRestDurationLabel()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdateWakeTimeLabel()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	private void UpdateEstimatedCaloriesBurnedLabel()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void UpdateCurrentCaloriesLabel()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	private void UpdateFeelsLikeLabel()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "GetWarmthBonusCelsius")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private void UpdateWarmthBonusLabel()
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "OnRest")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Rest), Member = "BeginSleeping")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Rest), Member = "RestNeededForAffliction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "InHibernationPreventionIndoorEnvironment")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Rest), Member = "AllowUnlimitedSleep")]
	[Calls(Type = typeof(Anxiety), Member = "CanPassTime")]
	private void DoRest(int restAmount, bool wakeUpAtFullRest)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	private void UpdateButtonLegend()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	private void RefreshButtonConfigure(ButtonLegendConfigure[] buttonLegendConfigureArray)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Panel_Rest()
	{
	}
}
