using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Crafting : Panel_AutoReferenced, INotificationHandler, IAccelerateTimeProvider
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
		[CallsDeduplicatedMethods(Count = 3)]
		[CalledBy(Type = typeof(Panel_Crafting), Member = "Initialize")]
		[CallsUnknownMethods(Count = 1)]
		public HighlightButton(UIButton button)
		{
		}

		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(Panel_Crafting), Member = "SetFilter")]
		[CalledBy(Type = typeof(Panel_Crafting), Member = "Initialize")]
		[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
		[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 2)]
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

		public static Comparison<BlueprintData> _003C_003E9__121_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
		[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal int _003CApplyFilter_003Eb__121_0(BlueprintData lhs, BlueprintData rhs)
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

	public string m_IconAccelerateTime;

	private PanelReference<Panel_Clothing> m_Clothing;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Inventory> m_Inventory;

	private PanelReference<Panel_Loading> m_Loading;

	private PanelReference<Panel_Log> m_Log;

	private PanelReference<Panel_Map> m_Map;

	[NonSerialized]
	public float m_CraftingTimeSeconds;

	private bool _003Cm_CraftingInProgress_003Ek__BackingField;

	private BlueprintData _003Cm_SelectedBPI_003Ek__BackingField;

	private InProgressCraftItem _003Cm_SelectedWIP_003Ek__BackingField;

	private CraftingLocationInterface m_CurrentLocation;

	private CraftingLocationInterface m_PreviousLocation;

	private int m_FrameCountSinceClosing;

	private UISlider m_BlueprintSlider;

	private GameObject m_BlueprintSliderRoot;

	private List<BlueprintData> m_Blueprints;

	private List<BlueprintData> m_FilteredBlueprints;

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
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public BlueprintData m_SelectedBPI
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 2)]
		private set
		{
		}
	}

	public event Action<string, NotificationFlagInfo> m_ItemSelected
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 2)]
		remove
		{
		}
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 66)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(HighlightButton), Member = "SetHighlighted")]
	[Calls(Type = typeof(HighlightButton), Member = ".ctor")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[Calls(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(Panel_Crafting), Member = "MaybeShowNotificationFlagForNewBlueprintEntry")]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateMouseKeyboardButtons")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateControllerButtons")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Panel_Crafting), Member = "ResetLastLocations")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Crafting), Member = "ResetLastLocations")]
	public void UpdateLastLocations()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlueprintData), Member = "CanCraftBlueprint")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanCraftBlueprint(BlueprintData bpi)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateMouseKeyboardButtons")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateControllerButtons")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBeginCrafting")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "RefreshCraftingTimeDisplay")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BlueprintData), Member = "CanCraftBlueprint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool CanCraftSelectedBlueprint()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnCraftingNav")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "EnableCraftingAtLocation")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnCraftingNav")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnCraftingButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnCraftingNav")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnCraftingNav")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnCraftingNav")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshBlueprints")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public void Enable(bool enable, bool fromPanel)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public void ResetNotificationsData()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public CraftingLocation GetCurrentCraftingLocation()
	{
		return default(CraftingLocation);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "GetAdjustedCraftingTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "GetFinalCraftingTimeWithAllModifiers")]
	public int GetModifiedCraftingDuration(int baseMinutes)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetModifiedCraftingDuration")]
	[CallsUnknownMethods(Count = 2)]
	public int GetAdjustedCraftingTime()
	{
		return default(int);
	}

	[Calls(Type = typeof(CraftingRequirementContainer), Member = "GetQuantity")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingStart")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "RefreshCraftingTimeDisplay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetModifiedCraftingDuration")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public int GetFinalCraftingTimeWithAllModifiers()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public void OnBackButton()
	{
	}

	[Calls(Type = typeof(BodyCarry), Member = "ShowError")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CraftingStart")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnClothingNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	public void OnFirstAidNav()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnInventoryNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsUnknownMethods(Count = 1)]
	public void OnJournalNav()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnMapNam()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	public void OnMissionNav()
	{
	}

	[Calls(Type = typeof(Panel_Crafting), Member = "MaybeShowNotificationFlagForNewBlueprintEntry")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Crafting), Member = "ApplyFilter")]
	public void OnCategoryChanged(int index)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void OnSelectedToolChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnFilterChange(UIButton button)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarBlueprintsChanged()
	{
	}

	[CalledBy(Type = typeof(WorkBench), Member = "InteractWithWorkbench")]
	[CalledBy(Type = typeof(Forge), Member = "PerformInteraction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CalledBy(Type = typeof(AmmoWorkBench), Member = "InteractWithWorkbench")]
	public void EnableCraftingAtLocation(CraftingLocationInterface location)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleOnNotificationAdded")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
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
	[CallsUnknownMethods(Count = 1)]
	protected void OnBlueprintDisplayClicked(int index)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ClothingItem), Member = "PickedUp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AchievementManager), Member = "CraftedItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[Calls(Type = typeof(BlueprintData), Member = "GetDisplayedNameWithCount")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetModifiedCraftingDuration")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "IsProgressComplete")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetAmmoCraftingCondition")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentCompleteNormalized")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	private void ApplyCraftingProgress(float hoursSpentCrafting)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ItemPassesFilter")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnCategoryChanged")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprints")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[CallsUnknownMethods(Count = 18)]
	private void ApplyFilter()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyFilter")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "IsGearType")]
	private bool ItemPassesFilter(BlueprintData bpi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductPowderFromInventory")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetModifiedCraftingDuration")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetModifiedCraftingDuration")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetModifiedCraftingDuration")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ConsumeMaterialsUsedForCrafting(float hoursSpentCrafting)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "Setup")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	private void CraftingEnd()
	{
	}

	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBeginCrafting")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "GetQuantity")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetFinalCraftingTimeWithAllModifiers")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void CraftingStart()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DegradeTools(float hoursSpentCrafting)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnCancelCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Crafting), Member = "DegradeTools")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateSkillAfterCrafting")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "IsProgressComplete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Crafting), Member = "CraftingEnd")]
	private void HandleCraftingInterrupt(InterruptReason reason)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CraftingEnd")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateSkillAfterCrafting")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[Calls(Type = typeof(Panel_Crafting), Member = "DegradeTools")]
	private void HandleCraftingSuccess()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	private void UpdateSkillAfterCrafting(bool success)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	private void UpdateControllerButtons()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	private void UpdateMouseKeyboardButtons()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleCraftingSuccess")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Crafting), Member = "UpdateSkillAfterCrafting")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateCrafting()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	private int GetSelectedDisplayIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CallsUnknownMethods(Count = 14)]
	private InProgressCraftItem GetInProgressItem(BlueprintData bpi)
	{
		return null;
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[Calls(Type = typeof(Panel_Crafting), Member = "OnBeginCrafting")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Crafting), Member = "HandleVerticalNavigation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(Panel_Crafting), Member = "OnBackButton")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "OnPrevious")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "OnNext")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "SetHighlightedItem")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenActionsPanelPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventorySortPressed")]
	private void HandleInput()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	private void HandleVerticalNavigation(float movement)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "Disable")]
	private void ClearSelectedBlueprint()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Crafting), Member = "ShouldBlockBasedOnCustomMode")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldAllowForSurvivalMode(BlueprintData bp)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Crafting), Member = "ShouldBlockBasedOnCustomMode")]
	private bool ShouldAllowForStoryMode(BlueprintData bp)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsBirchBarkTea(GearItem gi)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "ShouldAllowForSurvivalMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ShouldAllowForStoryMode")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private bool ShouldBlockBasedOnCustomMode(BlueprintData bp)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Enable")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ApplyFilter")]
	[Calls(Type = typeof(BlueprintManager), Member = "GetFilteredBlueprints")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	private void RefreshBlueprints()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnScrollbarBlueprintsChanged")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyFilter")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "SetSelected")]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "Setup")]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "Clear")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	private void RefreshBlueprintDisplayList()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "SetSelected")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ClearSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnScrollbarBlueprintsChanged")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBlueprintDisplayClicked")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyFilter")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingEnd")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleVerticalNavigation")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "CacheComponents")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetInProgressItem")]
	[Calls(Type = typeof(BlueprintData), Member = "GetDisplayedNameWithCount")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_Description")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void RefreshSelectedBlueprint()
	{
	}

	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 0)]
	private string CreateNegativePercentageText(float pct)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateLastLocations")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateLastLocations")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	private void ResetLastLocations()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateFilters")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateFilters")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateFilters")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateFilters")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateFilters")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnFilterChange")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ApplyFilter")]
	[Calls(Type = typeof(HighlightButton), Member = "SetHighlighted")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	private void SetFilter(Filter filter)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnControllerScheme")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBackButton")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetSelectedDisplayIndex")]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetSelectedDisplayIndex")]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "SetSelected")]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetSelected")]
	[Calls(Type = typeof(BlueprintDisplayItem), Member = "SetSelected")]
	private void SetNavigationArea(NavArea target)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(Panel_Crafting), Member = "RemoveNewBlueprintEntry")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnCategoryChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeShowNotificationFlagForNewBlueprintEntry()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "MaybeShowNotificationFlagForNewBlueprintEntry")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void RemoveNewBlueprintEntry(NotificationFlagInfo nfi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void CacheComponents()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetFilter")]
	private void UpdateFilters()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsAcceleratingTime()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetActionText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public string GetSpriteName()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public UIPanel GetPanelToFade()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void StartAcceleratingTime()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void StopAcceleratingTime()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 31)]
	public Panel_Crafting()
	{
	}
}
