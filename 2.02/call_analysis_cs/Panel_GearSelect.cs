using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_GearSelect : Panel_Base
{
	public enum ListItemFilter
	{
		None,
		InventoryAll,
		InventoryBodyHarvestTool,
		InventoryStruggleWeapon
	}

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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
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

	[Calls(Type = typeof(Panel_GearSelect), Member = "GetItems")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CallerCount(Count = 0)]
	public void Enable(bool enable, ListItemFilter filter, bool isStruggleWeaponSelection)
	{
	}

	[Calls(Type = typeof(Panel_GearSelect), Member = "SetBGWidgetsEnabled")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "SelectGear")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetPreviousPanelActive")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetupScrollList")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetPreviousPanelActive")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	public void Enable(bool enable, List<GearItem> listItems, bool isStruggleWeaponSelection, Action onGearSelected)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Update")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	public void OnCancel()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void SelectItemByIndex(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsUnknownMethods(Count = 3)]
	public void PreviousGear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsUnknownMethods(Count = 3)]
	public void NextGear()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void SelectGear()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GearItem GetSelectedItem()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 32)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingSlotCookCallback")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "FireCookCallback")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetBGWidgetsEnabled")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "FindFireEmptyPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	public void ShowCookFoodPicker(GameObject fireObject, GameObject cookingObject)
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingSlotWaterCallback")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "FireWaterCallback")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetBGWidgetsEnabled")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "FindFireEmptyPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	public void ShowCookWaterPicker(GameObject fireObject, GameObject cookingObject)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetSelectedGearPlacePoint(GearPlacePoint selectedGearPlacePoint)
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public static List<GearItem> GetItems(ListItemFilter filter)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	private GearItem GetScrolllistCurrentItem()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "UpdateSelectedGear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateSelectedGear(int selectedGearIndex)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "UpdateSelectedGear")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateSelectedGear(GearItem selectedGear)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "RefreshGearItemIcons")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "UpdateSelectedGear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void RefreshVisuals()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Update")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SelectGear")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	private void UpdateGamepadSelection()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearSelectCoverflow), Member = "SetGearItem")]
	[Calls(Type = typeof(GearSelectCoverflow), Member = "SetEmptySlot")]
	[Calls(Type = typeof(GearSelectCoverflow), Member = "SetBareHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void SetupScrollList()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CallsUnknownMethods(Count = 4)]
	private void SetPreviousPanelActive(bool toggle)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetFireContainer")]
	[Calls(Type = typeof(GearPlacePoint), Member = "DropAndPlaceItem")]
	[Calls(Type = typeof(GearPlacePoint), Member = "DropAndPlaceItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "FindFireEmptyPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DoFirePickerAction()
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindFirstEmptyPlacePoint")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private GearPlacePoint FindFireEmptyPlacePoint()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	private void SetBGWidgetsEnabled(bool shouldEnable)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshGearItemIcons()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 21)]
	public Panel_GearSelect()
	{
	}
}
