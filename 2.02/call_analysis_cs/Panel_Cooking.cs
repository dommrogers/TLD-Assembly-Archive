using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class Panel_Cooking : Panel_Base
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

	public float m_MinutesToBoilWaterPerLiter;

	public float m_MinutesToMeltSnowPerLiter;

	public float m_MinutesToPurifyPerLiter;

	public float m_MinutesReadyTimeBoilingWater;

	public float m_MinutesGraceTimeInterruptedCooking;

	public string m_MeltAndBoilAudio;

	public string m_PutSnowInPotAudio;

	public string m_PutWaterInPotAudio;

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

	public Color m_CookingHoverTextColor;

	public Color m_ReadyHoverTextColor;

	public Color m_RuinedHoverTextColor;

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
		[CallsUnknownMethods(Count = 17)]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "ScrollUp")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "ScrollDown")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "OnScrollItemSelect")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "MakeDefaultSelections")]
		[Calls(Type = typeof(Transform), Member = "set_parent")]
		[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
		[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
		[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		set
		{
		}
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateSortNavigation")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnDoActionSecondary")]
	[Calls(Type = typeof(InputManager), Member = "GetFeedFireTakeTorchePressed")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateSortLabels")]
	[Calls(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateScrollLists")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFireDurationLabel")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshSnow")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFood")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshWater")]
	public void Refresh()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFireDurationLabel")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshWater")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFood")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateSortLabels")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	public override void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void SetCookingPot(CookingPotItem cookingPot)
	{
	}

	[CallerCount(Count = 0)]
	public void SetCookingFilter(CookingFilter filter)
	{
	}

	[Calls(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "GetInventorySortPressed")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void UpdateSortNavigation()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CallsUnknownMethods(Count = 14)]
	private void UpdateSortLabels()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshFireDurationLabel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	public void OnScrollItemSelect(int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGamepadControls")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	public void OnDoAction()
	{
	}

	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGamepadControls")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void OnDoActionSecondary()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQualityString")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(CookingPotItem), Member = "StartCooking")]
	public void OnCook()
	{
	}

	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void OnBoil()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampWaterBoilAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 0)]
	public void OnBoilUp()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampWaterBoilAmount")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ReduceToNearestDeltaMultiple")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallerCount(Count = 0)]
	public void OnBoilDown()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	public void OnMeltSnow()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampMeltSnowAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	public void OnMeltSnowUp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ReduceToNearestDeltaMultiple")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampMeltSnowAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void OnMeltSnowDown()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	private void OnDoWater()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnWaterDown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnWaterUp()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void PlayButtonClick()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingPotCookCallback")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingPotWaterCallback")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[CallsUnknownMethods(Count = 1)]
	public void SetFireContainer(GameObject go)
	{
	}

	[CalledBy(Type = typeof(Action_PassTime), Member = "OnExecute")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnow")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoil")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Rest.PassTimeHelper), Member = "PassTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoActionSecondary")]
	public void ExitCookingInterface()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	private void UpdateScrollLists()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ScrollDown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	private void ScrollUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnWaterUp")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnWaterDown")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	private bool SelectedFoodIsSnow()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnWaterUp")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnWaterDown")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	private bool SelectedFoodIsWater()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	private GearItem GetSelectedFood()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "ClampWaterBoilAmount")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoilUp")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoilDown")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoil")]
	private GameObject GetBoilableWaterSupply()
	{
		return null;
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(CookingItemListEntry), Member = "SetGearIconTexture")]
	[Calls(Type = typeof(CookingItemListEntry), Member = "SetGearIconTexture")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 130)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(CookingItemListEntry), Member = "SetGearItem")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 29)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Cooking), Member = "HaveEnoughUnitsToStartCooking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "CanCookItem")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void RefreshFoodList()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void RefreshFood()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampWaterBoilAmount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void RefreshWater()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampMeltSnowAmount")]
	private void RefreshSnow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	private void MakeDefaultSelections()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateSortNavigation")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Initialize")]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
	[Calls(Type = typeof(UIButtonColor), Member = "ResetDefaultColor")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 3)]
	public void OnSortChange(UIButton sortButtonClicked)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshSnow")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnowDown")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnowUp")]
	private void ClampMeltSnowAmount()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoilUp")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoilDown")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ClampWaterBoilAmount()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	private bool PlayerHasEnoughPotableWaterForCookingItem(Cookable cookable)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool HaveEnoughUnitsToStartCooking(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalCookMultiplier")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightIgnoreClothingWornBonusKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(Cookable), Member = "GetCookTimeMinutesForCaloriesRemaining")]
	private void UpdateGearItem()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	private void EnableActionButton(bool enabled)
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Cooking), Member = "EnableActionButton")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(Panel_Cooking), Member = "OnDoActionSecondary")]
	[Calls(Type = typeof(InputManager), Member = "GetFeedFireTakeTorchePressed")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	private void UpdateGamepadControls()
	{
	}

	[CallsUnknownMethods(Count = 49)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Panel_Cooking()
	{
	}
}
