using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Cooking;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_Cooking : Panel_AutoReferenced
{
	public enum CookingFilter
	{
		All,
		FoodOnly,
		WaterOnly
	}

	private delegate void OnDelegate();

	public GameObject m_TitleCooking;

	public GameObject m_TitleWaterOnly;

	public CookSettings m_CookSettings;

	public float m_HoursRemainingFullFireSprite;

	public Color m_ScrollListSelectedColor;

	public Color m_ScrollListUnselectedColor;

	public ScrollList m_FoodScrollList;

	public UILabel m_Label_EstimatedFireDuration;

	public UILabel m_Label_FireTemperature;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public GameObject m_MouseButtonParent;

	public GameObject m_ActionButtonObject;

	public GameObject m_ActionSecondaryButtonObject;

	public GameObject m_ButtonIncreaseWater;

	public GameObject m_ButtonDecreaseWater;

	public GameObject m_ButtonIncreaseWaterBG;

	public GameObject m_ButtonDecreaseWaterBG;

	public UILabel m_WaterAmountLabel;

	public Transform m_WaterSelectTransform;

	public string m_MeltSnowIcon;

	public string m_BoilWaterIcon;

	public UITexture m_Texture_CookedItem;

	public UILabel m_Label_CookedItemName;

	public UILabel m_Label_CookedItemDesc;

	public UILabel m_Label_CookedItemCalories;

	public UILabel m_Label_CookedItemWeight;

	public UILabel m_Label_CookedItemCookTime;

	public GameObject m_SortLabel;

	public GameObject m_SortButtonsObject;

	public UIButton m_DefaultSortButton;

	public UIButton[] m_SortButtons;

	private PanelReference<Panel_CanOpening> m_CanOpening;

	private PanelReference<Panel_Confirmation> m_Confirmation;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	private UILabel m_Label_ButtonAction;

	private UILabel m_Label_ButtonSecondaryAction;

	private float m_BoilWaterLiters;

	private float m_MeltSnowLiters;

	private GameObject m_FireContainer;

	private Fire m_Fire;

	private CookingPotItem m_CookingPotInteractedWith;

	private CookingFilter m_CookingFilter;

	private int m_SelectedFoodIndexVal;

	private List<GearItem> m_FoodList;

	private List<CookingItemListEntry> m_CookingItemList;

	private FireManager m_FireManager;

	private List<OnDelegate> m_DoWaterDelegates;

	private List<OnDelegate> m_OnWaterUpDelegates;

	private List<OnDelegate> m_OnWaterDownDelegates;

	private List<string> m_WaterButtonStrings;

	private UIButton m_SelectedSortButton;

	private string m_SelectedSortOldSprite;

	private string m_SortName;

	private Dictionary<string, bool> m_SortFlipDictionary;

	private int m_SelectedSortIndex;

	private int m_SelectedFoodIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "MakeDefaultSelections")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "ScrollUp")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "ScrollDown")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "OnScrollItemSelect")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
		[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
		[Calls(Type = typeof(Transform), Member = "set_parent")]
		[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
		[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		set
		{
		}
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[Calls(Type = typeof(InputManager), Member = "GetInventorySortPressed")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateSortLabels")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[Calls(Type = typeof(InputManager), Member = "GetFeedFireTakeTorchePressed")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnDoActionSecondary")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Cooking), Member = "ScrollDown")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ScrollUp")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ScrollUp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ScrollDown")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFireDurationLabel")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshWater")]
	public void Refresh()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateSortLabels")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	public override void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public void SetCookingPot(CookingPotItem cookingPot)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetCookingFilter(CookingFilter filter)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetInventorySortPressed")]
	private void UpdateSortNavigation()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateSortLabels()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void RefreshFireDurationLabel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	public void OnScrollItemSelect(int itemIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGamepadControls")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnCook")]
	public void OnDoAction()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGamepadControls")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void OnDoActionSecondary()
	{
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQualityString")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public void OnCook()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	public void OnBoil()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampWaterBoilAmount")]
	public void OnBoilUp()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampWaterBoilAmount")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ReduceToNearestDeltaMultiple")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnBoilDown()
	{
	}

	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnMeltSnow()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampMeltSnowAmount")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnMeltSnowUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ReduceToNearestDeltaMultiple")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampMeltSnowAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnMeltSnowDown()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	private void OnDoWater()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnWaterDown()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	public void OnWaterUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void PlayButtonClick()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingPotWaterCallback")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingPotCookCallback")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SetFireContainer(GameObject go)
	{
	}

	[CalledBy(Type = typeof(Action_PassTime), Member = "OnExecute")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnow")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoil")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoActionSecondary")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Rest.PassTimeHelper), Member = "PassTime")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 9)]
	public void ExitCookingInterface()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void UpdateScrollLists()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	private void ScrollDown()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	private void ScrollUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnWaterUp")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnWaterDown")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	private bool SelectedFoodIsSnow()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnWaterUp")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnWaterDown")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	private bool SelectedFoodIsWater()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	private GearItem GetSelectedFood()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "ClampWaterBoilAmount")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoilDown")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoil")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoilUp")]
	private GameObject GetBoilableWaterSupply()
	{
		return null;
	}

	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(CookingItemListEntry), Member = "SetGearIconTexture")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(CookingItemListEntry), Member = "SetGearIconTexture")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(CookingItemListEntry), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "HaveEnoughUnitsToStartCooking")]
	[Calls(Type = typeof(CookingPotItem), Member = "CanCookItem")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	private void RefreshFoodList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 5)]
	private void RefreshFood()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampWaterBoilAmount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void RefreshWater()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampMeltSnowAmount")]
	private void RefreshSnow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	private void MakeDefaultSelections()
	{
	}

	[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateSortNavigation")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Initialize")]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIButtonColor), Member = "ResetDefaultColor")]
	public void OnSortChange(UIButton sortButtonClicked)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnowDown")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshSnow")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnowUp")]
	private void ClampMeltSnowAmount()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoilUp")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoilDown")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshWater")]
	[CallsUnknownMethods(Count = 1)]
	private void ClampWaterBoilAmount()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	private bool PlayerHasEnoughPotableWaterForCookingItem(Cookable cookable)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CallsUnknownMethods(Count = 1)]
	private bool HaveEnoughUnitsToStartCooking(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_Description")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetCookedHp")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cookable), Member = "GetCookTimeMinutesForCaloriesRemaining")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalCookMultiplier")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateGearItem()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "GetCookedHp")]
	[CallerCount(Count = 0)]
	private static float GetCookedItemConditionPercent(GearItem rawItem)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallsUnknownMethods(Count = 2)]
	private void EnableActionButton(bool enabled)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[Calls(Type = typeof(InputManager), Member = "GetFeedFireTakeTorchePressed")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnDoActionSecondary")]
	private void UpdateGamepadControls()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	public Panel_Cooking()
	{
	}
}
