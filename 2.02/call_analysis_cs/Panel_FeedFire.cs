using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class Panel_FeedFire : Panel_Base
{
	private delegate void OnDelegate();

	public UIWidget m_MainWidget;

	public float m_MinutesToBoilWaterPerLiter;

	public float m_MinutesToMeltSnowPerLiter;

	public float m_MinutesToPurifyPerLiter;

	public int m_MaxMeltSnowLiters;

	public float m_CookProgressBarSeconds;

	public float m_BoilProgressBarSeconds;

	public string m_BoilAudio;

	public string m_MeltAudio;

	public string m_PurifyAudio;

	public string m_FeedFireAudio;

	public float m_HoursRemainingFullFireSprite;

	public Color m_ScrollListSelectedColor;

	public Color m_ScrollListUnselectedColor;

	public UIButton[] m_TabFuelButtons;

	public GameObject m_TabFuel;

	public GameObject m_TabFood;

	public GameObject m_TabWater;

	public ScrollList m_FuelScrollList;

	public ScrollList m_FoodScrollList;

	public ScrollList m_WaterScrollList;

	public UILabel m_Label_EstimatedFireDuration;

	public UILabel m_Label_FireTemperature;

	public UILabel m_Label_Water;

	public UITexture m_Texture_GearItem;

	public UITexture m_Texture_InspectItem;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public GameObject m_MouseButtonParent;

	public GameObject m_ActionButtonObject;

	public GameObject m_ActionSecondaryButtonObject;

	public UISprite m_Sprite_FireFill;

	public UILabel m_Label_PotableSupply;

	public UILabel m_Label_NonpotableSupply;

	public GameObject m_DefaultSelectedButton;

	public GameObject m_Label_ProgressBar;

	public GameObject m_ProgressBar;

	public GameObject m_ButtonIncreaseWater;

	public GameObject m_ButtonDecreaseWater;

	public GameObject m_ButtonIncreaseSnow;

	public GameObject m_ButtonDecreaseSnow;

	public float m_InspectModeSizeModifier;

	private UILabel m_Label_ButtonAction;

	private UILabel m_Label_ButtonSecondaryAction;

	private float m_ElapsedProgressBarTimeSeconds;

	private float m_ProgressBarTimeSeconds;

	private float m_DayLengthScaleBeforeAcceleration;

	private ProgressBarMode m_ProgressBarMode;

	private float m_BoilWaterLiters;

	private float m_MeltSnowLiters;

	private float m_PurifyLiters;

	private GameObject m_FireContainer;

	private Fire m_Fire;

	private GearItem m_PrevSelectedGearItem;

	private GearItem m_ResearchItemToBurn;

	private int m_SelectedFuelSourceIndexVal;

	private int m_SelectedFoodIndexVal;

	private int m_SelectedWaterSourceIndexVal;

	private List<GearItem> m_FuelSourcesList;

	private List<GearItem> m_FoodList;

	private List<GearItem> m_WaterSourcesList;

	private bool m_EnablePending;

	private float m_EnableDelaySeconds;

	private float m_EnableDelayElapsed;

	private uint m_ProgressAudioID;

	private FireManager m_FireManager;

	private bool m_TimeOfDayAccelerated;

	private int m_NumFramesInPanel;

	private GameObject m_FoodBeingCooked;

	private bool m_DoingAction;

	private GameObject m_SelectedTab;

	private Dictionary<GameObject, int> m_TabDictionary;

	private List<OnDelegate> m_DoWaterDelegates;

	private List<OnDelegate> m_OnWaterUpDelegates;

	private List<OnDelegate> m_OnWaterDownDelegates;

	private List<OnDelegate> m_RefreshWaterDelegates;

	private List<string> m_WaterButtonStrings;

	public GameObject m_ButtonWaterDecrease;

	public GameObject m_ButtonWaterIncrease;

	public UILabel m_WaterAmountLabel;

	public string m_MeltSnowIcon;

	public string m_BoilWaterIcon;

	public string m_PurifyWaterIcon;

	private List<string> m_WaterIcons;

	private int m_MaxPurifyLiters;

	public UISprite m_FuelNavigateLeftGamepadButtonSprite;

	public UISprite m_FuelNavigateRightGamepadButtonSprite;

	public UISprite m_FoodNavigateLeftGamepadButtonSprite;

	public UISprite m_FoodNavigateRightGamepadButtonSprite;

	public UISprite m_WaterNavigateLeftGamepadButtonSprite;

	public UISprite m_WaterNavigateRightGamepadButtonSprite;

	private bool m_FuelTabDisabled;

	private bool m_IsOnFeedingFireTab;

	private int m_SelectedFuelSourceIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollUp")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnScrollItemSelect")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollDown")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateListItemColors")]
		[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
		set
		{
		}
	}

	private int m_SelectedFoodIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "MakeDefaultSelections")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFood")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFood")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollUp")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollDown")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnScrollItemSelect")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
		[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateListItemColors")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	private int m_SelectedWaterSourceIndex
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "MakeDefaultSelections")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshWaterSources")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollUp")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollDown")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshWaterSources")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateListItemColors")]
		[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnScrollItemSelect")]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnCancel")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshFireDurationLabel")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateScrollLists")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Update()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshFood")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshWaterSources")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshProgressLabel")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshFireDurationLabel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	public void Refresh()
	{
	}

	[CallsUnknownMethods(Count = 32)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerAttemptToFeedFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	public void EnableAfterDelay(float delaySeconds)
	{
	}

	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "DisableProgressBar")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	private void RefreshFireDurationLabel()
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	public void OnScrollItemSelect(int itemIndex)
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnFuelTab()
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	public void OnFoodTab()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	public void OnWaterTab()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnCook")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnFeedFireAction")]
	public void OnDoAction()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void OnFeedFireAction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDoActionSecondary()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "FireInForge")]
	[Calls(Type = typeof(Fire), Member = "AddFuel")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFireAction")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "FireShouldBlowOutFromWind")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "FireInForge")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowBurnResearchNotification")]
	public void OnFeedFire()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(Fire), Member = "AddFuel")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "FireInForge")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void ForceBurnResearchItem()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoActionSecondary")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "TakeTorchCallback")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(TorchItem), Member = "Ignite")]
	[Calls(Type = typeof(TorchItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(TorchItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[Calls(Type = typeof(GearItem), Member = "RollGearCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "CanTakeTorch")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	public void OnTakeTorch()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void OnCook()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StartBoil")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void OnBoil()
	{
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ClampWaterBoilAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnBoilUp()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	public void OnBoilDown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StartBoil")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnMeltSnow()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	public void OnMeltSnowUp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 2)]
	public void OnMeltSnowDown()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StartBoil")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnPurify()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ClampWaterPurifyAmount")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnPurifyUp()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ClampWaterPurifyAmount")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ClampWaterPurifyAmount")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ClampWaterPurifyAmount")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	public void OnPurifyDown()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void OnDoWater()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnWaterDown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnWaterUp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	public void OnDone()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	public void OnCancel()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void PlayButtonClick()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsDoingAction()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ProgressBarMode GetCurrentAction()
	{
		return default(ProgressBarMode);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "TakeTorchCallback")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerAttemptToFeedFire")]
	[CallsUnknownMethods(Count = 1)]
	public void SetFireContainer(GameObject go)
	{
	}

	[Calls(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void InspectPrevGearItem()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_PassTime), Member = "OnExecute")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDone")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[Calls(Type = typeof(WoodStove), Member = "Close")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Rest.PassTimeHelper), Member = "PassTime")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "DisableProgressBar")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "AwardPartialAmount")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	public void ExitFeedFireInterface()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	private void UpdateScrollLists()
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void ScrollDown()
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	private void ScrollUp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	private bool FilterItemFuelSource(GameObject go)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFireAction")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFuelTab")]
	private GearItem GetSelectedFuelSource()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnCook")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFoodTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	private GearItem GetSelectedFood()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshWaterSources")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ClampWaterPurifyAmount")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ClampWaterBoilAmount")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "PurifyingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "BoilingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshPurify")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshWater")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnPurifyDown")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnBoilUp")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnBoilDown")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnBoil")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnPurifyUp")]
	private GameObject GetBoilableWaterSupply()
	{
		return null;
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CallsUnknownMethods(Count = 71)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItemListEntry), Member = "SetGearItem")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshFuelSources()
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(GearItemListEntry), Member = "SetGearItem")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "HaveEnoughUnitsToStartCooking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshFood()
	{
	}

	[CallsUnknownMethods(Count = 144)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 32)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "NumGearInInventory")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void RefreshWaterSources()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ClampWaterBoilAmount")]
	private void RefreshWater()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 7)]
	private void RefreshSnow()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ClampWaterPurifyAmount")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshPurify()
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[CallerCount(Count = 0)]
	private void MakeDefaultSelections()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshProgressLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[CallsUnknownMethods(Count = 3)]
	private void DisableProgressBar()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "StartBoil")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "StartCooking")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private void EnableProgressBar()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "MeltingSnowCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "PurifyingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "BoilingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	private void RestoreTimeOfDay()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "StartCooking")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "StartBoil")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CallsUnknownMethods(Count = 3)]
	private void AccelerateTimeOfDay(float realtimeSeconds, int TODminutes)
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "AccelerateTimeOfDay")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "EnableProgressBar")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	private void StartCooking(int durationMinutes, string cookingAudio, ProgressBarMode mode)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnPurify")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnMeltSnow")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnBoil")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "EnableProgressBar")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	private void StartBoil(int durationMinutes, string boilAudio, ProgressBarMode type)
	{
	}

	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "DisableProgressBar")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "BoilingWaterCompleted")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "MeltingSnowCompleted")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "PurifyingWaterCompleted")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	private void UpdateProgressBar()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "SetCookedGearProperties")]
	[Calls(Type = typeof(PlayerManager), Member = "AddLiquidToInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void CookingCompleted()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GearItem), Member = "CopyHarvestedState")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCooking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetCookedGearProperties(GearItem rawItem, GearItem cookedItem)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "AddToPotableWaterSupply")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StopProgressBarAudio")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	private void BoilingWaterCompleted()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Inventory), Member = "AddToPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StopProgressBarAudio")]
	private void PurifyingWaterCompleted()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StopProgressBarAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	private void MeltingSnowCompleted()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "BoilingWaterCompleted")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "MeltingSnowCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "PurifyingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	private void StopProgressBarAudio()
	{
	}

	[CallerCount(Count = 0)]
	private bool ProgressBarIsActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshWater")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnBoilUp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void ClampWaterBoilAmount()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshPurify")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnPurifyDown")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnPurifyDown")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnPurifyDown")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnPurifyUp")]
	private void ClampWaterPurifyAmount()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void AwardPartialAmount()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool PlayerHasEnoughPotableWaterForCookingItem(Cookable cookable)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCooking")]
	[Calls(Type = typeof(Skill_Cooking), Member = "GetCookingTimeScale")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "EnableProgressBar")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnCook")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "AccelerateTimeOfDay")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQualityString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "HaveEnoughUnitsToStartCooking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	private void ExecuteCook(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFood")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool HaveEnoughUnitsToStartCooking(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnWaterTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFoodTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFuelTab")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	private void ShowTab(GameObject tab)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnWaterTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFuelTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFoodTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateGearItem(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	private void EnableActionButton(bool enabled)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "EnableActionButton")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnFeedFireAction")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 37)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(InputManager), Member = "GetFeedFireTakeTorchePressed")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "CanTakeTorch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "EnableActionButton")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "EnableActionButton")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void UpdateListItemColors(ScrollList scrollList, int selectedIndex)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "CanTakeTorch")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanTakeTorch()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ForceBurnResearchItem")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool FireInForge()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 70)]
	public Panel_FeedFire()
	{
	}
}
