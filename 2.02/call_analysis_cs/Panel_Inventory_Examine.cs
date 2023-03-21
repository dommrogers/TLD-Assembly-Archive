using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
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

	[CallsUnknownMethods(Count = 123)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 31)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public override void Initialize()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnActionsButton")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "ExitInterface")]
	[Calls(Type = typeof(GameManager), Member = "MaybeForceGC")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ExitInspectGearMode")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	public void Enable(bool enable, ComingFromScreenCategory cameFrom)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	public bool IsHarvesting()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	public bool IsRepairing()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CallerCount(Count = 1)]
	public bool IsCleaning()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	public bool IsSharpening()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	public bool IsReading()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnToolIncrease")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnToolDecrease")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectActionTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CheckSelectedButton")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainWindowNavigation")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateReadPanelNavigation")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CanHarvest")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CleanHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CleanHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredTool")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateLabels()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	private void UpdateMainWindowNavigation()
	{
	}

	[Calls(Type = typeof(ResearchItem), Member = "GetHoursResearchRemaining")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	private void UpdateReadPanelNavigation()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	private void CheckSelectedButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	public void OnToolSelectBack()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnToolIncrease")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnToolDecrease")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectActionTool")]
	private void UpdateActionToolSelect()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectActionTool")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnToolDecrease")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnToolIncrease")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	private void UpdateMainAndToolHybrid()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "StopProgressBarAudio")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	private void SetRepairInProgress(bool on)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "StopProgressBarAudio")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	private void SetHarvestInProgress(bool on)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartClean")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectCleanTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanFinished")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RestoreTimeOfDay")]
	private void SetCleanInProgress(bool on)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartSharpen")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectSharpenTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenFinished")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RestoreTimeOfDay")]
	private void SetSharpenInProgress(bool on)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	private void SetReadInProgress(bool on)
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterRepair")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "CanUserCancelAction")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "MaybeAbortReadingWithHUDMessage")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	private void UpdateActionProgressBar()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	private void RestoreTimeOfDay()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectSharpenTool")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartSharpen")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectCleanTool")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartClean")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRepair")]
	private void AccelerateTimeOfDay(int minutes, bool doFadeout)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenFinished")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSelectedTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanFinished")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	private void DegradeToolUsedForAction()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[CallsUnknownMethods(Count = 17)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void ConsumeMaterialsUsedForRepair()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	private void StopProgressBarAudio()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFailed")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredTool")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ConsumeMaterialsUsedForRepair")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	private void RepairFinished()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterRepair")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RepairFailed()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "MaybeUnlockResoluteOutfitterAchievement")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterRepair")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetConditionIncreaseFromRepair")]
	[Calls(Type = typeof(GearItem), Member = "GetMaxHPFromRepair")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	private void RepairSuccessful()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateClothingSkillAfterRepair(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFailed")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	private void UpdateSkillAfterRepair(bool success)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CleanHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	private void CleanFinished()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CleanHasRequiredTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	private void CleanSuccessful()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSkillAfterClean(bool success)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SharpenHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	private void SharpenFinished()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SharpenHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSharpenConditionIncreaseAndDuration")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	private void SharpenSuccessful()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSkillAfterSharpen(bool success)
	{
	}

	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnToolDecrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnToolIncrease")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectToolByIndex")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	private void RefreshSelectedActionTool()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSelectedActionTool")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectSharpenButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshCleanPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSharpenPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectCleanButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[CallsUnknownMethods(Count = 81)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 30)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void RefreshTools()
	{
	}

	[CallsUnknownMethods(Count = 45)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	private void RefreshMaterialsTable()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CanRepair")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRepairPanel")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	private bool RepairHasRequiredTool()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredTool")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionToolSelect")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionToolSelect")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRepairPanel")]
	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceActionSuccess")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetCurrentSkillName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceSuccessfullRepair")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetConditionIncreaseFromRepair")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedRepairDuration")]
	private void UpdateRepairLabels()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CleanHasRequiredTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshCleanPanel")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 53)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void UpdateCleanLabels()
	{
	}

	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHarvest")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSharpenLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateCleanLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	private void UpdateWeightAndConditionLabels()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateCleanLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectCleanTool")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	private void GetCleanConditionIncreaseAndDuration(out float conditionIncrease, out int durationMinutes)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref conditionIncrease) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref durationMinutes) = null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 55)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSharpenPanel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SharpenHasRequiredTool")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 21)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSharpenConditionIncreaseAndDuration")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateSharpenLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectSharpenTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSharpenLabels")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	private void GetSharpenConditionIncreaseAndDuration(out float conditionIncrease, out int durationMinutes)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref conditionIncrease) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref durationMinutes) = null;
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMaterialsTable")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	private void RefreshRepairPanel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CanClean")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CleanHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateCleanLabels")]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshCleanPanel()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshCleanPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateCleanLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanFinished")]
	private bool CleanHasRequiredTool()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSharpenLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SharpenHasRequiredTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CallsDeduplicatedMethods(Count = 5)]
	private void RefreshSharpenPanel()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCapacityLiters")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringNoOunces")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringNoOunces")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void RefreshRefuelPanel()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Skill), Member = "GetProgressToNextLevelAsNormalizedValue")]
	[Calls(Type = typeof(Skill), Member = "GetProgressToNextLevelAsNormalizedValue")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[CallsUnknownMethods(Count = 71)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(ResearchItem), Member = "GetSkillNameLocalized")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void RefreshReadPanel()
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnReadHoursDecrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnReadHoursIncrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateReadPanelNavigation")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ResearchItem), Member = "GetHoursResearchRemaining")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ResearchItem), Member = "GetHoursResearchRemaining")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void RefreshHoursToRead()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSharpenLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSharpenPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSharpen")]
	private bool SharpenHasRequiredTool()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool CanRefuel()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine_MenuItem), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefuelFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnUnload")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallsUnknownMethods(Count = 43)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHarvest")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CanClean")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateCleanLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSharpenPanel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	public void RefreshMainWindow()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	public void OnSelectHarvestButton()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnSelectRepairButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	public void OnSelectRefuelButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	public void OnSelectCleanButton()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnSelectSharpenButton()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
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

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	public void SelectCleanButton(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectUnloadButton(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallsUnknownMethods(Count = 5)]
	public void SelectSharpenButton(bool selected)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRefuelButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectHarvestButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectSharpenButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectUnload")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectCleanButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CheckSelectedButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainWindowNavigation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenFinished")]
	private void SelectButton(int index)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 42)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanFinished")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void RefreshButton()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnEquip()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CanHarvest")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "StartHarvest")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 7)]
	public void OnHarvest()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool RepairRequiresSewingKit()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CanRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private bool RepairHasRequiredMaterial()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredTool")]
	private bool CanRepair()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnRepair()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	public void OnProgressBarCancel()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceActionSuccess")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	private GameObject GetSelectedTool()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionToolSelect")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	public void OnSelectActionTool()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedRepairDuration")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "StartRepair")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRepair")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "GetMaxHPFromRepair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnSelectRepairTool()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceActionSuccess")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairTool")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceSuccessfullRepair")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	private void StartRepair(int durationMinutes, string repairAudio)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetConditionIncreaseFromRepair")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairTool")]
	[CallsUnknownMethods(Count = 1)]
	private int GetModifiedRepairDuration(Repairable r, int baseMinutes)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private int GetModifiedCleanDuration(Cleanable c, float conditionIncrease, int baseMinutes)
	{
		return default(int);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private int GetModifiedSharpenDuration(Sharpenable s, float conditionIncrease, int baseMinutes)
	{
		return default(int);
	}

	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedCleanDuration")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedRepairDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetSharpenConditionIncreaseAndDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSelectedTool")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	private int GetModifiedActionDuration(GearItem gi, float conditionIncrease, int baseMinutes)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RollForActionSuccess")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRepair")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSelectedTool")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private float GetChanceActionSuccess(float skillBaseChance)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceActionSuccess")]
	[CallsUnknownMethods(Count = 1)]
	private bool RollForActionSuccess(float baseSkillChance)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "GetPercentFuelRemaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public void OnRefuel()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "AddFuel")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	public void RefuelFinished(bool success, bool playerCancel, float progress)
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnSelectUnload()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DoUnload")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	public void OnUnload()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnUnload")]
	[Calls(Type = typeof(GunItem), Member = "EmptyClip")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GunItem), Member = "GetAmmoCondition")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryWithCondition")]
	public bool DoUnload()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnClean()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	public void OnSelectCleanTool()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	private void StartClean(int durationMinutes, string cleanAudio)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SharpenHasRequiredTool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectSharpenTool")]
	public void OnSharpen()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateReadPanelNavigation")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(AchievementManager), Member = "ResearchedBook")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "MaybeAbortReadingWithHUDMessage")]
	public void OnRead()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[Calls(Type = typeof(ResearchItem), Member = "Read")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	public void ReadComplete(float normalizedProgress)
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResearchItem), Member = "GetHoursResearchRemaining")]
	public void OnReadHoursIncrease()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnReadHoursDecrease()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSharpen")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSharpenConditionIncreaseAndDuration")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	public void OnSelectSharpenTool()
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void StartSharpen(int durationMinutes, string sharpenAudio)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	private void StartRead(int durationMinutes, string readAudio)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateReadPanelNavigation")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnEquip")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainWindowNavigation")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	public void OnBack()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSelectedActionTool")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ExitInspectGearMode")]
	private void SelectWindow(GameObject window)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionToolSelect")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSelectedActionTool")]
	public void OnToolIncrease()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionToolSelect")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSelectedActionTool")]
	public void OnToolDecrease()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSelectedActionTool")]
	[CallsUnknownMethods(Count = 2)]
	public void SelectToolByIndex(int index)
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnHarvest")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	public void StartHarvest()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnHarvest")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool CanHarvest()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 83)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowPowder")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	private void RefreshHarvest()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	private bool CheckForHarvestSuccess(Harvest harvest)
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "MaybeReturnAmmoOrFuelToInventory")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 56)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CheckForHarvestSuccess")]
	[Calls(Type = typeof(PlayerManager), Member = "AddPowderToInventory")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CheckForHarvestSuccess")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void HarvestSuccessful()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "AddLiquidToInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	private void MaybeReturnAmmoOrFuelToInventory(GearItem gi)
	{
	}

	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(PlayerManager), Member = "RestoreTransformFromLastInspection")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	private void EnterInspectGearMode()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ExitInspectGearMode()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshCleanPanel")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool CanClean(GearItem gi)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "CanUserCancelAction")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateButtonLegend()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Condition), Member = "HasNonRiskAffliction")]
	private bool MaybeAbortReadingWithHUDMessage()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	private float GetChanceSuccessfullRepair(GearItem gi)
	{
		return default(float);
	}

	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierName")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetCurrentSkillName(GearItem gi)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetConditionIncreaseFromRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetCurrentSkillName")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceSuccessfullRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private bool GearItemIsConsideredClothing(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedRepairDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	private float GetConditionIncreaseFromRepair(GearItem gi)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 35)]
	public Panel_Inventory_Examine()
	{
	}
}
