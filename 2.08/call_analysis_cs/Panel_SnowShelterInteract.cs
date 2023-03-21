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
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 32)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "OnInteract")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "OnCancel")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateConditionLabel")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateCurrentCaloriesLabel")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateMainWindowNavigation")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetTaskDurationInHours")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	private void Update()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public void SetSnowShelterInstance(SnowShelter ss)
	{
	}

	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowShelterManager), Member = "EnterShelter")]
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

	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "OnInteractionCommon")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void OnDismantle()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsTimeAccelerated()
	{
		return default(bool);
	}

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

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshMainWindow")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnUse")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	private void ExitInterface()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateMainWindowNavigation")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "ExitInterface")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnCancel()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	public void OnInteract()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnDismantle")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnRepair")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetTaskDurationInHours")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	public void OnInteractionCommon(string audioEvent)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "ExitInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(SnowShelter), Member = "Destroy")]
	[Calls(Type = typeof(SnowShelter), Member = "DismantleFinished")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	private void InteractionFinished()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetTaskDurationInHours")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void UpdateDurationLabel()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetButtonChoiceFromIndex")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetTaskDurationInHours")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	private void UpdateEstimatedCaloriesBurnedLabel()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private void UpdateCurrentCaloriesLabel()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateConditionLabel()
	{
	}

	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	private string GetSignedInt(int value)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 4)]
	private string GetSignedPercentage(float value)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetButtonChoiceFromIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "ExitInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "SelectButton")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[Calls(Type = typeof(Panel_Inventory_Examine_MenuItem), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	public void RefreshMainWindow()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateMainWindowNavigation")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnSelectDismantleButton")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnSelectRepairButton")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnSelectUseButton")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "CameraPan")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshMainWindow")]
	private void SelectButton(int index)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "SelectButton")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "SelectButton")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	private void UpdateMainWindowNavigation()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void UpdateUseButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateDismantleButton()
	{
	}

	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdateRepairButton()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshDismantlePanel")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetButtonChoiceFromIndex")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	private void UpdatePanelDisplays()
	{
	}

	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRequiredMaterialsObject")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRequiredMaterialsObject")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumSticksToRepair")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumClothToRepair")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetNumSticksInInventory")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetNumClothInInventory")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshRepairPanel()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshDismantlePanel")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshDismantlePanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	private void UpdateRequiredMaterialsObject(int index, float spacingVal, GearItem gi, int count, bool hasItem)
	{
	}

	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRequiredMaterialsObject")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRequiredMaterialsObject")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshDismantlePanel()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateDurationLabel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnInteractionCommon")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetButtonChoiceFromIndex")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	private float GetTaskDurationInHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetButtonChoiceFromIndex")]
	[CallsUnknownMethods(Count = 3)]
	private float GetCalorieBurnRate()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "GetTaskDurationInHours")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "GetCalorieBurnRate")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private ButtonChoice GetButtonChoiceFromIndex(int index)
	{
		return default(ButtonChoice);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(PanViewCamera), Member = "PanToTransform")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "SelectButton")]
	[CallsUnknownMethods(Count = 16)]
	private void CameraPan(int index)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRepairButton")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnRepair")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumClothToRepair")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumSticksToRepair")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateButtonLegend")]
	private bool NeedsRepair()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRepairButton")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumClothToRepair")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumSticksToRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private bool HasMaterialsForRepair()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsAcceleratingTime()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
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

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
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
