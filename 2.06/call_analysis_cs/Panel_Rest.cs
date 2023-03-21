using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Rest : Panel_AutoReferenced, IAccelerateTimeProvider
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public override void Initialize()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Rest), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Condition), Member = "GetConditionValueForInterfaceDisplay")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Rest), Member = "UpdateFeelsLikeLabel")]
	[Calls(Type = typeof(Panel_Rest), Member = "UpdateWarmthBonusLabel")]
	[Calls(Type = typeof(Panel_Rest), Member = "UpdateCurrentCaloriesLabel")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Rest), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	private void UpdateVisuals()
	{
	}

	[CalledBy(Type = typeof(SnowShelterManager), Member = "OnBedroll")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "OnBedroll")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "OnBedroll")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "OnBedroll")]
	[CalledBy(Type = typeof(LeanToManager), Member = "OnBedroll")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Bed), Member = "PerformInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(LeanToManager), Member = "OnBedroll")]
	public void StartRest(Bed b)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoPassTime")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 11)]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsPassingTimeOnly()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 3)]
	public void OnSelectRest()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnSelectPassTime()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Rest), Member = "DoRest")]
	public void OnRest()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void OnFullRest()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnPassTime()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[Calls(Type = typeof(PassTime), Member = "Begin")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Rest), Member = "CheckPassTimeErrorMessage")]
	public bool DoPassTime(float sleepHours)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Bed), Member = "SetState")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	public void OnPickUp()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
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

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "DoPassTime")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Anxiety), Member = "CanPassTime")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "InHibernationPreventionIndoorEnvironment")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public static bool CheckPassTimeErrorMessage()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateRestDurationLabel()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void UpdateWakeTimeLabel()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateEstimatedCaloriesBurnedLabel()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void UpdateCurrentCaloriesLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	private void UpdateFeelsLikeLabel()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "GetWarmthBonusCelsius")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void UpdateWarmthBonusLabel()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "OnRest")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Rest), Member = "BeginSleeping")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Rest), Member = "RestNeededForAffliction")]
	[Calls(Type = typeof(Rest), Member = "AllowUnlimitedSleep")]
	[Calls(Type = typeof(Anxiety), Member = "CanPassTime")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "InHibernationPreventionIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void DoRest(int restAmount, bool wakeUpAtFullRest)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[CallAnalysisFailed]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshButtonConfigure(ButtonLegendConfigure[] buttonLegendConfigureArray)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool IsAcceleratingTime()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public string GetActionText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public string GetSpriteName()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIPanel GetPanelToFade()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UIWidget GetWidgetToFade()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Action GetCancelAction()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void StartAcceleratingTime()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void StopAcceleratingTime()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public Panel_Rest()
	{
	}
}
