using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_GearSelect : Panel_AutoReferenced
{
	public enum ListItemFilter
	{
		None,
		InventoryAll,
		InventoryBodyHarvestTool,
		InventoryStruggleWeapon
	}

	private PanelReference<Panel_Cooking> m_Cooking;

	private PanelReference<Panel_Log> m_Log;

	public ScrollList m_ScrollList;

	public GameObject m_ButtonLeft;

	public GameObject m_ButtonRight;

	public GameObject m_ButtonLeftGamepad;

	public UISprite m_ButtonLeftGamepadSprite;

	public GameObject m_ButtonRightGamepad;

	public UISprite m_ButtonRightGamepadSprite;

	public GenericButtonMouseSpawner m_MouseButtonSelectGear;

	public UILabel m_Label;

	public GameObject m_ItemStatsObject;

	public UILabel m_ConditionLabel;

	public UILabel m_WeightLabel;

	public UIWidget[] m_WidgetsToDisableForNoBG;

	public Transform m_PanelContentTransform;

	public Vector3 m_PanelContentPosNormal;

	public Vector3 m_PanelContentPosNoBG;

	private ButtonLegendContainer m_ButtonLegendContainer;

	private List<GearSelectCoverflow> m_CoverflowGearItems;

	private List<GearItem> m_GearItems;

	private GearItem m_SelectedItem;

	private bool m_IsStruggleWeaponSelection;

	private Action m_OnSelectAction;

	private GameObject m_FeedFireGameObject;

	private GearPlacePoint m_GearPlacePointSelected;

	private GameObject m_CookingGameObject;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlayDuringStruggle")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "GetItems")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "GetItems")]
	[CallerCount(Count = 0)]
	public void Enable(bool enable, ListItemFilter filter, bool isStruggleWeaponSelection)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "SelectGear")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetBGWidgetsEnabled")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetPreviousPanelActive")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetupScrollList")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetPreviousPanelActive")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	public void Enable(bool enable, List<GearItem> listItems, bool isStruggleWeaponSelection, Action onGearSelected)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Update")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsUnknownMethods(Count = 1)]
	public void SelectItemByIndex(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsUnknownMethods(Count = 2)]
	public void PreviousGear()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void NextGear()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "UpdateGamepadSelection")]
	public void SelectGear()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GearItem GetSelectedItem()
	{
		return null;
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(HUDMessage), Member = "CreateMessageInfo")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingSlotCookCallback")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "FireCookCallback")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetBGWidgetsEnabled")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "FindFireEmptyPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HUDMessage), Member = "CreateMessageInfo")]
	public void ShowCookFoodPicker(GameObject fireObject, GameObject cookingObject)
	{
	}

	[Calls(Type = typeof(HUDMessage), Member = "CreateMessageInfo")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingSlotWaterCallback")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "FireWaterCallback")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetBGWidgetsEnabled")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "FindFireEmptyPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void ShowCookWaterPicker(GameObject fireObject, GameObject cookingObject)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void SetSelectedGearPlacePoint(GearPlacePoint selectedGearPlacePoint)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CallsUnknownMethods(Count = 8)]
	public static List<GearItem> GetItems(ListItemFilter filter)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private GearItem GetScrolllistCurrentItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "UpdateSelectedGear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSelectedGear(int selectedGearIndex)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "UpdateSelectedGear")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	private void UpdateSelectedGear(GearItem selectedGear)
	{
	}

	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "RefreshGearItemIcons")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "UpdateSelectedGear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void RefreshVisuals()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Update")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SelectGear")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	private void UpdateGamepadSelection()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GearSelectCoverflow), Member = "SetBareHands")]
	[Calls(Type = typeof(GearSelectCoverflow), Member = "SetEmptySlot")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearSelectCoverflow), Member = "SetGearItem")]
	private void SetupScrollList()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	private void SetPreviousPanelActive(bool toggle)
	{
	}

	[Calls(Type = typeof(GearPlacePoint), Member = "DropAndPlaceItem")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearPlacePoint), Member = "DropAndPlaceItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetFireContainer")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "FindFireEmptyPlacePoint")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DoFirePickerAction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindFirstEmptyPlacePoint")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private GearPlacePoint FindFireEmptyPlacePoint()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	private void SetBGWidgetsEnabled(bool shouldEnable)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[CallsUnknownMethods(Count = 5)]
	private void RefreshGearItemIcons()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_GearSelect()
	{
	}
}
