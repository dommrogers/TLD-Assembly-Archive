using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Cooking;
using TLD.SaveState;
using TLD.UI;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class Panel_CookWater : Panel_AutoReferenced
{
	private delegate void OnDelegate();

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

	private AssetReferenceTexture2D m_MeltSnowIcon;

	private AssetReferenceTexture2D m_BoilWaterIcon;

	public UITexture m_Texture_CookedItem;

	public UILabel m_Label_CookedItemName;

	public UILabel m_Label_CookedItemDesc;

	public UILabel m_Label_CookedItemWeight;

	public UILabel m_Label_CookedItemCookTime;

	private UILabel m_Label_ButtonAction;

	private UILabel m_Label_ButtonSecondaryAction;

	private float m_BoilWaterLiters;

	private float m_MeltSnowLiters;

	private GameObject m_FireContainer;

	private Fire m_Fire;

	private CookingPotItem m_CookingPotInteractedWith;

	private int m_SelectedFoodIndexVal;

	private readonly List<GearItem> m_FoodList;

	private readonly List<CookingItemListEntry> m_CookingItemList;

	private readonly List<OnDelegate> m_DoWaterDelegates;

	private readonly List<OnDelegate> m_OnWaterUpDelegates;

	private readonly List<OnDelegate> m_OnWaterDownDelegates;

	private readonly List<string> m_WaterButtonStrings;

	private int m_LastFireMinutes;

	private int m_LastFireTemperature;

	private int SelectedFoodIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CalledBy(Type = typeof(Panel_CookWater), Member = "Enable")]
		[CalledBy(Type = typeof(Panel_CookWater), Member = "OnScrollItemSelect")]
		[CalledBy(Type = typeof(Panel_CookWater), Member = "ScrollDown")]
		[CalledBy(Type = typeof(Panel_CookWater), Member = "ScrollUp")]
		[CalledBy(Type = typeof(Panel_CookWater), Member = "MakeDefaultSelections")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
		[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsSnow")]
		[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsWater")]
		[Calls(Type = typeof(Transform), Member = "set_parent")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_CookWater), Member = "ScrollDown")]
	[Calls(Type = typeof(Panel_CookWater), Member = "ScrollUp")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_CookWater), Member = "Refresh")]
	[Calls(Type = typeof(Panel_CookWater), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetFeedFireTakeTorchePressed")]
	[Calls(Type = typeof(Panel_CookWater), Member = "OnDoActionSecondary")]
	[Calls(Type = typeof(Panel_CookWater), Member = "ExitCookingInterface")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_CookWater), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(Panel_CookWater), Member = "RefreshWater")]
	[Calls(Type = typeof(Panel_CookWater), Member = "RefreshSnow")]
	[Calls(Type = typeof(Panel_CookWater), Member = "RefreshFireDurationLabel")]
	[Calls(Type = typeof(Panel_CookWater), Member = "UpdateGearItem")]
	public void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(Panel_CookWater), Member = "RefreshFoodList")]
	[Calls(Type = typeof(Panel_CookWater), Member = "set_SelectedFoodIndex")]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(Panel_CookWater), Member = "RefreshWater")]
	[Calls(Type = typeof(Panel_CookWater), Member = "RefreshSnow")]
	[Calls(Type = typeof(Panel_CookWater), Member = "RefreshFireDurationLabel")]
	[Calls(Type = typeof(Panel_CookWater), Member = "UpdateGearItem")]
	[Calls(Type = typeof(Panel_CookWater), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetCookingPot(CookingPotItem cookingPot)
	{
	}

	[CalledBy(Type = typeof(Panel_CookWater), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshFireDurationLabel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_CookWater), Member = "set_SelectedFoodIndex")]
	public void OnScrollItemSelect(int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsWater")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void OnDoAction()
	{
	}

	[CalledBy(Type = typeof(Panel_CookWater), Member = "Update")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "UpdateGamepadControls")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(Panel_CookWater), Member = "ExitCookingInterface")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void OnDoActionSecondary()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_CookWater), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	[Calls(Type = typeof(Panel_CookWater), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnBoil()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_CookWater), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_CookWater), Member = "ClampWaterBoilAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 1)]
	public void OnBoilUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_CookWater), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ReduceToNearestDeltaMultiple")]
	[Calls(Type = typeof(Panel_CookWater), Member = "ClampWaterBoilAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnBoilDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	[Calls(Type = typeof(Panel_CookWater), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void OnMeltSnow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_CookWater), Member = "ClampMeltSnowAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void OnMeltSnowUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ReduceToNearestDeltaMultiple")]
	[Calls(Type = typeof(Panel_CookWater), Member = "ClampMeltSnowAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnMeltSnowDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsWater")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDoWater()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsWater")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnWaterDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsWater")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnWaterUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void PlayButtonClick()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingPotWaterCallback")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoBoilPickerAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetFireContainer(GameObject go)
	{
	}

	[CalledBy(Type = typeof(Rest.PassTimeHelper), Member = "PassTime")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "Update")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnDoActionSecondary")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnBoil")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnMeltSnow")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_CookWater), Member = "GetSelectedFood")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void ExitCookingInterface()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void UpdateScrollLists()
	{
	}

	[CalledBy(Type = typeof(Panel_CookWater), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_CookWater), Member = "set_SelectedFoodIndex")]
	[CallsUnknownMethods(Count = 1)]
	private void ScrollDown()
	{
	}

	[CalledBy(Type = typeof(Panel_CookWater), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_CookWater), Member = "set_SelectedFoodIndex")]
	private void ScrollUp()
	{
	}

	[CalledBy(Type = typeof(Panel_CookWater), Member = "set_SelectedFoodIndex")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "Update")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnDoWater")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnWaterDown")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnWaterUp")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "UpdateGamepadControls")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Panel_CookWater), Member = "GetSelectedFood")]
	private bool SelectedFoodIsSnow()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_CookWater), Member = "set_SelectedFoodIndex")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "Update")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnDoWater")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnWaterDown")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnWaterUp")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "UpdateGamepadControls")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Panel_CookWater), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool SelectedFoodIsWater()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_CookWater), Member = "ExitCookingInterface")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsSnow")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsWater")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 5)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private GearItem GetSelectedFood()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnBoil")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnBoilUp")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnBoilDown")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "RefreshFoodList")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "RefreshWater")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "ClampWaterBoilAmount")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallsUnknownMethods(Count = 2)]
	private GameObject GetBoilableWaterSupply()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_CookWater), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_CookWater), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(CookingItemListEntry), Member = "SetGearIconTexture")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(CookingItemListEntry), Member = "Update")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 15)]
	private void RefreshFoodList()
	{
	}

	[CalledBy(Type = typeof(Panel_CookWater), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_CookWater), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_CookWater), Member = "ClampWaterBoilAmount")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void RefreshWater()
	{
	}

	[CalledBy(Type = typeof(Panel_CookWater), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_CookWater), Member = "ClampMeltSnowAmount")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void RefreshSnow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_CookWater), Member = "set_SelectedFoodIndex")]
	private void MakeDefaultSelections()
	{
	}

	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnMeltSnowUp")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnMeltSnowDown")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "RefreshSnow")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void ClampMeltSnowAmount()
	{
	}

	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnBoilUp")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnBoilDown")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "RefreshWater")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_CookWater), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	private void ClampWaterBoilAmount()
	{
	}

	[CalledBy(Type = typeof(Panel_CookWater), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_Description")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateGearItem()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void EnableActionButton(bool enabled)
	{
	}

	[CalledBy(Type = typeof(Panel_CookWater), Member = "Update")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_CookWater), Member = "GetSelectedFood")]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsSnow")]
	[Calls(Type = typeof(Panel_CookWater), Member = "SelectedFoodIsWater")]
	[Calls(Type = typeof(InputManager), Member = "GetFeedFireTakeTorchePressed")]
	[Calls(Type = typeof(Panel_CookWater), Member = "OnDoActionSecondary")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateGamepadControls()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_CookWater()
	{
	}
}
