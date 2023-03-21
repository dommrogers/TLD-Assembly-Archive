using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_SnowShelterInteract : Panel_Base
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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 72)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateCurrentCaloriesLabel")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateConditionLabel")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "OnInteract")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateMainWindowNavigation")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetTaskDurationInHours")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void Update()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetSnowShelterInstance(SnowShelter ss)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(SnowShelterManager), Member = "EnterShelter")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 2)]
	public void OnUse()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "OnInteractionCommon")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumClothToRepair")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumSticksToRepair")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	public void OnRepair()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "OnInteractionCommon")]
	[CallsUnknownMethods(Count = 3)]
	public void OnDismantle()
	{
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool IsTimeAccelerated()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool IsRepairing()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	public bool IsDismantling()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnUse")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	[CallsUnknownMethods(Count = 2)]
	private void ExitInterface()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateMainWindowNavigation")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "ExitInterface")]
	public void OnCancel()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	public void OnInteract()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnRepair")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnDismantle")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetTaskDurationInHours")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void OnInteractionCommon(string audioEvent)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(SnowShelter), Member = "Destroy")]
	[Calls(Type = typeof(SnowShelter), Member = "DismantleFinished")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "ExitInterface")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void InteractionFinished()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetTaskDurationInHours")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void UpdateDurationLabel()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetTaskDurationInHours")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetButtonChoiceFromIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void UpdateEstimatedCaloriesBurnedLabel()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	private void UpdateCurrentCaloriesLabel()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void UpdateConditionLabel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string GetSignedInt(int value)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	private string GetSignedPercentage(float value)
	{
		return null;
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetButtonChoiceFromIndex")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void UpdateButtonLegend()
	{
	}

	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "OnCancel")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "SelectButton")]
	[Calls(Type = typeof(Panel_Inventory_Examine_MenuItem), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public void RefreshMainWindow()
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnSelectUseButton")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateMainWindowNavigation")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnSelectDismantleButton")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnSelectRepairButton")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "CameraPan")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshMainWindow")]
	private void SelectButton(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "SelectButton")]
	public void OnSelectUseButton()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "SelectButton")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnSelectRepairButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "SelectButton")]
	public void OnSelectDismantleButton()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "SelectButton")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	private void UpdateMainWindowNavigation()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateUseButton()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateDismantleButton()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void UpdateRepairButton()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshDismantlePanel")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetButtonChoiceFromIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdatePanelDisplays()
	{
	}

	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRequiredMaterialsObject")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRequiredMaterialsObject")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumSticksToRepair")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumClothToRepair")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetNumClothInInventory")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetNumSticksInInventory")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void RefreshRepairPanel()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshDismantlePanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshDismantlePanel")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	private void UpdateRequiredMaterialsObject(int index, float spacingVal, GearItem gi, int count, bool hasItem)
	{
	}

	[Calls(Type = typeof(SnowShelter), Member = "GetNormalizedCondition")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRequiredMaterialsObject")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRequiredMaterialsObject")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshDismantlePanel()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnInteractionCommon")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateDurationLabel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetButtonChoiceFromIndex")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNormalizedCondition")]
	private float GetTaskDurationInHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "GetButtonChoiceFromIndex")]
	[CallsUnknownMethods(Count = 4)]
	private float GetCalorieBurnRate()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "GetCalorieBurnRate")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "GetTaskDurationInHours")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private ButtonChoice GetButtonChoiceFromIndex(int index)
	{
		return default(ButtonChoice);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PanViewCamera), Member = "PanToTransform")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "SelectButton")]
	[CallsUnknownMethods(Count = 20)]
	private void CameraPan(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnRepair")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRepairButton")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumClothToRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumSticksToRepair")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateButtonLegend")]
	private bool NeedsRepair()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateRepairButton")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumSticksToRepair")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(Inventory), Member = "NumGearInInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "NumGearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNumClothToRepair")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private bool HasMaterialsForRepair()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public Panel_SnowShelterInteract()
	{
	}
}
