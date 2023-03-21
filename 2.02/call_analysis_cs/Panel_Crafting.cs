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

		[CalledBy(Type = typeof(Panel_Crafting), Member = "Initialize")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameObject), Member = "GetComponent")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		public HighlightButton(UIButton button)
		{
		}

		[CalledBy(Type = typeof(Panel_Crafting), Member = "Initialize")]
		[CalledBy(Type = typeof(Panel_Crafting), Member = "SetFilter")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 5)]
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
		[CallerCount(Count = 7)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
		[Calls(Type = typeof(string), Member = "CompareTo")]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CApplyFilter_003Eb__117_0(BlueprintItem lhs, BlueprintItem rhs)
		{
			return 0;
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
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
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(HighlightButton), Member = ".ctor")]
	[Calls(Type = typeof(HighlightButton), Member = "SetHighlighted")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CacheComponents")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 58)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[CallsUnknownMethods(Count = 1)]
	public void OnControllerScheme(bool isController)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(Panel_Crafting), Member = "MaybeShowNotificationFlagForNewBlueprintEntry")]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateMouseKeyboardButtons")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateControllerButtons")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ResetLastLocations")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateLastLocations()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlueprintItem), Member = "CanCraftBlueprint")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanCraftBlueprint(BlueprintItem bpi)
	{
		return false;
	}

	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "RefreshCraftingTimeDisplay")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBeginCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateControllerButtons")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateMouseKeyboardButtons")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BlueprintItem), Member = "CanCraftBlueprint")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "GetSelectedTool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool CanCraftSelectedBlueprint()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnCraftingNav")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnCraftingNav")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnCraftingNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnCraftingNav")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnCraftingNav")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnCraftingButton")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshBlueprints")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "Initialize")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	public void Enable(bool enable, bool fromPanel)
	{
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
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

	[CalledBy(Type = typeof(Panel_Crafting), Member = "GetAdjustedCraftingTime")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "GetFinalCraftingTimeWithAllModifiers")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public int GetModifiedCraftingDuration(int baseMinutes)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetModifiedCraftingDuration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int GetAdjustedCraftingTime()
	{
		return 0;
	}

	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "RefreshCraftingTimeDisplay")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingStart")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetModifiedCraftingDuration")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "GetQuantity")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public int GetFinalCraftingTimeWithAllModifiers()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnBackButton()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[Calls(Type = typeof(BodyCarry), Member = "HasBody")]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CraftingStart")]
	[Calls(Type = typeof(BodyCarry), Member = "ShowError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public void OnBeginCrafting()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	public void OnCancelCrafting()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void OnClothingNav()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void OnFirstAidNav()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnInventoryNav()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnJournalNav()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "NoMapsUnlocked")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Map), Member = "ShowNoMapsUnlockedMessage")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void OnMapNam()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnFilterChange(UIButton button)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void OnScrollbarBlueprintsChanged()
	{
	}

	[CalledBy(Type = typeof(AmmoWorkBench), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Forge), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(WorkBench), Member = "ProcessInteraction")]
	[CallerCount(Count = 3)]
	public void SetCraftingLocation(CraftingLocationInterface location)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ShowPanelCraftingSubCategoryNotificationIcon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void HandleOnNotificationAdded(NotificationFlagInfo nfi)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void HandleOnSubcategoryNotificationRemoved(NotificationFlagInfo nfi)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleOnNotificationAdded")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public void ShowPanelCraftingSubCategoryNotificationIcon(SubCategory subCategory, bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnSelectedQuantityChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void OnBlueprintDisplayClicked(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetModifiedCraftingDuration")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "IsProgressComplete")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "UpdateWeight")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryWithCondition")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ClothingItem), Member = "PickedUp")]
	[Calls(Type = typeof(AchievementManager), Member = "CraftedItem")]
	[Calls(Type = typeof(BlueprintItem), Member = "GetDisplayedNameWithCount")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 32)]
	private void ApplyCraftingProgress(float hoursSpentCrafting)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnCategoryChanged")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprints")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ItemPassesFilter")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentNullException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	private void ApplyFilter()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyFilter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "PassesFilterType")]
	[CallsUnknownMethods(Count = 1)]
	private bool ItemPassesFilter(BlueprintItem bpi)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetModifiedCraftingDuration")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentCompleteNormalized")]
	[Calls(Type = typeof(BlueprintItem), Member = "NumToConsumeNow")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductPowderFromInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	private void ConsumeMaterialsUsedForCrafting(float hoursSpentCrafting)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "Setup")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void CraftingEnd()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBeginCrafting")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetFinalCraftingTimeWithAllModifiers")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "GetQuantity")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryInternal")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetInProgressItem")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 27)]
	private void CraftingStart()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void DegradeTools(float hoursSpentCrafting)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnCancelCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "IsProgressComplete")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateSkillAfterCrafting")]
	[Calls(Type = typeof(Panel_Crafting), Member = "DegradeTools")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CraftingEnd")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void HandleCraftingInterrupt(InterruptReason reason)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[Calls(Type = typeof(Panel_Crafting), Member = "DegradeTools")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateSkillAfterCrafting")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CraftingEnd")]
	private void HandleCraftingSuccess()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateSkillAfterCrafting(bool success)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 22)]
	private void UpdateControllerButtons()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateMouseKeyboardButtons()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateSkillAfterCrafting")]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateCrafting()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int GetSelectedDisplayIndex()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingStart")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private InProgressCraftItem GetInProgressItem(BlueprintItem bpi)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenActionsPanelPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventorySortPressed")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "SetHighlightedItem")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "OnNext")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "OnPrevious")]
	[Calls(Type = typeof(Panel_Crafting), Member = "OnBeginCrafting")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleVerticalNavigation")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(Panel_Crafting), Member = "OnBackButton")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 18)]
	private void HandleInput()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void HandleVerticalNavigation(float movement)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "Clear")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "Disable")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void ClearSelectedBlueprint()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(Utils), Member = "IsBirchBarkTea")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ApplyFilter")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void RefreshBlueprints()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnScrollbarBlueprintsChanged")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyFilter")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleVerticalNavigation")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "Clear")]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "Setup")]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "SetSelected")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	private void RefreshBlueprintDisplayList()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnScrollbarBlueprintsChanged")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBlueprintDisplayClicked")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyFilter")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingEnd")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleVerticalNavigation")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetInProgressItem")]
	[Calls(Type = typeof(BlueprintItem), Member = "GetDisplayedNameWithCount")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "SetSelected")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ClearSelectedBlueprint")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 44)]
	private void RefreshSelectedBlueprint()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	private string CreateNegativePercentageText(float pct)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateLastLocations")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[CallerCount(Count = 4)]
	private void ResetLastLocations()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnFilterChange")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateFilters")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(HighlightButton), Member = "SetHighlighted")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ApplyFilter")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SetFilter(Filter filter)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnControllerScheme")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBackButton")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetSelectedDisplayIndex")]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "SetSelected")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void SetNavigationArea(NavArea target)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnCategoryChanged")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RemoveNewBlueprintEntry")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	private void MaybeShowNotificationFlagForNewBlueprintEntry()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "MaybeShowNotificationFlagForNewBlueprintEntry")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void RemoveNewBlueprintEntry(NotificationFlagInfo nfi)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void CacheComponents()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateFilters()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 42)]
	public Panel_Crafting()
	{
	}
}
