using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Inventory : Panel_AutoReferenced, INotificationHandler
{
	[Serializable]
	public struct BackpackDisplayInfo
	{
		public LocalizedString m_DisplayName;

		public GearItemData m_GearItemData;

		public string m_IconName;

		public bool m_IsDefault;
	}

	private delegate void ScrollDelegate(int itemIndex);

	private sealed class _003C_003Ec__DisplayClass140_0
	{
		public int firstItemIndex;

		public int numColumns;

		public int itemCount;

		public int numRows;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass140_0()
		{
		}

		[CallerCount(Count = 0)]
		internal void _003CNavigate_003Eb__0(int n)
		{
		}

		[CallerCount(Count = 0)]
		internal void _003CNavigate_003Eb__1(int n)
		{
		}
	}

	private PanelReference<Panel_Actions> m_ActionsPanel;

	private PanelReference<Panel_ActionsRadial> m_ActionsRadialPanel;

	private PanelReference<Panel_Affliction> m_AfflictionPanel;

	private PanelReference<Panel_BodyHarvest> m_BodyHarvest;

	private PanelReference<Panel_Clothing> m_ClothingPanel;

	private PanelReference<Panel_Crafting> m_CraftingPanel;

	private PanelReference<Panel_FirstAid> m_FirstAidPanel;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBarPanel;

	private PanelReference<Panel_Harvest> m_HarvestPanel;

	private PanelReference<Panel_Inventory_Examine> m_InventoryExamine;

	private PanelReference<Panel_Log> m_LogPanel;

	private PanelReference<Panel_Map> m_MapPanel;

	private PanelReference<Panel_PickUnits> m_PickUnits;

	private PanelReference<Panel_PickWater> m_PickWater;

	private PanelReference<Panel_Repair> m_RepairPanel;

	public GameObject m_SurvivalTabs;

	public GameObject m_StoryTabs;

	public GameObject TableObject;

	public GameObject InventoryItemPrefab;

	public int m_MaxItemsDisplayAtOnce;

	public UILabel m_Label_CarryCapacity;

	public GameObject m_MouseButtonBack;

	public UISprite m_CapacityBarOutline;

	public UISprite m_CapacityBarSprite;

	public Color m_CapacityNormalColor;

	public Color m_CapacityOverloadColor;

	public Color m_CapacityBuffColor;

	public UIButton m_DefaultFilterButton;

	public UIButton m_DefaultSortButton;

	public UIButton[] m_SortButtons;

	public UIButton[] m_FilterButtons;

	public UILabel m_CategoryLabel;

	public GameObject m_ScrollbarObject;

	public Color m_LowConditionColor;

	public Color m_MediumConditionColor;

	public Color m_HighConditionColor;

	public float m_AlphaWhenInBackground;

	public GameObject m_InteractionBlocker;

	public GameObject m_ButtonBack;

	public UILabel m_LabelNoItems;

	public Color m_ColorFilterSelected;

	public Color m_ColorFilterSelectedHover;

	public Color m_ColorFilterUnselectedEmpty;

	public Color m_ColorFilterUnselectedEmptyHover;

	public Color m_ColorFilterUnselectedNonempty;

	public Color m_ColorFilterUnselectedNonemptyHover;

	public Color m_ColorDisabled;

	public GameObject m_Stats;

	public UILabel m_AirTempLabel;

	public UILabel m_AirTempHeaderLabel;

	public UILabel m_WindChillLabel;

	public UILabel m_WindChillHeaderLabel;

	public UILabel m_ClothingWarmthLabel;

	public UILabel m_ClothingWarmthHeaderLabel;

	public UILabel m_ClothingWindproofLabel;

	public UILabel m_ClothingWindproofHeaderLabel;

	public UILabel m_TemperatureLabel;

	public GameObject m_SelectedSpriteObj;

	public TweenScale m_SelectedSpriteTweenScale;

	public UILabel m_CategoryWeightLabel;

	public GameObject m_CategoryWeightBG;

	public UILabel m_ClothingWeightLabel;

	public GameObject m_ClothingWeightBG;

	public float m_SecondsBetweenMove;

	public List<GearItem> m_FilteredInventoryList;

	public int m_TableNumColumns;

	public float m_TableSpacingHorizontal;

	public float m_TableSpacingVertical;

	public GameObject m_ItemDescriptionGameObject;

	public UILabel m_RuinedLabel;

	public GameObject m_ItemDescriptionPageDummy;

	public GameObject m_ItemDescriptionPagePrefab;

	public GameObject m_GearItemCoverflowLocation;

	public GameObject m_GearItemCoverflowPrefab;

	public GameObject m_SortLabel;

	public GameObject m_SortButtonsObject;

	public float m_PlaceObjectHoldDuration;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public ButtonLegendContainer m_SortButtonLegendContainer;

	public List<GameObject> m_NotificationFlagsFilterButtons;

	public GameObject m_SelectedEffect;

	public bool m_EnableDiaryOnExit;

	public List<BackpackDisplayInfo> m_BackpackDisplays;

	public UIButton m_FilterAllButton;

	public UILabel m_TitleLabel;

	private UISlider m_ScrollbarSlider;

	private UIButton m_SelectedFilterButton;

	private UIButton m_SelectedSortButton;

	private string m_SelectedSortOldSprite;

	private string m_FilterName;

	private string m_SortName;

	private Dictionary<string, bool> m_SortFlipDictionary;

	private int m_SelectedSortIndex;

	private int m_SelectedFilterIndex;

	private int m_SelectedItemIndexVal;

	private int m_NumItemsDisplayed;

	private int m_FirstItemDisplayedIndexVal;

	private int m_NumFramesInPanel;

	private uint m_OpenCloseAudioID;

	private GearItem m_LastSelectedGearItem;

	private float m_SecondsToNextMove;

	private int m_NumColumns;

	private InventoryGridItem[] m_TableItems;

	private GearItem m_LastDroppedSingleGearItem;

	private bool m_IsDirty;

	private bool m_ForceSelectionUpdate;

	private ItemDescriptionPage m_ItemDescriptionPage;

	private GearItemCoverflow m_GearItemCoverflow;

	private bool m_PausedAndHidden;

	public Transform m_SectionNavSelectedSprite;

	public GameObject m_SectionNavArrowPrompts;

	private int m_SectionNavIndex;

	public bool m_IsInSectionNav;

	private List<CategoryButton> m_SectionButtons;

	private float m_DropButtonHeldTime;

	private static readonly bool ENABLE_QUICK_PLACEMENT;

	private GamepadButtonSprite[] m_GamepadButtonSprites;

	private List<GearItem> m_SpecialCarryCapacityBuffItems;

	private List<NotificationFlagInfo> m_InventoryNewEntry;

	private NotificationFlag m_NotificationFlag;

	private Transform[] m_NotificationFlagChildren;

	private bool m_MovementPressedOnEnable;

	private const int NUM_SLOTS = 4;

	private GameObject[] m_SlotLabels;

	private int m_SelectedItemIndex
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "ScrollToBottom")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "ScrollToBottom")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "SelectLastSelectedGearItem")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "SelectGridItem")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "ScrollDown")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
		[CalledBy(Type = typeof(InventoryGridItem), Member = "OnClick")]
		[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
		[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
		[CallerCount(Count = 11)]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
		set
		{
		}
	}

	private int m_FirstItemDisplayedIndex
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "ScrollToBottom")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "ScrollToBottom")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "SelectLastSelectedGearItem")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "OnSortChange")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "OnFilterChange")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "ScrollUp")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "ScrollDown")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "Initialize")]
		[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
		[CallerCount(Count = 12)]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
		set
		{
		}
	}

	public event Action<string, NotificationFlagInfo> m_ItemSelected
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Inventory), Member = "CacheComponents")]
	[Calls(Type = typeof(Panel_Inventory), Member = "InitQuickSelect")]
	[Calls(Type = typeof(Panel_Inventory), Member = "InstantiateItemDescriptionPage")]
	[Calls(Type = typeof(Panel_Inventory), Member = "InstantiateInventoryTableItems")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_FirstItemDisplayedIndex")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnSortChange")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_FirstItemDisplayedIndex")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_SelectedItemIndex")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Navigate")]
	[Calls(Type = typeof(Utils), Member = "GetMovementPressed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(Panel_Inventory), Member = "FilterHasNoItems")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateScrollbarThumbSize")]
	[Calls(Type = typeof(Panel_Inventory), Member = "MaybeShowNotificationFlagForNewInventoryEntry")]
	[Calls(Type = typeof(Panel_Inventory), Member = "DoSectionNavControls")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateScrollbarThumbSize")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateButtons")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Inventory), Member = "DeselectAllItems")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Inventory), Member = "FilterHasNoItems")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshFilterIconColors")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateButtonStates")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnSortChange")]
	[Calls(Type = typeof(InputManager), Member = "GetInventorySortPressed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateFilterNavigation")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetInventorySortPressed")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnSortChange")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSortNavigation()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnFilterChange")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	private void UpdateFilterNavigation()
	{
	}

	[Calls(Type = typeof(Panel_Inventory), Member = "OnEquip")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnPlace")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnBack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryAddToSatchelPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryEquipPressed")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnAddToSatchel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenActionsPanelPressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnClothingNav")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnCraftingNav")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	private void UpdateButtonTriggers()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetMovementPressed")]
	private void MaybeFlagMovmentPressedOnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetMovementPressed")]
	private bool ShouldIgnoreNavigationInput()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "GetMouseButtonDown")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "GetMouseButtonDown")]
	public static bool Navigate(MonoBehaviour context, ref int refSelectedIndex, ref int refFirstItemIndex, int itemCount, int tableLength, int numColumns)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private int ClampIndexToFilteredItemsCount(int index)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_SelectedItemIndex")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_FirstItemDisplayedIndex")]
	public void ScrollDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_FirstItemDisplayedIndex")]
	public void ScrollUp()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private string GetRefuelButtonText(GearItem gi)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnEquip")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetExamineButtonLocalizationID")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "CanExamine")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetEquipButtonLocalizationId")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateSortLabels")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Inventory), Member = "CanBeAddedToSatchel")]
	private void UpdateButtonStates()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFoodOpeningComplete")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateGearStatsBlock")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_SelectedItemIndex")]
	[Calls(Type = typeof(InventoryGridItem), Member = "Refresh")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	public void RefreshTable()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "GetAllSpecialCarryingCapacityBuffItems")]
	[Calls(Type = typeof(Panel_Inventory), Member = "SelectLastSelectedGearItem")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateButtonStates")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateScrollbarThumbSize")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshBackpackDisplay")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(GameManager), Member = "MaybeForceGC")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_Inventory), Member = "EnterSectionNav")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateSortLabels")]
	[Calls(Type = typeof(GameAudioManager), Member = "CanPlaySpecialUIEntrySound")]
	[Calls(Type = typeof(Panel_Affliction), Member = "OnCancel")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Inventory), Member = "SelectLastSelectedGearItem")]
	[Calls(Type = typeof(Inventory), Member = "Update")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Inventory), Member = "EnableNavigationTabs")]
	[Calls(Type = typeof(Panel_Inventory), Member = "DeselectAllItems")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory), Member = "EnableNavigationTabs")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "GetMovementPressed")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_FirstItemDisplayedIndex")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	public void Enable(bool enable, bool resetFilter = true)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void ResetNotificationsData()
	{
	}

	[CallerCount(Count = 0)]
	public void MarkDirty()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_SelectedItemIndex")]
	[CallsUnknownMethods(Count = 1)]
	public void SelectGridItem(InventoryGridItem gridItem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool IsEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsPausedAndHidden()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnPopupClicked()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnStatus()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnLog()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "DoSectionNavControls")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnClothingNav()
	{
	}

	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnFirstAidNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsUnknownMethods(Count = 1)]
	public void OnJournalNav()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[Calls(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	public void OnCraftingNav()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnMissionsNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	public void OnMapNav()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void OnScrollbarChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnFilterChange")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshFilterIconColors")]
	public void ResetFilter()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "ResetFilter")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateFilterNavigation")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_FirstItemDisplayedIndex")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	public void OnFilterChange(UIButton filterButtonClicked)
	{
	}

	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateSortNavigation")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_FirstItemDisplayedIndex")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIButtonColor), Member = "ResetDefaultColor")]
	[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
	[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 3)]
	public void OnSortChange(UIButton sortButtonClicked)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool AllowUseAtZeroHP(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "DoubleClick")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "DoubleClick")]
	[Calls(Type = typeof(BodyCarry), Member = "ShowError")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateButtonStates")]
	[Calls(Type = typeof(Panel_Inventory), Member = "ExitInterface")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetEquipButtonLocalizationId")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnEquip()
	{
	}

	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassToFrozenMessage")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[Calls(Type = typeof(BodyCarry), Member = "ShowError")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "HasNoHarvestingTool")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "CanExamine")]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnExamine()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CallsUnknownMethods(Count = 1)]
	private void PauseAndHide()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_FirstItemDisplayedIndex")]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(Inventory), Member = "Update")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_SelectedItemIndex")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "CanDrop")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory), Member = "ItemPassesFilter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory), Member = "SelectLastSelectedGearItem")]
	[Calls(Type = typeof(Panel_Inventory), Member = "PauseAndHide")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "SetGearForDrop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory), Member = "PauseAndHide")]
	[Calls(Type = typeof(Panel_PickWater), Member = "SetWaterSupplyForDrop")]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	public void OnDrop()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "CanDrop")]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnPlace()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsSelected(GearItem item)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "AddFuel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallerCount(Count = 0)]
	public void OnRefuel()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void OnOtherAction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[CallsUnknownMethods(Count = 1)]
	public void OnHarvest()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[CallsUnknownMethods(Count = 1)]
	public void OnRepair()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnEquip")]
	[CalledBy(Type = typeof(InputManager), Member = "DisableActiveSubMenu")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	public void ExitInterface(bool restoreItemInHands)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "ItemPassesFilter")]
	[CallsUnknownMethods(Count = 2)]
	private bool IgnoreWaterSupplyItem(WaterSupply ws)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private bool IsPausedFlare(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "FilterHasNoItems")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[Calls(Type = typeof(Panel_Inventory), Member = "IgnoreWaterSupplyItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsGearType")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "IsGearType")]
	private bool ItemPassesFilter(GearItem pi, string filterName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[Calls(Type = typeof(Panel_Inventory), Member = "ExitInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Panel_Inventory), Member = "EnterSectionNav")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	public void OnBack()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "OnFavorite")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnAddToSatchel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateButtons")]
	[Calls(Type = typeof(Panel_Inventory), Member = "MoveSelectedSpriteAndTween")]
	[CallsUnknownMethods(Count = 4)]
	public void OnControllerScheme(bool isController)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "AddItemToSatchel")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OnBackFinal")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ReplaceItemInSatchel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	public void ReturnFromAddToSatchel()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateFavoriteStatus")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonStates")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanBeAddedToSatchel(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public int GetNumFramesInPanel()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnControllerScheme")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "AssignSlot")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateGearStatsBlock")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnAddToSatchel")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnHarvest")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnHarvest")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnRefuel")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "IsSelected")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnPlace")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnEquip")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonStates")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Inventory), Member = "ItemPassesFilter")]
	[CallerCount(Count = 19)]
	private GearItem GetCurrentlySelectedGearItem()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "Initialize")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void InstantiateInventoryTableItems()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Initialize")]
	[CallsUnknownMethods(Count = 15)]
	private void InstantiateItemDescriptionPage()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public static int CompareGearByName(GearItem g1, GearItem g2)
	{
		return default(int);
	}

	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static int CompareGearByNameTorchesLast(GearItem g1, GearItem g2)
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static int CompareGearByNameHarvestableLast(GearItem g1, GearItem g2)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static int CompareGearByCondition(GearItem g1, GearItem g2)
	{
		return default(int);
	}

	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	public static int CompareGearByWeight(GearItem g1, GearItem g2)
	{
		return default(int);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_SelectedItemIndex")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_FirstItemDisplayedIndex")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_SelectedItemIndex")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UseEmergencyStim")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnFilterChange")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnRefuel")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UseItem")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Inventory), Member = "ItemPassesFilter")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void UpdateFilteredInventoryList()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory), Member = "ShowPanelInventorySubCategoryNotificationIcon")]
	public void HandleOnNotificationAdded(NotificationFlagInfo nfi)
	{
	}

	[Calls(Type = typeof(Panel_Inventory), Member = "ShowPanelInventorySubCategoryNotificationIcon")]
	[CallerCount(Count = 0)]
	public void HandleOnSubcategoryNotificationRemoved(NotificationFlagInfo nfi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RemoveNewInventoryEntry")]
	[CallsUnknownMethods(Count = 2)]
	public void HandleOnInventoryItemRemoved(GearItem gi)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "HandleOnNotificationAdded")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "HandleOnSubcategoryNotificationRemoved")]
	public void ShowPanelInventorySubCategoryNotificationIcon(SubCategory subCategory, bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_SelectedItemIndex")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_FirstItemDisplayedIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private bool SelectLastSelectedGearItem()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_SelectedItemIndex")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_FirstItemDisplayedIndex")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_SelectedItemIndex")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_FirstItemDisplayedIndex")]
	[CallerCount(Count = 0)]
	private void ScrollToBottom()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "ResetFilter")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[Calls(Type = typeof(Panel_Inventory), Member = "FilterHasNoItems")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	private void RefreshFilterIconColors()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshNoItemsLabel")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshFilterIconColors")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[Calls(Type = typeof(Panel_Inventory), Member = "ItemPassesFilter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private bool FilterHasNoItems(string filterName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Inventory), Member = "FilterHasNoItems")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshNoItemsLabel()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonStates")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateSortLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private void UpdateScrollbarThumbSize()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateGearStatsBlock")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateGearStatsBlock")]
	[CallsUnknownMethods(Count = 7)]
	private void EnableGearStatsBlock(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Inventory), Member = "EnableGearStatsBlock")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetGearItem")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[Calls(Type = typeof(Panel_Inventory), Member = "EnableGearStatsBlock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	private void UpdateGearStatsBlock()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void DoSectionNavUpdate()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnFilterChange")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnBack")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshFilterIconColors")]
	[Calls(Type = typeof(Panel_Inventory), Member = "DeselectAllItems")]
	[Calls(Type = typeof(Panel_Inventory), Member = "MoveSectionNavToButton")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnFilterChange")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnClothingNav")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnCraftingNav")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void DoSectionNavControls()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	private bool ShouldEnterSectionNav()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "EnterSectionNav")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "DoSectionNavControls")]
	private void MoveSectionNavToButton(UIButton button)
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshFilterIconColors")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Inventory), Member = "MoveSectionNavToButton")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory), Member = "DeselectAllItems")]
	private void EnterSectionNav()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	private void DeselectAllItems()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 2)]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "HasSpecialCarryingCapacityGear")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_NoValue")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshBackpackDisplay()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RemoveNewInventoryEntry")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	private void MaybeShowNotificationFlagForNewInventoryEntry()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "MaybeShowNotificationFlagForNewInventoryEntry")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "HandleOnInventoryItemRemoved")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private void RemoveNewInventoryEntry(NotificationFlagInfo nfi)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	private void CacheComponents()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory), Member = "AssignSlot")]
	public void OnAssignSlot0()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory), Member = "AssignSlot")]
	public void OnAssignSlot1()
	{
	}

	[Calls(Type = typeof(Panel_Inventory), Member = "AssignSlot")]
	[CallerCount(Count = 0)]
	public void OnAssignSlot2()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory), Member = "AssignSlot")]
	public void OnAssignSlot3()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Initialize")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void InitQuickSelect()
	{
	}

	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateSlotLabel")]
	[CallerCount(Count = 0)]
	private void UpdateQuickSelect()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(GearItem), Member = "GetBasicDisplayNameForInventoryInterfaces")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateQuickSelect")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateSlotLabel(int slotIndex)
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnAssignSlot3")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnAssignSlot2")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnAssignSlot1")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnAssignSlot0")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory), Member = "GetCurrentlySelectedGearItem")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "ItemCanEquipInHands")]
	private void AssignSlot(int slotIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public Panel_Inventory()
	{
	}
}
