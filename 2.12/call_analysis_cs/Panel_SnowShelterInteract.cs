using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_SnowShelterInteract : Panel_AutoReferenced, IAccelerateTimeProvider
{
	private delegate void OnMethod();

	private enum ButtonChoice
	{
		Use,
		Repair,
		Dismantle
	}

	public ButtonLegendContainer m_ButtonLegendContainer;

	public float m_RealtimeSecondsToRepairOrDismantle;

	public UIButton m_Button_Use;

	public UIButton m_Button_Repair;

	public UIButton m_Button_Dismantle;

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

	public string m_IconNameRepairingSnowShelter;

	public string m_IconNameHarvestingSnowShelter;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Inventory> m_Inventory;

	private SnowShelter m_SnowShelter;

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

	private int m_NumClothUsedForRepair;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 32)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateMainWindowNavigation")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetTaskDurationInHours")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateCurrentCaloriesLabel")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateConditionLabel")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "OnInteract")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "ExitInterface")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public override void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public void SetSnowShelterInstance(SnowShelter ss)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowShelterManager), Member = "EnterShelter")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 2)]
	public void OnUse()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumSticksToRepair")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumClothToRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "OnInteractionCommon")]
	[CallsUnknownMethods(Count = 2)]
	public void OnRepair()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "OnInteractionCommon")]
	[CallsUnknownMethods(Count = 2)]
	public void OnDismantle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsTimeAccelerated()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsRepairing()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsDismantling()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnUse")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshMainWindow")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ExitInterface()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateMainWindowNavigation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "ExitInterface")]
	public void OnCancel()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CallerCount(Count = 1)]
	public void OnInteract()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnDismantle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetTaskDurationInHours")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void OnInteractionCommon(string audioEvent)
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(SnowShelter), Member = "DismantleFinished")]
	[Calls(Type = typeof(SnowShelter), Member = "Destroy")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 3)]
	private void InteractionFinished()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetTaskDurationInHours")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateDurationLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetButtonChoiceFromIndex")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetTaskDurationInHours")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateEstimatedCaloriesBurnedLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateCurrentCaloriesLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateConditionLabel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string GetSignedInt(int value)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 4)]
	private string GetSignedPercentage(float value)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetButtonChoiceFromIndex")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "SelectButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine_MenuItem), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "ExitInterface")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	public void RefreshMainWindow()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnSelectUseButton")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnSelectRepairButton")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnSelectDismantleButton")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateMainWindowNavigation")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "CameraPan")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void SelectButton(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "SelectButton")]
	public void OnSelectUseButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "SelectButton")]
	public void OnSelectRepairButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "SelectButton")]
	public void OnSelectDismantleButton()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "SelectButton")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "OnCancel")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateMainWindowNavigation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateUseButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateDismantleButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateRepairButton()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshMainWindow")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetButtonChoiceFromIndex")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshDismantlePanel")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdatePanelDisplays()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetNumSticksInInventory")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetNumClothInInventory")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumSticksToRepair")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumClothToRepair")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRequiredMaterialsObject")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void RefreshRepairPanel()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshDismantlePanel")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateRequiredMaterialsObject(int index, float spacingVal, GearItem gi, int count, bool hasItem)
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRequiredMaterialsObject")]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshDismantlePanel()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnInteractionCommon")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateDurationLabel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetButtonChoiceFromIndex")]
	[CallsUnknownMethods(Count = 1)]
	private float GetTaskDurationInHours()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetButtonChoiceFromIndex")]
	[CallsUnknownMethods(Count = 3)]
	private float GetCalorieBurnRate()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "GetTaskDurationInHours")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "GetCalorieBurnRate")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private ButtonChoice GetButtonChoiceFromIndex(int index)
	{
		return default(ButtonChoice);
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "SelectButton")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(PanViewCamera), Member = "PanToTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	private void CameraPan(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRepairButton")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumSticksToRepair")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumClothToRepair")]
	[CallsUnknownMethods(Count = 1)]
	private bool NeedsRepair()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRepairButton")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumSticksToRepair")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumClothToRepair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[CallsUnknownMethods(Count = 3)]
	private bool HasMaterialsForRepair()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsAcceleratingTime()
	{
		return false;
	}

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
	[CallerCount(Count = 0)]
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
	[CallsUnknownMethods(Count = 1)]
	public Panel_SnowShelterInteract()
	{
	}
}
