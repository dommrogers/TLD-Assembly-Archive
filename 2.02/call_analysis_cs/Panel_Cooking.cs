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
			return 0;
		}
		[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "OnScrollItemSelect")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "ScrollDown")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "ScrollUp")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "MakeDefaultSelections")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
		[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
		[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
		[Calls(Type = typeof(Transform), Member = "set_parent")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 17)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateScrollLists")]
	[Calls(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateSortNavigation")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateSortLabels")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[Calls(Type = typeof(InputManager), Member = "GetFeedFireTakeTorchePressed")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnDoActionSecondary")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 9)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFood")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshWater")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFireDurationLabel")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	public void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateSortLabels")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFood")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshWater")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFireDurationLabel")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 15)]
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

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetInventorySortPressed")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateSortNavigation()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 14)]
	private void UpdateSortLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void RefreshFireDurationLabel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnScrollItemSelect(int itemIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGamepadControls")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void OnDoAction()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGamepadControls")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void OnDoActionSecondary()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQualityString")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 30)]
	public void OnCook()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void OnBoil()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampWaterBoilAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void OnBoilUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ReduceToNearestDeltaMultiple")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampWaterBoilAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnBoilDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void OnMeltSnow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampMeltSnowAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void OnMeltSnowUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ReduceToNearestDeltaMultiple")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampMeltSnowAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnMeltSnowDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDoWater()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void OnWaterDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void OnWaterUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void PlayButtonClick()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingPotCookCallback")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingPotWaterCallback")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SetFireContainer(GameObject go)
	{
	}

	[CalledBy(Type = typeof(Rest.PassTimeHelper), Member = "PassTime")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoActionSecondary")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoil")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnow")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[CalledBy(Type = typeof(Action_PassTime), Member = "OnExecute")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void ExitCookingInterface()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CallerCount(Count = 1)]
	private void UpdateScrollLists()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ScrollDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ScrollUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnWaterDown")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnWaterUp")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool SelectedFoodIsSnow()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnWaterDown")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnWaterUp")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool SelectedFoodIsWater()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 13)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private GearItem GetSelectedFood()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoil")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoilUp")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoilDown")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "ClampWaterBoilAmount")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private GameObject GetBoilableWaterSupply()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "HaveEnoughUnitsToStartCooking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "CanCookItem")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(CookingItemListEntry), Member = "SetGearIconTexture")]
	[Calls(Type = typeof(CookingItemListEntry), Member = "SetGearItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentNullException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 130)]
	private void RefreshFoodList()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private void RefreshFood()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampWaterBoilAmount")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	private void RefreshWater()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClampMeltSnowAmount")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 14)]
	private void RefreshSnow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	private void MakeDefaultSelections()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateSortNavigation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
	[Calls(Type = typeof(UIButtonColor), Member = "ResetDefaultColor")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[Calls(Type = typeof(Panel_Cooking), Member = "set_m_SelectedFoodIndex")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 14)]
	public void OnSortChange(UIButton sortButtonClicked)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnowUp")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnowDown")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshSnow")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ClampMeltSnowAmount()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoilUp")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoilDown")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshWater")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ClampWaterBoilAmount()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private bool PlayerHasEnoughPotableWaterForCookingItem(Cookable cookable)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private bool HaveEnoughUnitsToStartCooking(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Cookable), Member = "GetCookTimeMinutesForCaloriesRemaining")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalCookMultiplier")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightIgnoreClothingWornBonusKG")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 35)]
	private void UpdateGearItem()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	private void EnableActionButton(bool enabled)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Cooking), Member = "EnableActionButton")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[Calls(Type = typeof(InputManager), Member = "GetFeedFireTakeTorchePressed")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnDoActionSecondary")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateGamepadControls()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 49)]
	public Panel_Cooking()
	{
	}
}
