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
			return 0;
		}
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnScrollItemSelect")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollDown")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollUp")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
		[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateListItemColors")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
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
			return 0;
		}
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnScrollItemSelect")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollDown")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollUp")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFood")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "MakeDefaultSelections")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
		[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateListItemColors")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
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
			return 0;
		}
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnScrollItemSelect")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollDown")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollUp")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshWaterSources")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "MakeDefaultSelections")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateListItemColors")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 15)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshFireDurationLabel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateScrollLists")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 27)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshFood")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshWaterSources")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshFireDurationLabel")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshProgressLabel")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 33)]
	public void Refresh()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerAttemptToFeedFire")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 32)]
	public void EnableAfterDelay(float delaySeconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "DisableProgressBar")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 32)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
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
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void RefreshFireDurationLabel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnScrollItemSelect(int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnFuelTab()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnFoodTab()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnWaterTab()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnCook")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnFeedFireAction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public void OnDoAction()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnFeedFireAction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDoActionSecondary()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFireAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "FireShouldBlowOutFromWind")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "FireInForge")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowBurnResearchNotification")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Fire), Member = "AddFuel")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 29)]
	public void OnFeedFire()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "FireInForge")]
	[Calls(Type = typeof(Fire), Member = "AddFuel")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void ForceBurnResearchItem()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "TakeTorchCallback")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoActionSecondary")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "CanTakeTorch")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "RollGearCondition")]
	[Calls(Type = typeof(TorchItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	[Calls(Type = typeof(TorchItem), Member = "Ignite")]
	[Calls(Type = typeof(TorchItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 19)]
	public void OnTakeTorch()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnCook()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StartBoil")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnBoil()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ClampWaterBoilAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void OnBoilUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnBoilDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StartBoil")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnMeltSnow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnMeltSnowUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnMeltSnowDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StartBoil")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnPurify()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ClampWaterPurifyAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnPurifyUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ClampWaterPurifyAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnPurifyDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDoWater()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void OnWaterDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void OnWaterUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnDone()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[CallerCount(Count = 1)]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void PlayButtonClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsDoingAction()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ProgressBarMode GetCurrentAction()
	{
		return default(ProgressBarMode);
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "TakeTorchCallback")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerAttemptToFeedFire")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SetFireContainer(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void InspectPrevGearItem()
	{
	}

	[CalledBy(Type = typeof(Rest.PassTimeHelper), Member = "PassTime")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDone")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[CalledBy(Type = typeof(Action_PassTime), Member = "OnExecute")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "AwardPartialAmount")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "DisableProgressBar")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(WoodStove), Member = "Close")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void ExitFeedFireInterface()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[CallerCount(Count = 1)]
	private void UpdateScrollLists()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ScrollDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ScrollUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool FilterItemFuelSource(GameObject go)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFuelTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFireAction")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 6)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private GearItem GetSelectedFuelSource()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFoodTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnCook")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 10)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private GearItem GetSelectedFood()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnBoil")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnBoilUp")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnBoilDown")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnPurifyUp")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnPurifyDown")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshWaterSources")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshWater")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshPurify")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "BoilingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "PurifyingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ClampWaterBoilAmount")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ClampWaterPurifyAmount")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private GameObject GetBoilableWaterSupply()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(GearItemListEntry), Member = "SetGearItem")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentNullException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 71)]
	private void RefreshFuelSources()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "HaveEnoughUnitsToStartCooking")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(GearItemListEntry), Member = "SetGearItem")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentNullException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 41)]
	private void RefreshFood()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "NumGearInInventory")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 144)]
	private void RefreshWaterSources()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ClampWaterBoilAmount")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	private void RefreshWater()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void RefreshSnow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ClampWaterPurifyAmount")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void RefreshPurify()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	private void MakeDefaultSelections()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void RefreshProgressLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void DisableProgressBar()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "StartCooking")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "StartBoil")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void EnableProgressBar()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "BoilingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "PurifyingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "MeltingSnowCompleted")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void RestoreTimeOfDay()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "StartCooking")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "StartBoil")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void AccelerateTimeOfDay(float realtimeSeconds, int TODminutes)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "EnableProgressBar")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "AccelerateTimeOfDay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void StartCooking(int durationMinutes, string cookingAudio, ProgressBarMode mode)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnBoil")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnMeltSnow")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnPurify")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "EnableProgressBar")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void StartBoil(int durationMinutes, string boilAudio, ProgressBarMode type)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "PurifyingWaterCompleted")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "MeltingSnowCompleted")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "BoilingWaterCompleted")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "DisableProgressBar")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateProgressBar()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "SetCookedGearProperties")]
	[Calls(Type = typeof(PlayerManager), Member = "AddLiquidToInventory")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 44)]
	private void CookingCompleted()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCooking")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GearItem), Member = "CopyHarvestedState")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	private void SetCookedGearProperties(GearItem rawItem, GearItem cookedItem)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Inventory), Member = "AddToPotableWaterSupply")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void BoilingWaterCompleted()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(Inventory), Member = "AddToPotableWaterSupply")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void PurifyingWaterCompleted()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void MeltingSnowCompleted()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "BoilingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "PurifyingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "MeltingSnowCompleted")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void StopProgressBarAudio()
	{
	}

	[CallerCount(Count = 0)]
	private bool ProgressBarIsActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnBoilUp")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshWater")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ClampWaterBoilAmount()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnPurifyUp")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnPurifyDown")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshPurify")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ClampWaterPurifyAmount()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void AwardPartialAmount()
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

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnCook")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "HaveEnoughUnitsToStartCooking")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQualityString")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCooking")]
	[Calls(Type = typeof(Skill_Cooking), Member = "GetCookingTimeScale")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "EnableProgressBar")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "AccelerateTimeOfDay")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 33)]
	private void ExecuteCook(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFood")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private bool HaveEnoughUnitsToStartCooking(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFuelTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFoodTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnWaterTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ShowTab(GameObject tab)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFuelTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFoodTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnWaterTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 20)]
	private void UpdateGearItem(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	private void EnableActionButton(bool enabled)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "CanTakeTorch")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "EnableActionButton")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnFeedFireAction")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[Calls(Type = typeof(InputManager), Member = "GetFeedFireTakeTorchePressed")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 37)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateListItemColors(ScrollList scrollList, int selectedIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "CanTakeTorch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool CanTakeTorch()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ForceBurnResearchItem")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private bool FireInForge()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 70)]
	public Panel_FeedFire()
	{
	}
}
