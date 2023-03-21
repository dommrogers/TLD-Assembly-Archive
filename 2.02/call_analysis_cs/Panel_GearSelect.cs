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
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlayDuringStruggle")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "OnCancel")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "GetItems")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "GetItems")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	public void Enable(bool enable, ListItemFilter filter, bool isStruggleWeaponSelection)
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "SelectGear")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetPreviousPanelActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetupScrollList")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetBGWidgetsEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void Enable(bool enable, List<GearItem> listItems, bool isStruggleWeaponSelection, Action onGearSelected)
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectItemByIndex(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void PreviousGear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void NextGear()
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "UpdateGamepadSelection")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public void SelectGear()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GearItem GetSelectedItem()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "FireCookCallback")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingSlotCookCallback")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "FindFireEmptyPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetBGWidgetsEnabled")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 32)]
	public void ShowCookFoodPicker(GameObject fireObject, GameObject cookingObject)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "FireWaterCallback")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingSlotWaterCallback")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "FindFireEmptyPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SetBGWidgetsEnabled")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 24)]
	public void ShowCookWaterPicker(GameObject fireObject, GameObject cookingObject)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetSelectedGearPlacePoint(GearPlacePoint selectedGearPlacePoint)
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 19)]
	public static List<GearItem> GetItems(ListItemFilter filter)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private GearItem GetScrolllistCurrentItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "UpdateSelectedGear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSelectedGear(int selectedGearIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "UpdateSelectedGear")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateSelectedGear(GearItem selectedGear)
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Update")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "UpdateSelectedGear")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "RefreshGearItemIcons")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "UpdateButtonLegend")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void RefreshVisuals()
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "SelectGear")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateGamepadSelection()
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearSelectCoverflow), Member = "SetBareHands")]
	[Calls(Type = typeof(GearSelectCoverflow), Member = "SetEmptySlot")]
	[Calls(Type = typeof(GearSelectCoverflow), Member = "SetGearItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private void SetupScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void SetPreviousPanelActive(bool toggle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "FindFireEmptyPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearPlacePoint), Member = "DropAndPlaceItem")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetFireContainer")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void DoFirePickerAction()
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindFirstEmptyPlacePoint")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private GearPlacePoint FindFireEmptyPlacePoint()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private void SetBGWidgetsEnabled(bool shouldEnable)
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshGearItemIcons()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	public Panel_GearSelect()
	{
	}
}
