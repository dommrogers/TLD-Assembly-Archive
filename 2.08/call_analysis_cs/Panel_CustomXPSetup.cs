using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_CustomXPSetup : Panel_AutoReferenced
{
	private PanelReference<Panel_Confirmation> m_Confirmation;

	private SandboxConfig m_CustomGameModeConfig;

	public float m_ComboBoxHeight;

	public float m_SectionHeaderHeight;

	public string[] m_BaseXPModeCustomStrings;

	public List<GameObject> m_CustomXPMenuItemOrder;

	public List<GameObject> m_SectionList;

	public ConsoleComboBox m_XPModePopupList;

	public ConsoleComboBox m_BaseDifficultyPopupList;

	public ConsoleComboBox m_StartingTODPopupList;

	public ConsoleComboBox m_StartingWeatherPopupList;

	public ConsoleComboBox m_AllowInteriorSpawnPopupList;

	public ConsoleComboBox m_AllowVoiceoverPopupList;

	public ConsoleComboBox m_DayNightMultiplierPopupList;

	public ConsoleComboBox m_WeatherChangeFreqPopupList;

	public ConsoleComboBox m_BlizzardFreqPopupList;

	public ConsoleComboBox m_GradualTempReductionPopupList;

	public ConsoleComboBox m_WindVariabilityPopupList;

	public ConsoleComboBox m_AuroraFreqPopupList;

	public ConsoleComboBox m_UseMinAirTempPopupList;

	public ConsoleComboBox m_CalorieBurnRatePopupList;

	public ConsoleComboBox m_ThirstIncreasePopupList;

	public ConsoleComboBox m_FatigueIncreasePopupList;

	public ConsoleComboBox m_FreezingIncreasePopupList;

	public ConsoleComboBox m_ConditionRecoveryRestPopupList;

	public ConsoleComboBox m_ConditionRecoveryAwakePopupList;

	public ConsoleComboBox m_HoursToCureHypothermiaPopupList;

	public ConsoleComboBox m_FrostbiteRiskPopupList;

	public ConsoleComboBox m_CabinFeverEnabledPopupList;

	public ConsoleComboBox m_ParasitesEnabledPopupList;

	public ConsoleComboBox m_DysenteryEnabledPopupList;

	public ConsoleComboBox m_SprainsEnabledPopupList;

	public ConsoleComboBox m_FoodPoisoningEnabledPopupList;

	public ConsoleComboBox m_BrokenRibsEnabledPopupList;

	public ConsoleComboBox m_LimitedRestPopupList;

	public ConsoleComboBox m_AdjustFreezingNearbyFirePopupList;

	public ConsoleComboBox m_InterruptIfFreezingWhileSleepingPopupList;

	public ConsoleComboBox m_BirchBarkEnabledPopupList;

	public ConsoleComboBox m_ItemDecayRatePopupList;

	public ConsoleComboBox m_ItemSpawnChancePopupList;

	public ConsoleComboBox m_EmptyContainerChancePopupList;

	public ConsoleComboBox m_StickBranchStoneFreqPopupList;

	public ConsoleComboBox m_StartingGearPopupList;

	public ConsoleComboBox m_RiflesInWorldPopupList;

	public ConsoleComboBox m_RevolversInWorldPopupList;

	public ConsoleComboBox m_PlantSpawnFreqPopupList;

	public ConsoleComboBox m_ReduceMaxItemsInContainersPopupList;

	public ConsoleComboBox m_StrugglePlayerStrengthBonusPopupList;

	public ConsoleComboBox m_StruggleDamageReceivedModifierPopupList;

	public ConsoleComboBox m_StruggleClothingDamagePopupList;

	public ConsoleComboBox m_FishSpawnChancePopupList;

	public ConsoleComboBox m_WolfSpawnDistancePopupList;

	public ConsoleComboBox m_WolfFleeChancePopupList;

	public ConsoleComboBox m_TimberWolfPackFearPopupList;

	public ConsoleComboBox m_WildlifeDetectionRangePopupList;

	public ConsoleComboBox m_WildlifeInterruptRestPopupList;

	public ConsoleComboBox m_StruggleDamageEventSeverityPopupList;

	public ConsoleComboBox m_WildlifeSmellRangePopupList;

	public ConsoleComboBox m_SmellIncreaseBloodPopupList;

	public ConsoleComboBox m_WolfSpawnChancePopupList;

	public ConsoleComboBox m_TimberWolfSpawnChancePopupList;

	public ConsoleComboBox m_DeerSpawnChancePopupList;

	public ConsoleComboBox m_RabbitSpawnChancePopupList;

	public ConsoleComboBox m_BearSpawnChancePopupList;

	public ConsoleComboBox m_MooseSpawnChancePopupList;

	public ConsoleComboBox m_WildlifeRespawnFreqPopupList;

	public ConsoleComboBox m_ReduceWildlifePopOverTimePopupList;

	public ConsoleComboBox m_WildlifeNotAttackUnprovokedPopupList;

	public ConsoleComboBox m_NoPredatorsFirstDayPopupList;

	public ConsoleComboBox m_EndlessNightPopupList;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public GameObject m_Scrollbar;

	public UIPanel m_ScrollPanel;

	public Transform m_ScrollPanelOffsetTransform;

	public UILabel m_TooltipLabel;

	public GameObject m_ShareExperiencePopupObj;

	public UILabel m_ShareExperiencePopupLabel;

	private CustomExperienceMode m_CustomMode;

	private int m_CustomXPSelectedButtonIndex;

	private string m_CachedCustomModeString;

	private uint m_CachedMaxLength;

	private string m_CachedKeyboardDesc;

	private Vector2 m_MousePositionLastFrame;

	private float m_ScrollPanelHeight;

	private static readonly string[] m_XPModeStringList;

	private static readonly string[] m_StartTODStringList;

	private static readonly string[] m_StartWeatherStringList;

	private static readonly string[] m_YesNoStringList;

	private static readonly string[] m_DayNightMultiplierStringList;

	private static readonly string[] m_DistanceStringList;

	private static readonly string[] m_TunableLMHStringList;

	private static readonly string[] m_TunableNLHStringList;

	private static readonly string[] m_TunableLMHVStringList;

	private static readonly string[] m_TunableNLMHStringList;

	private static readonly string[] m_TunableNLMHVStringList;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "InitializeCustomXPMenuItems")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "DoMainScreenControls")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "ResetToDefault")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "InitializeLockableOptionUI")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsUnknownMethods(Count = 3)]
	public void OnCancel()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "DoMainScreenControls")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "CreateStringFromCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetCustomXPSettingsFromUI")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "ShouldBePartOfFlow")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "RegionLockedBySelectedMode")]
	public void OnContinue()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "CreateStringFromCustomMode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Insert")]
	public void OnShareExperiencePopup()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "DoMainScreenControls")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "CreateStringFromCustomMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetupInputField")]
	public void OnEnterCode()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetUIFromCurrentCustomXP")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetupInputField")]
	[CallsUnknownMethods(Count = 1)]
	public void OnEnterCodePopupConfirmed()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetupInputField")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetUIFromCurrentCustomXP")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	public void OnEnterCodePopupCancelled(bool wasCancelled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "UpdateSlider")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnScrollbarChange()
	{
	}

	[Calls(Type = typeof(string), Member = "Insert")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Insert")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Insert")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Insert")]
	private string AddDashesToCustomModeString(string customString)
	{
		return null;
	}

	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "ResetToDefault")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetValuesToMatchXPMode")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCodePopupCancelled")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCodePopupConfirmed")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetXPModePopupListString")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	public void SetUIFromCurrentCustomXP()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	private void SetCustomModeString(string modeString)
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "DoMainScreenControls")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "DoMainScreenControls")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	private void DoScroll(float scrollAmount)
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "ResetToDefault")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnScrollbarChange")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	private void UpdateSlider()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateButtonLegendMainScreen()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void UpdateButtonLegendSharePopup()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateAfterTunableChange")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnContinue")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "UpdateBaseValues")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void SetCustomXPSettingsFromUI()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "Initialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 66)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	private void InitializeCustomXPMenuItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetUIFromCurrentCustomXP")]
	[CallsUnknownMethods(Count = 2)]
	private void SetValuesToMatchXPMode()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CustomExperienceMode), Member = "CreateStringFromCustomMode")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetUIFromCurrentCustomXP")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateAfterTunableChange")]
	private void SetXPModePopupListString()
	{
	}

	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetCustomXPSettingsFromUI")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetXPModePopupListString")]
	[CallerCount(Count = 0)]
	private void UpdateAfterTunableChange()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetUIFromCurrentCustomXP")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "UpdateSlider")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "Enable")]
	[CallsUnknownMethods(Count = 4)]
	private void ResetToDefault()
	{
	}

	[Calls(Type = typeof(UIPanel), Member = "IsVisible")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "DoMainScreenControls")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMouseOver")]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 28)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(UIPanel), Member = "IsVisible")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "DoScroll")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "DoScroll")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	private void UpdateMenuNavigation(ref int index, List<GameObject> menuItems)
	{
	}

	[CallerCount(Count = 63)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void SetConsoleComboBoxIndex(ConsoleComboBox comboBox, int index)
	{
	}

	[Calls(Type = typeof(string), Member = "Insert")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "OnContinue")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "Update")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCode")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "DoScroll")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "DoScroll")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CustomExperienceMode), Member = "CreateStringFromCustomMode")]
	private void DoMainScreenControls()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "InitializeLockableOptionUI")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshEndlessNightOption()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool IsEndlessNightOptionUnlocked()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Panel_CustomXPSetup()
	{
	}
}
