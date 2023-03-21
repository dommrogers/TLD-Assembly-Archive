using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_LeanToInteract : Panel_AutoReferenced, IAccelerateTimeProvider
{
	private delegate void OnMethod();

	private enum ButtonChoice
	{
		Use,
		Repair,
		Dismantle,
		Rotate
	}

	public ButtonLegendContainer m_ButtonLegendContainer;

	public float m_RealtimeSecondsToRepairOrDismantle;

	public UIButton m_Button_Use;

	public UIButton m_Button_Repair;

	public UIButton m_Button_Dismantle;

	public UIButton m_Button_Rotate;

	public float m_ButtonSpacing;

	public GameObject m_InteractionPanel;

	public UILabel m_InteractionDescriptionLabel;

	public UILabel m_InteractionMaterialsLabel;

	public GameObject m_BottomRightActionButton;

	public Color m_RepairLabelColorNormal;

	public Color m_RepairLabelColorNormalHover;

	public Color m_RepairLabelColorNormalSelected;

	public Color m_RepairLabelColorDisabled;

	public Color m_RepairLabelColorDisabledHover;

	public Color m_RepairLabelColorDisabledSelected;

	public UILabel m_ErrorLabel;

	public UILabel m_TimeForRepairHeaderLabel;

	public UILabel m_DurationLabel;

	public UILabel m_EstimatedCaloriesBurnedLabel;

	public UILabel m_CurrentCaloriesLabel;

	public UILabel m_CurrentCaloriesValLabel;

	public UILabel m_ConditionLabel;

	public UISprite m_ConditionSprite;

	public GameObject m_PanelElements;

	public HarvestRepairMaterial[] m_RequiredMaterialsObjects;

	public float m_RequiredMaterialsCenteredX;

	public float m_RequiredMaterialsSpacing;

	public GenericButtonMouseSpawner m_MouseButtonInteract;

	public string m_IconNameRepairingLeanTo;

	public string m_IconNameHarvestingLeanTo;

	public string m_IconNameRotatingLeanTo;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Inventory> m_Inventory;

	private LeanTo m_LeanTo;

	private List<UIButton> m_Buttons;

	private List<Panel_Inventory_Examine_MenuItem> m_ButtonsMenuItems;

	private List<OnMethod> m_ButtonDelegates;

	private int m_SelectedButtonIndex;

	private bool m_IsRepairing;

	private bool m_IsDismantling;

	private float m_RealtimeSecondsElapsed;

	private bool m_TimeIsAccelerated;

	private float m_StoredDayLengthScale;

	private int m_FramesInPanel;

	private uint m_InteractionAudioID;

	private int m_NumSticksUsedForRepair;

	private int m_NumBranchesUsedForRepair;

	private bool m_IsRotating;

	private bool m_HasRotated;

	private bool m_IsRotationValid;

	private Vector3 m_OriginalPosition;

	private Quaternion m_OriginalRotation;

	private Vector3 m_OriginalCampfirePosition;

	private Quaternion m_OriginalCampfireRotatation;

	private GenericButtonMouseSpawner m_BottomRightActionButtonSpawner;

	private MaterialPropertyBlock m_GreenTintMaterialPropertyBlock;

	private MaterialPropertyBlock m_RedTintMaterialPropertyBlock;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 53)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "UpdateCurrentCaloriesLabel")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "UpdateConditionLabel")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "OnInteract")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "UpdatePanelDisplays")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "UpdateMainWindowNavigation")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "InteractionFinished")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "HasMaterialsForRepair")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "MaybeUpdateRotationAction")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "GetTaskDurationInHours")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "NeedsRepair")]
	private void Update()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	public override void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public void SetLeanToInstance(LeanTo lt)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "ExitInterface")]
	[Calls(Type = typeof(LeanToManager), Member = "EnterLeanTo")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "OnInteractionCommon")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "GetButtonChoiceFromIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "GetButtonChoiceFromIndex")]
	public void OnUse()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "HasMaterialsForRepair")]
	[Calls(Type = typeof(LeanTo), Member = "GetNumSticksToRepair")]
	[Calls(Type = typeof(LeanTo), Member = "GetNumBranchesToRepair")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "OnInteractionCommon")]
	[CallsUnknownMethods(Count = 2)]
	public void OnRepair()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "OnInteractionCommon")]
	public void OnDismantle()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "OnInteractionCommon")]
	[CallerCount(Count = 0)]
	public void OnRotate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsTimeAccelerated()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsRepairing()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsDismantling()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsRotating()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "InteractionFinished")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnUse")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CleanUpPlaceMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void ExitInterface()
	{
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdateMainWindowNavigation")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Update")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "ExitInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnCancel()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Update")]
	public void OnInteract()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnRotate")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnDismantle")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnUse")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "GetTaskDurationInHours")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void OnInteractionCommon(string audioEvent)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "ExitInterface")]
	[Calls(Type = typeof(PlayerManager), Member = "CleanUpPlaceMesh")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(LeanTo), Member = "Destroy")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LeanTo), Member = "DismantleFinished")]
	private void InteractionFinished()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "GetTaskDurationInHours")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void UpdateDurationLabel()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "GetTaskDurationInHours")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "GetButtonChoiceFromIndex")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	private void UpdateEstimatedCaloriesBurnedLabel()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Update")]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateCurrentCaloriesLabel()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Update")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateConditionLabel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string GetSignedInt(int value)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	private string GetSignedPercentage(float value)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "GetButtonChoiceFromIndex")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "HasMaterialsForRepair")]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "ExitInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_Inventory_Examine_MenuItem), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "UpdatePanelDisplays")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "SelectButton")]
	public void RefreshMainWindow()
	{
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnSelectRotateButton")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnSelectDismantleButton")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdateMainWindowNavigation")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnSelectRepairButton")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshMainWindow")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnSelectUseButton")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "CameraPan")]
	private void SelectButton(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "SelectButton")]
	public void OnSelectUseButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "SelectButton")]
	public void OnSelectRepairButton()
	{
	}

	[Calls(Type = typeof(Panel_LeanToInteract), Member = "SelectButton")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	public void OnSelectDismantleButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "SelectButton")]
	public void OnSelectRotateButton()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "SelectButton")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 1)]
	private void UpdateMainWindowNavigation()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void UpdateUseButton()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdateDismantleButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateRotateButton()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "HasMaterialsForRepair")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void UpdateRepairButton()
	{
	}

	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Update")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshMainWindow")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "RefreshDismantlePanel")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "GetButtonChoiceFromIndex")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "NeedsRepair")]
	private void UpdatePanelDisplays()
	{
	}

	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "UpdateRequiredMaterialsObject")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "UpdateRequiredMaterialsObject")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "HasMaterialsForRepair")]
	[Calls(Type = typeof(LeanTo), Member = "GetNumBranchesToRepair")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(LeanToManager), Member = "GetNumBranchesInInventory")]
	[Calls(Type = typeof(LeanToManager), Member = "GetNumSticksInInventory")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdatePanelDisplays")]
	[Calls(Type = typeof(LeanTo), Member = "GetNumSticksToRepair")]
	[CallsUnknownMethods(Count = 5)]
	private void RefreshRepairPanel()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshDismantlePanel")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshDismantlePanel")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	private void UpdateRequiredMaterialsObject(int index, float spacingVal, GearItem gi, int count, bool hasItem)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdatePanelDisplays")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "UpdateRequiredMaterialsObject")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "UpdateRequiredMaterialsObject")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshDismantlePanel()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "InputControlRotate")]
	public void RotatePlaceMesh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "MaybeInitializePropertyBlocks")]
	private MaterialPropertyBlock GetPropertyBlockForMeshLocationCategory(bool isValid)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "MaybeUpdateRotationAction")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "MaybeInitializePropertyBlocks")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "MaybeInitializePropertyBlocks")]
	[CallsUnknownMethods(Count = 4)]
	private void TintObject(GameObject go, bool isValid)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void RestoreOriginalTint(GameObject go)
	{
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "TintObject")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "GetPropertyBlockForMeshLocationCategory")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "MaybeUpdateRotationAction")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "TintObject")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor")]
	private void MaybeInitializePropertyBlocks()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Update")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 27)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "GetButtonChoiceFromIndex")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "InputControlRotate")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "MaybeInitializePropertyBlocks")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPlacementPositionValid")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "TintObject")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	private void MaybeUpdateRotationAction()
	{
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdateDurationLabel")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnInteractionCommon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "GetButtonChoiceFromIndex")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Update")]
	private float GetTaskDurationInHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "GetButtonChoiceFromIndex")]
	[CallsUnknownMethods(Count = 4)]
	private float GetCalorieBurnRate()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "GetTaskDurationInHours")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "MaybeUpdateRotationAction")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdatePanelDisplays")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "GetCalorieBurnRate")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnUse")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnUse")]
	private ButtonChoice GetButtonChoiceFromIndex(int index)
	{
		return default(ButtonChoice);
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "SelectButton")]
	[Calls(Type = typeof(PanViewCamera), Member = "PanToTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void CameraPan(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "HasMaterialsForRepair")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdatePanelDisplays")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdateRepairButton")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Update")]
	[Calls(Type = typeof(LeanTo), Member = "GetNumBranchesToRepair")]
	[Calls(Type = typeof(LeanTo), Member = "GetNumSticksToRepair")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnRepair")]
	private bool NeedsRepair()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdateRepairButton")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Update")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnRepair")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(LeanTo), Member = "GetNumBranchesToRepair")]
	[Calls(Type = typeof(LeanTo), Member = "GetNumSticksToRepair")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "NeedsRepair")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private bool HasMaterialsForRepair()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsAcceleratingTime()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void StopAcceleratingTime()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 21)]
	public Panel_LeanToInteract()
	{
	}
}
