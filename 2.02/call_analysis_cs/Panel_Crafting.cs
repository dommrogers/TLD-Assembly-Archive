using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Crafting : Panel_Base
{
	private enum InterruptReason
	{
		Cancelled,
		Interaction,
		LocationError,
		NotEnoughLight,
		ToolRuined
	}

	private class HighlightButton
	{
		private UIButton m_Button;

		private string m_DisabledSprite;

		private string m_NormalSprite;

		private UISprite m_TweenSprite;

		private Color m_DisabledColour;

		private Color m_NormalColour;

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CalledBy(Type = typeof(Panel_Crafting), Member = "Initialize")]
		[CallsUnknownMethods(Count = 2)]
		public HighlightButton(UIButton button)
		{
		}

		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(Panel_Crafting), Member = "SetFilter")]
		[CalledBy(Type = typeof(Panel_Crafting), Member = "Initialize")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
		public void SetHighlighted(bool highlighted)
		{
		}
	}

	private enum NavArea
	{
		Category,
		Blueprint
	}

	private enum Filter
	{
		All,
		Anywhere,
		WorkBench,
		Forge,
		AmmoWorkBench,
		Count
	}

	private enum Category
	{
		All,
		FireStarting,
		FirstAid,
		Clothing,
		Tools
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<BlueprintItem> _003C_003E9__117_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "CompareTo")]
		[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
		[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
		[CallerCount(Count = 0)]
		internal int _003CApplyFilter_003Eb__117_0(BlueprintItem lhs, BlueprintItem rhs)
		{
			return default(int);
		}
	}

	public GameObject m_SurvivalTabs;

	public GameObject m_StoryTabs;

	public UIButton m_CraftButton;

	public float m_CraftingDisplayTimeSeconds;

	public CraftingCategoryNavigation m_CategoryNavigation;

	public List<UIButton> m_FilterButtons;

	public UILabel m_FilterLabel;

	public Color m_RequirementsNotMetTint;

	public GameObject m_Root;

	public float m_SkillIncreaseChanceOnFailure;

	public float m_SkillIncreaseChanceOnSuccess;

	public List<BlueprintDisplayItem> m_BlueprintDisplays;

	public GameObject m_ScrollbarSpawner;

	public UILabel m_SelectedDescription;

	public UILabel m_SelectedName;

	public UITexture m_SelectedImage;

	public GameObject m_ClothingStatsRoot;

	public UILabel m_ClothingMobility;

	public UILabel m_ClothingToughness;

	public UILabel m_ClothingWarmth;

	public UILabel m_ClothingWaterproof;

	public UILabel m_ClothingWindproof;

	public GameObject m_ItemStatsRoot;

	public UILabel m_ItemCondition;

	public UILabel m_ItemWeight;

	public GameObject m_SelectedDetailsRoot;

	public CraftingRequirementContainer m_RequirementContainer;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public ButtonLegendContainer m_FilterButtonLegendContainer;

	public string m_CloseCraftingFromPanelAudio;

	[NonSerialized]
	public float m_CraftingTimeSeconds;

	private bool _003Cm_CraftingInProgress_003Ek__BackingField;

	private AssetBundleRef _003Cm_CraftingIconBundle_003Ek__BackingField;

	private BlueprintItem _003Cm_SelectedBPI_003Ek__BackingField;

	private InProgressCraftItem _003Cm_SelectedWIP_003Ek__BackingField;

	private CraftingLocationInterface m_CurrentLocation;

	private CraftingLocationInterface m_PreviousLocation;

	private int m_FrameCountSinceClosing;

	private UISlider m_BlueprintSlider;

	private GameObject m_BlueprintSliderRoot;

	private List<BlueprintItem> m_BlueprintItems;

	private List<BlueprintItem> m_FilteredBlueprintItems;

	private bool m_NeedsUpdate;

	private bool m_NeedsSelectedRefresh;

	private bool m_RefreshingSelectedBlueprint;

	private uint m_CraftingAudioID;

	private float m_HoursToSpendCrafting;

	private float m_RealTimeCraftingElapsed;

	private float m_RealTimeCraftingDuration;

	private float m_StoredDayLengthScale;

	private float m_NextUnitProgress;

	private int m_TargetQuantity;

	private int m_UnitsCompleted;

	private GamepadButtonSprite[] m_GamepadButtonSprites;

	private bool m_FromPanelOpen;

	private List<NotificationFlagInfo> m_BlueprintNewEntry;

	private NotificationFlag m_NotificationFlag;

	private Transform[] m_NotificationFlagChildren;

	private List<HighlightButton> m_HighlightButtons;

	private NavArea m_CurrentNavArea;

	private Filter m_CurrentFilter;

	private Category m_CurrentCategory;

	private int m_CurrentBlueprintIndex;

	private int m_CurrentBlueprintDisplayOffset;

	public bool m_CraftingInProgress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public AssetBundleRef m_CraftingIconBundle
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private set
		{
		}
	}

	public BlueprintItem m_SelectedBPI
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public InProgressCraftItem m_SelectedWIP
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		private set
		{
		}
	}

	public event Action<string, NotificationFlagInfo> m_ItemSelected
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 58)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CacheComponents")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HighlightButton), Member = "SetHighlighted")]
	[Calls(Type = typeof(HighlightButton), Member = ".ctor")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	public void OnControllerScheme(bool isController)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateControllerButtons")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateMouseKeyboardButtons")]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Crafting), Member = "MaybeShowNotificationFlagForNewBlueprintEntry")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ResetLastLocations")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ResetLastLocations")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateLastLocations()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BlueprintItem), Member = "CanCraftBlueprint")]
	[CallerCount(Count = 0)]
	public bool CanCraftBlueprint(BlueprintItem bpi)
	{
		return default(bool);
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BlueprintItem), Member = "CanCraftBlueprint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "RefreshCraftingTimeDisplay")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBeginCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateControllerButtons")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateMouseKeyboardButtons")]
	[CallsUnknownMethods(Count = 3)]
	public bool CanCraftSelectedBlueprint()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnCraftingButton")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnCraftingNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnCraftingNav")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnCraftingNav")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnCraftingNav")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnCraftingNav")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "Initialize")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshBlueprints")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	public void Enable(bool enable, bool fromPanel)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ResetNotificationsData()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public CraftingLocation GetCurrentCraftingLocation()
	{
		return default(CraftingLocation);
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "GetAdjustedCraftingTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "GetFinalCraftingTimeWithAllModifiers")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	public int GetModifiedCraftingDuration(int baseMinutes)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetModifiedCraftingDuration")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public int GetAdjustedCraftingTime()
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingStart")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "RefreshCraftingTimeDisplay")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "GetQuantity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetModifiedCraftingDuration")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	public int GetFinalCraftingTimeWithAllModifiers()
	{
		return default(int);
	}

	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void OnBackButton()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[Calls(Type = typeof(BodyCarry), Member = "ShowError")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CraftingStart")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(BodyCarry), Member = "HasBody")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnBeginCrafting()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	public void OnCancelCrafting()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnClothingNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	public void OnFirstAidNav()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnInventoryNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsUnknownMethods(Count = 1)]
	public void OnJournalNav()
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "ShowNoMapsUnlockedMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "NoMapsUnlocked")]
	public void OnMapNam()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsUnknownMethods(Count = 1)]
	public void OnMissionNav()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Crafting), Member = "MaybeShowNotificationFlagForNewBlueprintEntry")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ApplyFilter")]
	public void OnCategoryChanged(int index)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnSelectedToolChanged()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void OnFilterChange(UIButton button)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 5)]
	public void OnScrollbarBlueprintsChanged()
	{
	}

	[CalledBy(Type = typeof(WorkBench), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Forge), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(AmmoWorkBench), Member = "ProcessInteraction")]
	[CallerCount(Count = 3)]
	public void SetCraftingLocation(CraftingLocationInterface location)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Crafting), Member = "ShowPanelCraftingSubCategoryNotificationIcon")]
	[CallsUnknownMethods(Count = 2)]
	public void HandleOnNotificationAdded(NotificationFlagInfo nfi)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void HandleOnSubcategoryNotificationRemoved(NotificationFlagInfo nfi)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleOnNotificationAdded")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void ShowPanelCraftingSubCategoryNotificationIcon(SubCategory subCategory, bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnSelectedQuantityChanged()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnBlueprintDisplayClicked(int index)
	{
	}

	[Calls(Type = typeof(AchievementManager), Member = "CraftedItem")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(ClothingItem), Member = "PickedUp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(BlueprintItem), Member = "GetDisplayedNameWithCount")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetModifiedCraftingDuration")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "IsProgressComplete")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryWithCondition")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "UpdateWeight")]
	private void ApplyCraftingProgress(float hoursSpentCrafting)
	{
	}

	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprints")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnCategoryChanged")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Crafting), Member = "ItemPassesFilter")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	private void ApplyFilter()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyFilter")]
	[Calls(Type = typeof(GearItem), Member = "PassesFilterType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "PassesFilterType")]
	private bool ItemPassesFilter(BlueprintItem bpi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductPowderFromInventory")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetModifiedCraftingDuration")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetModifiedCraftingDuration")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentCompleteNormalized")]
	[Calls(Type = typeof(BlueprintItem), Member = "NumToConsumeNow")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetModifiedCraftingDuration")]
	private void ConsumeMaterialsUsedForCrafting(float hoursSpentCrafting)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "Setup")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	private void CraftingEnd()
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBeginCrafting")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetInProgressItem")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "GetQuantity")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetFinalCraftingTimeWithAllModifiers")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "AddToExistingStackable")]
	private void CraftingStart()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	private void DegradeTools(float hoursSpentCrafting)
	{
	}

	[Calls(Type = typeof(Panel_Crafting), Member = "CraftingEnd")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnCancelCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateSkillAfterCrafting")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "IsProgressComplete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Crafting), Member = "DegradeTools")]
	private void HandleCraftingInterrupt(InterruptReason reason)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CraftingEnd")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateSkillAfterCrafting")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Crafting), Member = "DegradeTools")]
	private void HandleCraftingSuccess()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateSkillAfterCrafting(bool success)
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	private void UpdateControllerButtons()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	private void UpdateMouseKeyboardButtons()
	{
	}

	[Calls(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateSkillAfterCrafting")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateCrafting()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[CallsUnknownMethods(Count = 2)]
	private int GetSelectedDisplayIndex()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingStart")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private InProgressCraftItem GetInProgressItem(BlueprintItem bpi)
	{
		return null;
	}

	[Calls(Type = typeof(CraftingRequirementContainer), Member = "OnPrevious")]
	[Calls(Type = typeof(Panel_Crafting), Member = "OnBeginCrafting")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleVerticalNavigation")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(Panel_Crafting), Member = "OnBackButton")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "OnNext")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "SetHighlightedItem")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventorySortPressed")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenActionsPanelPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	private void HandleInput()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	private void HandleVerticalNavigation(float movement)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "Clear")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "Disable")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CallsUnknownMethods(Count = 4)]
	private void ClearSelectedBlueprint()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Enable")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ApplyFilter")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Utils), Member = "IsBirchBarkTea")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	private void RefreshBlueprints()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyFilter")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnScrollbarBlueprintsChanged")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "SetSelected")]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "Setup")]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void RefreshBlueprintDisplayList()
	{
	}

	[Calls(Type = typeof(BlueprintDisplayItem), Member = "SetSelected")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnScrollbarBlueprintsChanged")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBlueprintDisplayClicked")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyFilter")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingEnd")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleVerticalNavigation")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ClearSelectedBlueprint")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetInProgressItem")]
	[Calls(Type = typeof(BlueprintItem), Member = "GetDisplayedNameWithCount")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	private void RefreshSelectedBlueprint()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string CreateNegativePercentageText(float pct)
	{
		return null;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateLastLocations")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateLastLocations")]
	private void ResetLastLocations()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateFilters")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateFilters")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateFilters")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateFilters")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateFilters")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ApplyFilter")]
	[Calls(Type = typeof(HighlightButton), Member = "SetHighlighted")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnFilterChange")]
	private void SetFilter(Filter filter)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBackButton")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnControllerScheme")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetSelectedDisplayIndex")]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetSelectedDisplayIndex")]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetSelected")]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "SetSelected")]
	private void SetNavigationArea(NavArea target)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnCategoryChanged")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RemoveNewBlueprintEntry")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	private void MaybeShowNotificationFlagForNewBlueprintEntry()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "MaybeShowNotificationFlagForNewBlueprintEntry")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void RemoveNewBlueprintEntry(NotificationFlagInfo nfi)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Initialize")]
	[CallsUnknownMethods(Count = 5)]
	private void CacheComponents()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	private void UpdateFilters()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 42)]
	public Panel_Crafting()
	{
	}
}
