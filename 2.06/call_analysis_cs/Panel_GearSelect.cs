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

	[Calls(Type = typeof(Panel_GearSelect), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
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

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "SelectGear")]
	[CallsUnknownMethods(Count = 3)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
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

	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void NextGear()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "UpdateGamepadSelection")]
	[CallsUnknownMethods(Count = 6)]
	public void SelectGear()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GearItem GetSelectedItem()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingSlotCookCallback")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "FireCookCallback")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "CreateMessageInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "CreateMessageInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetBGWidgetsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "FindFireEmptyPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ShowCookFoodPicker(GameObject fireObject, GameObject cookingObject)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingSlotWaterCallback")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "FireWaterCallback")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "FindFireEmptyPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetBGWidgetsEnabled")]
	public void ShowCookWaterPicker(GameObject fireObject, GameObject cookingObject)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetSelectedGearPlacePoint(GearPlacePoint selectedGearPlacePoint)
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static List<GearItem> GetItems(ListItemFilter filter)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private GearItem GetScrolllistCurrentItem()
	{
		return null;
	}

	[Calls(Type = typeof(Panel_GearSelect), Member = "UpdateSelectedGear")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSelectedGear(int selectedGearIndex)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "UpdateSelectedGear")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateSelectedGear(GearItem selectedGear)
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "RefreshGearItemIcons")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "UpdateSelectedGear")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void RefreshVisuals()
	{
	}

	[Calls(Type = typeof(Panel_GearSelect), Member = "SelectGear")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Update")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void UpdateGamepadSelection()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(GearSelectCoverflow), Member = "SetGearItem")]
	[Calls(Type = typeof(GearSelectCoverflow), Member = "SetEmptySlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearSelectCoverflow), Member = "SetBareHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void SetupScrollList()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void SetPreviousPanelActive(bool toggle)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetFireContainer")]
	[Calls(Type = typeof(GearPlacePoint), Member = "DropAndPlaceItem")]
	[Calls(Type = typeof(GearPlacePoint), Member = "DropAndPlaceItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "FindFireEmptyPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void DoFirePickerAction()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindFirstEmptyPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private GearPlacePoint FindFireEmptyPlacePoint()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	private void SetBGWidgetsEnabled(bool shouldEnable)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshGearItemIcons()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public Panel_GearSelect()
	{
	}
}
