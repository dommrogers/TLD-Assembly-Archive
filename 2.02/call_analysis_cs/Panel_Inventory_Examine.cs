using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Inventory_Examine : Panel_Base
{
	private delegate void OnMethod();

	private enum ButtonChoice
	{
		Refuel,
		Repair,
		Clean,
		Sharpen,
		Harvest,
		Unload,
		Read
	}

	public ButtonLegendContainer m_ButtonLegendContainer;

	public GameObject m_FireContainer;

	public UIWidget m_ExamineWidget;

	public GameObject m_MainWindow;

	public GameObject m_HarvestWindow;

	public GameObject m_ActionToolSelect;

	public GameObject m_RepairPanel;

	public GameObject m_CleanPanel;

	public GameObject m_SharpenPanel;

	public GameObject m_RifleUnloadPanel;

	public GameObject m_ReadPanel;

	public GameObject m_ActionInProgressWindow;

	public ScrollList m_ToolScrollList;

	public UIButton m_Button_Harvest;

	public UIButton m_Button_Repair;

	public UIButton m_Button_Refuel;

	public UIButton m_Button_Unload;

	public UIButton m_Button_Clean;

	public UIButton m_Button_Sharpen;

	public GameObject m_Button_HarvestBackground;

	public GameObject m_Button_RepairBackground;

	public GameObject m_Button_RefuelBackground;

	public GameObject m_Button_UnloadBackground;

	public GameObject m_Button_CleanBackground;

	public GameObject m_Button_SharpenBackground;

	public UISprite[] m_ItemIcons;

	public UILabel m_Item_Label;

	public UITexture m_GearItemTexture;

	public Transform m_ButtonTopLeftLocation;

	public float m_ButtonSpacing;

	public GameObject m_MainWindow_Buttons;

	public UILabel m_Stack_Label;

	public UILabel m_Repair_SkillLabel;

	public UILabel m_Repair_AmountLabel;

	public UILabel m_Repair_ChanceSuccessLabel;

	public UILabel m_Repair_ConditionCapLabel;

	public UILabel m_Repair_TimeLabel;

	public GameObject m_RequiredMaterialsArea;

	public Color m_RequiredMaterialsLabelDefaultColor;

	public UILabel m_Repair_RequiredMaterialsLabel;

	public HarvestRepairMaterial[] m_RequiredMaterials;

	public float m_RequiredMaterialCenteredX;

	public float m_RequiredMaterialSpacing;

	public float m_SkillIncreaseChanceOnSuccess;

	public float m_SkillIncreaseChanceOnFailure;

	public float m_RepairTimeSeconds;

	public Color m_RepairLabelColorNormal;

	public Color m_RepairLabelColorNormalHover;

	public Color m_RepairLabelColorNormalSelected;

	public Color m_RepairLabelColorDisabled;

	public Color m_RepairLabelColorDisabledHover;

	public Color m_RepairLabelColorDisabledSelected;

	public Color m_HighConditionColor;

	public string m_NoToolSpriteName;

	public Color m_NoToolSpriteColor;

	public Vector3 m_NoToolSpriteSizeModifier;

	public UILabel m_RequiresToolLabel;

	public GameObject m_RepairPanel_Buttons;

	public GameObject m_MouseRepairButton;

	public ToolsItem m_SewingKitToolsItem;

	public UISprite m_Clean_X;

	public UILabel m_Clean_SkillLabel;

	public UILabel m_Clean_AmountLabel;

	public UILabel m_Clean_ChanceSuccessLabel;

	public UILabel m_Clean_TimeLabel;

	public UITexture m_CleanRequiresToolSprite;

	public UILabel m_CleanRequiresToolNameLabel;

	public UILabel m_CleanRequiresToolLabel;

	public GameObject m_CleanPanel_Buttons;

	public GameObject m_MouseCleanButton;

	public float m_Clean_SkillIncreaseChanceOnSuccess;

	public float m_Clean_SkillIncreaseChanceOnFailure;

	public float m_CleanTimeSeconds;

	public UISprite m_Sharpen_X;

	public UILabel m_Sharpen_SkillLabel;

	public UILabel m_Sharpen_AmountLabel;

	public UILabel m_Sharpen_ChanceSuccessLabel;

	public UILabel m_Sharpen_TimeLabel;

	public UITexture m_SharpenRequiresToolSprite;

	public UILabel m_SharpenRequiresToolNameLabel;

	public UILabel m_SharpenRequiresToolLabel;

	public GameObject m_SharpenPanel_Buttons;

	public GameObject m_MouseSharpenButton;

	public float m_Sharpen_SkillIncreaseChanceOnSuccess;

	public float m_Sharpen_SkillIncreaseChanceOnFailure;

	public float m_SharpenTimeSeconds;

	public UISprite m_ResearchIcon;

	public GameObject m_MouseReadButton;

	public UILabel m_BookNameLabel;

	public UILabel m_BookDescLabel;

	public UILabel m_SkillImprovedLabel;

	public UILabel m_TimeToReadRemainingLabel;

	public UILabel m_TimeToReadLabel;

	public UILabel m_SkillLevelLabel;

	public UILabel m_SkillProgressBarLabel;

	public UIProgressBar m_SkillProgressBar;

	public UISprite m_SkillProgressBarSprite;

	public UIButton m_ReadHoursIncrease;

	public UIButton m_ReadHoursDecrease;

	public UISprite m_GamepadReadHoursSpriteIncrease;

	public UISprite m_GamepadReadHoursSpriteDecrease;

	public float m_ReadTimeSeconds;

	public UISprite m_Tool_ConditionSprite;

	public UISprite m_Tool_ConditionBarBG;

	public UISprite m_Tool_ConditionBarFG;

	public UILabel m_SelectedToolName_Label;

	public UILabel m_Tool_Condition_Label;

	public GameObject m_Button_ToolIncrease;

	public GameObject m_Button_ToolDecrease;

	public UILabel m_Tool_ConfirmButtonLabel;

	public GameObject m_ItemConditionObject;

	public UISprite m_ConditionSprite;

	public UILabel m_ConditionLabel;

	public UILabel m_WeightLabel;

	public UILabel m_HarvestItemName_Label;

	public UILabel m_HarvestTime_Label;

	public HarvestRepairMaterial[] m_HarvestYields;

	public float m_HarvestYieldCenteredX;

	public float m_HarvestYieldSpacing;

	public float m_HarvestTimeSeconds;

	public GameObject m_HarvestYieldRoot;

	public GameObject m_HarvestYieldThreeRoot;

	public HarvestRepairMaterial[] m_HarvestThreeYields;

	public UILabel m_HarvestRequiresToolLabel;

	public GameObject m_RefuelPanel;

	public UISprite m_Refuel_X;

	public GameObject m_RequiresFuelMessage;

	public GameObject m_ControllerRefuelButton;

	public GameObject m_MouseRefuelButton;

	public UILabel m_LanternFuelAmountLabel;

	public UILabel m_FuelSupplyAmountLabel;

	public UISlider m_Slider_ActionProgress;

	public UILabel m_ProgressBarLabelRepair;

	public UILabel m_ProgressBarLabelHarvest;

	public GameObject[] m_ButtonsToDisableDuringProgressBar;

	public GearItem m_GearItem;

	public bool m_EnableInventoryOnBack;

	private bool m_HarvestInProgress;

	private int m_NumUnitsLeftToHarvest;

	private bool m_ItemHarvestable;

	private float m_ElapsedProgressBarSeconds;

	private float m_ProgressBarTimeSeconds;

	private uint m_ProgressBarAudio;

	private bool m_ItemSharpenable;

	private bool m_SharpenInProgress;

	private bool m_ReadInProgress;

	private int m_HoursToRead;

	private bool m_ItemRepairable;

	private bool m_RepairInProgress;

	private bool m_RepairWillSucceed;

	private bool m_ItemCleanable;

	private bool m_CleanInProgress;

	private int m_SelectedToolIndex;

	private float m_FailureAtProgressPercentage;

	private float m_DayLengthScaleBeforeRepair;

	private bool m_TimeAccelerated;

	private Panel_Inventory_Examine_MenuItem m_MenuItemClean;

	private Panel_Inventory_Examine_MenuItem m_MenuItemHarvest;

	private Panel_Inventory_Examine_MenuItem m_MenuItemRefuel;

	private Panel_Inventory_Examine_MenuItem m_MenuItemRepair;

	private Panel_Inventory_Examine_MenuItem m_MenuItemSharpen;

	private Panel_Inventory_Examine_MenuItem m_MenuItemUnload;

	private List<GameObject> m_Tools;

	private List<UIButton> m_Buttons;

	private List<Panel_Inventory_Examine_MenuItem> m_ButtonsMenuItems;

	private List<OnMethod> m_ButtonDelegates;

	private int m_SelectedButtonIndex;

	private bool m_IsInInspectGearMode;

	private ComingFromScreenCategory m_CameFromScreenCategory;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 123)]
	public override void Initialize()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnActionsButton")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "ExitInterface")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(GameManager), Member = "MaybeForceGC")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 25)]
	public void Enable(bool enable, ComingFromScreenCategory cameFrom)
	{
	}

	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CallerCount(Count = 1)]
	public bool IsHarvesting()
	{
		return false;
	}

	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool IsRepairing()
	{
		return false;
	}

	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CallerCount(Count = 1)]
	public bool IsCleaning()
	{
		return false;
	}

	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CallerCount(Count = 1)]
	public bool IsSharpening()
	{
		return false;
	}

	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CallerCount(Count = 1)]
	public bool IsReading()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CheckSelectedButton")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainWindowNavigation")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateReadPanelNavigation")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectActionTool")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnToolIncrease")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnToolDecrease")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 17)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CleanHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CanHarvest")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	private void UpdateLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 27)]
	private void UpdateMainWindowNavigation()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(ResearchItem), Member = "GetHoursResearchRemaining")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateReadPanelNavigation()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 21)]
	private void CheckSelectedButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	public void OnToolSelectBack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectActionTool")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnToolIncrease")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnToolDecrease")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateActionToolSelect()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnToolIncrease")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnToolDecrease")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectActionTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 25)]
	private void UpdateMainAndToolHybrid()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRepair")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RestoreTimeOfDay")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void SetRepairInProgress(bool on)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RestoreTimeOfDay")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void SetHarvestInProgress(bool on)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectCleanTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartClean")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RestoreTimeOfDay")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void SetCleanInProgress(bool on)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectSharpenTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartSharpen")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RestoreTimeOfDay")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void SetSharpenInProgress(bool on)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRead")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RestoreTimeOfDay")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void SetReadInProgress(bool on)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "CanUserCancelAction")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "MaybeAbortReadingWithHUDMessage")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterRepair")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	private void UpdateActionProgressBar()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void RestoreTimeOfDay()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectCleanTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartClean")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectSharpenTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartSharpen")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartHarvest")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void AccelerateTimeOfDay(int minutes, bool doFadeout)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void DegradeToolUsedForAction()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	private void ConsumeMaterialsUsedForRepair()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void StopProgressBarAudio()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFailed")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ConsumeMaterialsUsedForRepair")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CallsUnknownMethods(Count = 1)]
	private void RepairFinished()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterRepair")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void RepairFailed()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetConditionIncreaseFromRepair")]
	[Calls(Type = typeof(GearItem), Member = "GetMaxHPFromRepair")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterRepair")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeUnlockResoluteOutfitterAchievement")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	private void RepairSuccessful()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateClothingSkillAfterRepair(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFailed")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSkillAfterRepair(bool success)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CleanHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CallsUnknownMethods(Count = 1)]
	private void CleanFinished()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CleanHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void CleanSuccessful()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSkillAfterClean(bool success)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SharpenHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CallsUnknownMethods(Count = 1)]
	private void SharpenFinished()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSharpenConditionIncreaseAndDuration")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SharpenHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void SharpenSuccessful()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSkillAfterSharpen(bool success)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnToolIncrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnToolDecrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectToolByIndex")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 23)]
	private void RefreshSelectedActionTool()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshCleanPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSharpenPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectCleanButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectSharpenButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSelectedActionTool")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 81)]
	public void RefreshTools()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRepairPanel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 45)]
	private void RefreshMaterialsTable()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CanRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRepair")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool RepairHasRequiredTool()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionToolSelect")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRepairPanel")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceSuccessfullRepair")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetCurrentSkillName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceActionSuccess")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedRepairDuration")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetConditionIncreaseFromRepair")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredTool")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 42)]
	private void UpdateRepairLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshCleanPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CleanHasRequiredTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 53)]
	private void UpdateCleanLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateCleanLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSharpenLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHarvest")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateWeightAndConditionLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateCleanLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectCleanTool")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	private void GetCleanConditionIncreaseAndDuration(out float conditionIncrease, out int durationMinutes)
	{
		conditionIncrease = default(float);
		durationMinutes = default(int);
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSharpenPanel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSharpenConditionIncreaseAndDuration")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SharpenHasRequiredTool")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 55)]
	private void UpdateSharpenLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSharpenLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectSharpenTool")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void GetSharpenConditionIncreaseAndDuration(out float conditionIncrease, out int durationMinutes)
	{
		conditionIncrease = default(float);
		durationMinutes = default(int);
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMaterialsTable")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	private void RefreshRepairPanel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CanClean")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CleanHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateCleanLabels")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshCleanPanel()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateCleanLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshCleanPanel")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool CleanHasRequiredTool()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SharpenHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSharpenLabels")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private void RefreshSharpenPanel()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCapacityLiters")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 42)]
	private void RefreshRefuelPanel()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ResearchItem), Member = "GetSkillNameLocalized")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(Skill), Member = "GetProgressToNextLevelAsNormalizedValue")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 71)]
	private void RefreshReadPanel()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateReadPanelNavigation")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnReadHoursIncrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnReadHoursDecrease")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ResearchItem), Member = "GetHoursResearchRemaining")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 23)]
	private void RefreshHoursToRead()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSharpenLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSharpenPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSharpen")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool SharpenHasRequiredTool()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool CanRefuel()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefuelFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnUnload")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHarvest")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CanClean")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateCleanLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSharpenPanel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine_MenuItem), Member = "Update")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 43)]
	public void RefreshMainWindow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnSelectHarvestButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnSelectRepairButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnSelectRefuelButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnSelectCleanButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnSelectSharpenButton()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectHarvestButton(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SelectRepairButton(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectRefuelButton(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void SelectCleanButton(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectUnloadButton(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void SelectSharpenButton(bool selected)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainWindowNavigation")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CheckSelectedButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectHarvestButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRefuelButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectCleanButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectSharpenButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectUnload")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private void SelectButton(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 42)]
	private void RefreshButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnEquip()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CanHarvest")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "StartHarvest")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void OnHarvest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private bool RepairRequiresSewingKit()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CanRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRepair")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	private bool RepairHasRequiredMaterial()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredTool")]
	private bool CanRepair()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredTool")]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void OnRepair()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public void OnProgressBarCancel()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceActionSuccess")]
	[CallerCount(Count = 5)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private GameObject GetSelectedTool()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionToolSelect")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	[CallerCount(Count = 3)]
	public void OnSelectActionTool()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRepair")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "GetMaxHPFromRepair")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedRepairDuration")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "StartRepair")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 22)]
	public void OnSelectRepairTool()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairTool")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceSuccessfullRepair")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceActionSuccess")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void StartRepair(int durationMinutes, string repairAudio)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairTool")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetConditionIncreaseFromRepair")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int GetModifiedRepairDuration(Repairable r, int baseMinutes)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int GetModifiedCleanDuration(Cleanable c, float conditionIncrease, int baseMinutes)
	{
		return 0;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private int GetModifiedSharpenDuration(Sharpenable s, float conditionIncrease, int baseMinutes)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetSharpenConditionIncreaseAndDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedRepairDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedCleanDuration")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private int GetModifiedActionDuration(GearItem gi, float conditionIncrease, int baseMinutes)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RollForActionSuccess")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float GetChanceActionSuccess(float skillBaseChance)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceActionSuccess")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool RollForActionSuccess(float baseSkillChance)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "GetPercentFuelRemaining")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public void OnRefuel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "AddFuel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void RefuelFinished(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnSelectUnload()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DoUnload")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnUnload()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnUnload")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(GunItem), Member = "GetAmmoCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryWithCondition")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(GunItem), Member = "EmptyClip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public bool DoUnload()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnClean()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public void OnSelectCleanTool()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void StartClean(int durationMinutes, string cleanAudio)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SharpenHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectSharpenTool")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnSharpen()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateReadPanelNavigation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "MaybeAbortReadingWithHUDMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AchievementManager), Member = "ResearchedBook")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	public void OnRead()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(ResearchItem), Member = "Read")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void ReadComplete(float normalizedProgress)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResearchItem), Member = "GetHoursResearchRemaining")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnReadHoursIncrease()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnReadHoursDecrease()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSharpen")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSharpenConditionIncreaseAndDuration")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public void OnSelectSharpenTool()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void StartSharpen(int durationMinutes, string sharpenAudio)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void StartRead(int durationMinutes, string readAudio)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainWindowNavigation")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateReadPanelNavigation")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnEquip")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 13)]
	public void OnBack()
	{
	}

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSelectedActionTool")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 31)]
	private void SelectWindow(GameObject window)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionToolSelect")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSelectedActionTool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnToolIncrease()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionToolSelect")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSelectedActionTool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnToolDecrease()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSelectedActionTool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectToolByIndex(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnHarvest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public void StartHarvest()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnHarvest")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private bool CanHarvest()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowPowder")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 83)]
	private void RefreshHarvest()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool CheckForHarvestSuccess(Harvest harvest)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CheckForHarvestSuccess")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "AddPowderToInventory")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "MaybeReturnAmmoOrFuelToInventory")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 56)]
	private void HarvestSuccessful()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "AddLiquidToInventory")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 26)]
	private void MaybeReturnAmmoOrFuelToInventory(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[Calls(Type = typeof(PlayerManager), Member = "RestoreTransformFromLastInspection")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	private void EnterInspectGearMode()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public void ExitInspectGearMode()
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "CanExamine")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshCleanPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool CanClean(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "CanUserCancelAction")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 20)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(Condition), Member = "HasNonRiskAffliction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	private bool MaybeAbortReadingWithHUDMessage()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRepair")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private float GetChanceSuccessfullRepair(GearItem gi)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierName")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private string GetCurrentSkillName(GearItem gi)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceSuccessfullRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetCurrentSkillName")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetConditionIncreaseFromRepair")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private bool GearItemIsConsideredClothing(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedRepairDuration")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private float GetConditionIncreaseFromRepair(GearItem gi)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 35)]
	public Panel_Inventory_Examine()
	{
	}
}
