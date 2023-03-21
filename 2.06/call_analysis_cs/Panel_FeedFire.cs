using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_FeedFire : Panel_AutoReferenced, IAccelerateTimeProvider
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

	public string m_IconNameBoiling;

	public string m_IconNameCooking;

	public string m_IconNameHeatingUp;

	public string m_IconNameMelting;

	public string m_IconNamePurifyingWater;

	private UILabel m_Label_ButtonAction;

	private UILabel m_Label_ButtonSecondaryAction;

	private float m_ElapsedProgressBarTimeSeconds;

	private float m_ProgressBarTimeSeconds;

	private float m_DayLengthScaleBeforeAcceleration;

	private ProgressBarMode m_ProgressBarMode;

	private float m_BoilWaterLiters;

	private float m_MeltSnowLiters;

	private float m_PurifyLiters;

	private FireplaceInteraction m_FireplaceInteraction;

	private GearItem m_PrevSelectedGearItem;

	private GearItem m_ResearchItemToBurn;

	private Action m_OnDoneFeedingFire;

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

	private PanelReference<Panel_CanOpening> m_CanOpening;

	private PanelReference<Panel_Confirmation> m_Confirmation;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

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
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollUp")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollDown")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnScrollItemSelect")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateListItemColors")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
		[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
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
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFood")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFood")]
		[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollUp")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "MakeDefaultSelections")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollDown")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateListItemColors")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnScrollItemSelect")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 8)]
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
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "MakeDefaultSelections")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshWaterSources")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshWaterSources")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollUp")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ScrollDown")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateListItemColors")]
		[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnScrollItemSelect")]
		[CallerCount(Count = 8)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnCancel")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ScrollDown")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ScrollUp")]
	[Calls(Type = typeof(InputManager), Member = "GetMouseButtonDown")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetMouseButtonDown")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ScrollDown")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ScrollUp")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshFireDurationLabel")]
	private void Update()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshProgressLabel")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshFireDurationLabel")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshWaterSources")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshFood")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallsUnknownMethods(Count = 6)]
	public void Refresh()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FireplaceInteraction), Member = "AttemptToFeedFire")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "TakeTorchCallback")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	public void SetFireplaceInteraction(FireplaceInteraction fireplaceInteraction)
	{
	}

	[CalledBy(Type = typeof(FireplaceInteraction), Member = "AttemptToFeedFire")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	public void ShowFeedFire(float delaySeconds, Action onDoneFeedingFire)
	{
	}

	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "DisableProgressBar")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
	[Calls(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	private void RefreshFireDurationLabel()
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void OnScrollItemSelect(int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	public void OnFuelTab()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	public void OnFoodTab()
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnWaterTab()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnFeedFireAction")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnDoAction()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[CallsUnknownMethods(Count = 1)]
	public void OnFeedFireAction()
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnDoActionSecondary()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "FireInForge")]
	[Calls(Type = typeof(Fire), Member = "AddFuel")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFireAction")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(PlayerManager), Member = "ResetPickup")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "FireShouldBlowOutFromWind")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "FireInForge")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowBurnResearchNotification")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	public void OnFeedFire()
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "FireInForge")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(Fire), Member = "AddFuel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void ForceBurnResearchItem()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[Calls(Type = typeof(TorchItem), Member = "MaybeEnableNavMeshObstacle")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "TakeTorchCallback")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoActionSecondary")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(TorchItem), Member = "Ignite")]
	[Calls(Type = typeof(GearItem), Member = "RollGearCondition")]
	[Calls(Type = typeof(TorchItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "CanTakeTorch")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	public void OnTakeTorch()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void OnCook()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StartBoil")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void OnBoil()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ClampWaterBoilAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void OnBoilUp()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnBoilDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StartBoil")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void OnMeltSnow()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnMeltSnowUp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void OnMeltSnowDown()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "StartBoil")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnPurify()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ClampWaterPurifyAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void OnPurifyUp()
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "ClampWaterPurifyAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnPurifyDown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDoWater()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnWaterDown()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnWaterUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	public void OnDone()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "InspectPrevGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "AwardPartialAmount")]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void PlayButtonClick()
	{
	}

	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	public void InspectPrevGearItem()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[CalledBy(Type = typeof(Action_PassTime), Member = "OnExecute")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDone")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(Rest.PassTimeHelper), Member = "PassTime")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "AwardPartialAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "DisableProgressBar")]
	public void ExitFeedFireInterface()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void UpdateScrollLists()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	private void ScrollDown()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	private void ScrollUp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	private bool FilterItemFuelSource(GameObject go)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFireAction")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
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
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFoodTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	private GearItem GetSelectedFood()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ClampWaterPurifyAmount")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ClampWaterBoilAmount")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "PurifyingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "BoilingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshPurify")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshWater")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshWaterSources")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnPurifyUp")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnBoilDown")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnBoilUp")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnBoil")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnPurifyDown")]
	private GameObject GetBoilableWaterSupply()
	{
		return null;
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshPositioning")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAlpha")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshScale")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CallsUnknownMethods(Count = 81)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAlpha")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshScale")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItemListEntry), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshPositioning")]
	private void RefreshFuelSources()
	{
	}

	[CallsUnknownMethods(Count = 48)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(GearItemListEntry), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "HaveEnoughUnitsToStartCooking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshFood()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CallsUnknownMethods(Count = 83)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 29)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	private void RefreshWaterSources()
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "ClampWaterBoilAmount")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void RefreshWater()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshSnow()
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "ClampWaterPurifyAmount")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	private void RefreshPurify()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	private void MakeDefaultSelections()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshProgressLabel()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[CallsUnknownMethods(Count = 3)]
	private void DisableProgressBar()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "StartBoil")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "StartCooking")]
	private void EnableProgressBar()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "MeltingSnowCompleted")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "BoilingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "PurifyingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnCancel")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	private void RestoreTimeOfDay()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "StartCooking")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "StartBoil")]
	[CallsUnknownMethods(Count = 1)]
	private void AccelerateTimeOfDay(float realtimeSeconds, int TODminutes)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "AccelerateTimeOfDay")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "EnableProgressBar")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void StartCooking(int durationMinutes, string cookingAudio, ProgressBarMode mode)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnBoil")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnPurify")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnMeltSnow")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "EnableProgressBar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void StartBoil(int durationMinutes, string boilAudio, ProgressBarMode type)
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "MeltingSnowCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "DisableProgressBar")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "BoilingWaterCompleted")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "PurifyingWaterCompleted")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	private void UpdateProgressBar()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "AddLiquidToInventory")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RestoreTimeOfDay")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "SetCookedGearProperties")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	private void CookingCompleted()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GearItem), Member = "CopyHarvestedState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCooking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetCookedGearProperties(GearItem rawItem, GearItem cookedItem)
	{
	}

	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Inventory), Member = "AddToPotableWaterSupply")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void BoilingWaterCompleted()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Inventory), Member = "AddToPotableWaterSupply")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	private void PurifyingWaterCompleted()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateProgressBar")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void MeltingSnowCompleted()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopProgressBarAudio()
	{
	}

	[CallerCount(Count = 0)]
	private bool ProgressBarIsActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshWater")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnBoilUp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ClampWaterBoilAmount()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshPurify")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnPurifyDown")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnPurifyUp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ClampWaterPurifyAmount()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnCancel")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	private void AwardPartialAmount()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private bool PlayerHasEnoughPotableWaterForCookingItem(Cookable cookable)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCooking")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "EnableProgressBar")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "AccelerateTimeOfDay")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnCook")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQualityString")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "HaveEnoughUnitsToStartCooking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallerCount(Count = 3)]
	private void ExecuteCook(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFood")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool HaveEnoughUnitsToStartCooking(GearItem gi)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnWaterTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFoodTab")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFuelTab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 5)]
	private void ShowTab(GameObject tab)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnWaterTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFoodTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFuelTab")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateGearItem(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallerCount(Count = 3)]
	private void EnableActionButton(bool enabled)
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "EnableActionButton")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnFeedFireAction")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnDoAction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(InputManager), Member = "GetFeedFireTakeTorchePressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "EnableActionButton")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "CanTakeTorch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "EnableActionButton")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "GetSelectedFood")]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFoodIndex")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedWaterSourceIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "set_m_SelectedFuelSourceIndex")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void UpdateListItemColors(ScrollList scrollList, int selectedIndex)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "CanTakeTorch")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanTakeTorch()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ForceBurnResearchItem")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	private bool FireInForge()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsAcceleratingTime()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetActionText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public string GetSpriteName()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIPanel GetPanelToFade()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 58)]
	public UIWidget GetWidgetToFade()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Action GetCancelAction()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[CallsUnknownMethods(Count = 1)]
	public void StartAcceleratingTime()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	public void StopAcceleratingTime()
	{
	}

	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 51)]
	[CallerCount(Count = 0)]
	public Panel_FeedFire()
	{
	}
}
