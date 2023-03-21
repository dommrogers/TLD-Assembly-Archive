using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Inventory_Examine : Panel_AutoReferenced, IAccelerateTimeProvider
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

	public string m_IconNameHarvestingItem;

	public string m_IconNameRepairingItem;

	public string m_IconNameCleaningRifle;

	public string m_IconNameSharpening;

	public string m_IconNameResearching;

	private PanelReference<Panel_Clothing> m_Clothing;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	private PanelReference<Panel_Inventory> m_Inventory;

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

	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 59)]
	public override void Initialize()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnActionsButton")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "MaybeForceGC")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ExitInspectGearMode")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 6)]
	public void Enable(bool enable, ComingFromScreenCategory cameFrom)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsHarvesting()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsRepairing()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsCleaning()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsSharpening()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsReading()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnToolIncrease")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnToolDecrease")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectActionTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CheckSelectedButton")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainWindowNavigation")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateReadPanelNavigation")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CanHarvest")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CleanHasRequiredTool")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CleanHasRequiredTool")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateLabels()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	private void UpdateMainWindowNavigation()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(ResearchItem), Member = "GetHoursResearchRemaining")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void UpdateReadPanelNavigation()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 16)]
	private void CheckSelectedButton()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallerCount(Count = 0)]
	public void OnToolSelectBack()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
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
	private void UpdateActionToolSelect()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectActionTool")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnToolIncrease")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnToolDecrease")]
	private void UpdateMainAndToolHybrid()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	private void SetRepairInProgress(bool on)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
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
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CallsUnknownMethods(Count = 7)]
	private void SetCleanInProgress(bool on)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectSharpenTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartSharpen")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 6)]
	private void SetSharpenInProgress(bool on)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RestoreTimeOfDay")]
	private void SetReadInProgress(bool on)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterClean")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterRepair")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "CanUserCancelAction")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "MaybeAbortReadingWithHUDMessage")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSharpenConditionIncreaseAndDuration")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterSharpen")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateActionProgressBar()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	private void RestoreTimeOfDay()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartSharpen")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectSharpenTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectCleanTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRepair")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartClean")]
	private void AccelerateTimeOfDay(int minutes, bool doFadeout)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DegradeToolUsedForAction()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void ConsumeMaterialsUsedForRepair()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopProgressBarAudio()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFailed")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ConsumeMaterialsUsedForRepair")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	private void RepairFinished()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterRepair")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	private void RepairFailed()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeUnlockResoluteOutfitterAchievement")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[Calls(Type = typeof(GearItem), Member = "GetMaxHPFromRepair")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetConditionIncreaseFromRepair")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterRepair")]
	private void RepairSuccessful()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CallerCount(Count = 0)]
	private void UpdateClothingSkillAfterRepair(GearItem gi)
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFailed")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateSkillAfterRepair(bool success)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	private void CleanFinished()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterClean")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	private void CleanSuccessful()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSkillAfterClean(bool success)
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	private void SharpenFinished()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSharpenConditionIncreaseAndDuration")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterSharpen")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CallsUnknownMethods(Count = 1)]
	private void SharpenSuccessful()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	private void UpdateSkillAfterSharpen(bool success)
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectToolByIndex")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnToolDecrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnToolIncrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void RefreshSelectedActionTool()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSelectedActionTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectCleanButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshCleanPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSharpenPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectSharpenButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[CallsUnknownMethods(Count = 37)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 23)]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void RefreshTools()
	{
	}

	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	private void RefreshMaterialsTable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool RepairHasRequiredTool()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairRequiresSewingKit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionToolSelect")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionToolSelect")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRepairPanel")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceSuccessfullRepair")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetCurrentSkillName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetConditionIncreaseFromRepair")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetConditionIncreaseFromRepair")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceActionSuccess")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void UpdateRepairLabels()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshCleanPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void UpdateCleanLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHarvest")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSharpenLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateCleanLabels")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	private void UpdateWeightAndConditionLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateCleanLabels")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectCleanTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	private void GetCleanConditionIncreaseAndDuration(out float conditionIncrease, out int durationMinutes)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref conditionIncrease) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref durationMinutes) = null;
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSharpenPanel")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSharpenConditionIncreaseAndDuration")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void UpdateSharpenLabels()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectSharpenTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSharpenLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	private void GetSharpenConditionIncreaseAndDuration(out float conditionIncrease, out int durationMinutes)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref conditionIncrease) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref durationMinutes) = null;
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMaterialsTable")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	private void RefreshRepairPanel()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateCleanLabels")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CanClean")]
	private void RefreshCleanPanel()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[CallsUnknownMethods(Count = 1)]
	private bool CleanHasRequiredTool()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSharpenLabels")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshSharpenPanel()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCapacityLiters")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringNoOunces")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void RefreshRefuelPanel()
	{
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Skill), Member = "GetProgressToNextLevelAsNormalizedValue")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Skill), Member = "GetProgressToNextLevelAsNormalizedValue")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_Description")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ResearchItem), Member = "GetSkillNameLocalized")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	private void RefreshReadPanel()
	{
	}

	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnReadHoursDecrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnReadHoursIncrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateReadPanelNavigation")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(ResearchItem), Member = "GetHoursResearchRemaining")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(ResearchItem), Member = "GetHoursResearchRemaining")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	private void RefreshHoursToRead()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool SharpenHasRequiredTool()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanRefuel()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine_MenuItem), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRefuel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefuelFinished")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnUnload")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CanClean")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateCleanLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSharpenPanel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHarvest")]
	public void RefreshMainWindow()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnSelectHarvestButton()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	public void OnSelectRepairButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	public void OnSelectRefuelButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	public void OnSelectCleanButton()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CallerCount(Count = 0)]
	public void OnSelectSharpenButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHarvest")]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void SelectCleanButton(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectUnloadButton(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallsUnknownMethods(Count = 3)]
	public void SelectSharpenButton(bool selected)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectHarvestButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRefuelButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectCleanButton")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectUnload")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectSharpenButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CheckSelectedButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainWindowNavigation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenFinished")]
	[CallerCount(Count = 18)]
	private void SelectButton(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenFinished")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHarvest")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void RefreshButton()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnEquip()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CanHarvest")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "StartHarvest")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnHarvest()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[CallerCount(Count = 1)]
	private bool RepairRequiresSewingKit()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CanRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	private bool RepairHasRequiredMaterial()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanRepair()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairTool")]
	public void OnRepair()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	public void OnProgressBarCancel()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceActionSuccess")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairTool")]
	private GameObject GetSelectedTool()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionToolSelect")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	public void OnSelectActionTool()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRepair")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "StartRepair")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetConditionIncreaseFromRepair")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSelectedTool")]
	[Calls(Type = typeof(GearItem), Member = "GetMaxHPFromRepair")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	public void OnSelectRepairTool()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairTool")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetInventoryAlpha")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceActionSuccess")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetRepairInProgress")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceSuccessfullRepair")]
	private void StartRepair(int durationMinutes, string repairAudio)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetConditionIncreaseFromRepair")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private int GetModifiedRepairDuration(Repairable r, int baseMinutes)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedCleanDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedRepairDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetSharpenConditionIncreaseAndDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSelectedTool")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSelectedTool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private int GetModifiedActionDuration(GearItem gi, float conditionIncrease, int baseMinutes)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RollForActionSuccess")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRepair")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSelectedTool")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private float GetChanceActionSuccess(float skillBaseChance)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceActionSuccess")]
	[CallsUnknownMethods(Count = 1)]
	private bool RollForActionSuccess(float baseSkillChance)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	public void OnRefuel()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void RefuelFinished(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	public void OnSelectUnload()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DoUnload")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	public void OnUnload()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnUnload")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallsDeduplicatedMethods(Count = 6)]
	public bool DoUnload()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnClean()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetInventoryAlpha")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 0)]
	public void OnSelectCleanTool()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetInventoryAlpha")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetCleanInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	private void StartClean(int durationMinutes, string cleanAudio)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectSharpenTool")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void OnSharpen()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateReadPanelNavigation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AchievementManager), Member = "ResearchedBook")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetInventoryAlpha")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "MaybeAbortReadingWithHUDMessage")]
	public void OnRead()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[Calls(Type = typeof(ResearchItem), Member = "Read")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	public void ReadComplete(float normalizedProgress)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ResearchItem), Member = "GetHoursResearchRemaining")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnReadHoursIncrease()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnReadHoursDecrease()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSharpen")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetInventoryAlpha")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GetSharpenConditionIncreaseAndDuration")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void OnSelectSharpenTool()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetInventoryAlpha")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetSharpenInProgress")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	private void StartSharpen(int durationMinutes, string sharpenAudio)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetInventoryAlpha")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetReadInProgress")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	private void StartRead(int durationMinutes, string readAudio)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainWindowNavigation")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnEquip")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateReadPanelNavigation")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectButton")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	public void OnBack()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "EnterInspectGearMode")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSelectedActionTool")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 30)]
	private void SelectWindow(GameObject window)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionToolSelect")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSelectedActionTool")]
	public void OnToolIncrease()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateMainAndToolHybrid")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionToolSelect")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSelectedActionTool")]
	public void OnToolDecrease()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSelectedActionTool")]
	[CallsUnknownMethods(Count = 1)]
	public void SelectToolByIndex(int index)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnHarvest")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetInventoryAlpha")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	public void StartHarvest()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnHarvest")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateLabels")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool CanHarvest()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectHarvestButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowPowder")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 3)]
	private void RefreshHarvest()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	private bool CheckForHarvestSuccess(Harvest harvest)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "MaybeReturnAmmoOrFuelToInventory")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "SetHarvestInProgress")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "AddPowderToInventory")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CheckForHarvestSuccess")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CheckForHarvestSuccess")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	private void HarvestSuccessful()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerManager), Member = "AddLiquidToInventory")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void MaybeReturnAmmoOrFuelToInventory(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(PlayerManager), Member = "RestoreTransformFromLastInspection")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	private void EnterInspectGearMode()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ExitInspectGearMode()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshCleanPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool CanClean(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "CanUserCancelAction")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Condition), Member = "HasNonRiskAffliction")]
	private bool MaybeAbortReadingWithHUDMessage()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	private float GetChanceSuccessfullRepair(GearItem gi)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierName")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	private string GetCurrentSkillName(GearItem gi)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetConditionIncreaseFromRepair")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceSuccessfullRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetCurrentSkillName")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private bool GearItemIsConsideredClothing(GearItem gi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedRepairDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateRepairLabels")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillClothingRepair")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private float GetConditionIncreaseFromRepair(GearItem gi)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectSharpenTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartSharpen")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectCleanTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartRepair")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "StartClean")]
	private void SetInventoryAlpha(float alpha)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 27)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsAcceleratingTime()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 16)]
	public UIWidget GetWidgetToFade()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Action GetCancelAction()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void StartAcceleratingTime()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void StopAcceleratingTime()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_Inventory_Examine()
	{
	}
}
