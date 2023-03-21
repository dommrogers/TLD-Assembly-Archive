using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_CustomXPSetup : Panel_Base
{
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

	private int m_CustomXPSelectedButtonIndex;

	private string m_CachedCustomModeString;

	private uint m_CachedMaxLength;

	private string m_CachedKeyboardDesc;

	private Vector2 m_MousePositionLastFrame;

	private float m_ScrollPanelHeight;

	private List<string> m_XPModeStringList;

	private List<string> m_StartTODStringList;

	private List<string> m_StartWeatherStringList;

	private List<string> m_YesNoStringList;

	private List<string> m_DayNightMultiplierStringList;

	private List<string> m_DistanceStringList;

	private List<string> m_TunableLMHStringList;

	private List<string> m_TunableNLHStringList;

	private List<string> m_TunableLMHVStringList;

	private List<string> m_TunableNLMHStringList;

	private List<string> m_TunableNLMHVStringList;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "InitializeCustomXPMenuItems")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override void Initialize()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "ResetToDefault")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "InitializeLockableOptionUI")]
	[CallsUnknownMethods(Count = 1)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void OnCancel()
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "DoMainScreenControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(GameManager), Member = "RegionLockedBySelectedMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetCustomXPSettingsFromUI")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentCustomModeString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void OnContinue()
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "DoMainScreenControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentCustomModeString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public void OnShareExperiencePopup()
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "DoMainScreenControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentCustomModeString")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetupInputField")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 28)]
	public void OnEnterCode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetCurrentCustomModeString")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetUIFromCurrentCustomXP")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetupInputField")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void OnEnterCodePopupConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetCurrentCustomModeString")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetUIFromCurrentCustomXP")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetupInputField")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void OnEnterCodePopupCancelled(bool wasCancelled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "UpdateSlider")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnScrollbarChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public string AddDashesToCustomModeString(string customString)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCodePopupConfirmed")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCodePopupCancelled")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetValuesToMatchXPMode")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "ResetToDefault")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetXPModePopupListString")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 62)]
	public void SetUIFromCurrentCustomXP()
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "DoMainScreenControls")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void DoScroll(float scrollAmount)
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnScrollbarChange")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "ResetToDefault")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateSlider()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateButtonLegendMainScreen()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateButtonLegendSharePopup()
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnContinue")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateAfterTunableChange")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "UpdateBaseValues")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 125)]
	private void SetCustomXPSettingsFromUI()
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 64)]
	[CallsUnknownMethods(Count = 145)]
	private void InitializeCustomXPMenuItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetCurrentCustomModeString")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetUIFromCurrentCustomXP")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void SetValuesToMatchXPMode()
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetUIFromCurrentCustomXP")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateAfterTunableChange")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentCustomModeString")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void SetXPModePopupListString()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetCustomXPSettingsFromUI")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetXPModePopupListString")]
	private void UpdateAfterTunableChange()
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "SetUIFromCurrentCustomXP")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "UpdateSlider")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void ResetToDefault()
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "DoMainScreenControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(UIPanel), Member = "IsVisible")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "DoScroll")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMouseOver")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 64)]
	private void UpdateMenuNavigation(ref int index, List<GameObject> menuItems)
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetUIFromCurrentCustomXP")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetXPModePopupListString")]
	[CallerCount(Count = 63)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SetConsoleComboBoxIndex(ConsoleComboBox comboBox, int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "DoScroll")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "OnShareExperiencePopup")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCode")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "OnContinue")]
	[Calls(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CallsDeduplicatedMethods(Count = 1)]
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
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 275)]
	public Panel_CustomXPSetup()
	{
	}
}
