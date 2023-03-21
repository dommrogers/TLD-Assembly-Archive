using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.GameplayTags;
using TLD.Scenes;
using TLD.Stats;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Log : Panel_AutoReferenced, INotificationHandler
{
	private enum BackAction
	{
		Unknown,
		ReturnToMap
	}

	public enum NavigationTabState
	{
		None,
		Journal,
		Missions
	}

	[Serializable]
	public struct NavigationTabs
	{
		public GameObject m_Parent;

		public GameObject m_JournalTab;

		public GameObject m_MissionsTab;
	}

	public enum CollectionsType
	{
		SelectScreen,
		General,
		Notes,
		Matchbooks,
		Postcards,
		Cairns,
		AuroraScreens,
		SurveyScreen,
		Mementos
	}

	public class LogMissionInfo
	{
		public string name;

		public string description;

		public string[] checklistKeys;

		public string[] checklistValues;

		public bool[] checklistBools;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public LogMissionInfo()
		{
		}
	}

	public enum WhatIKnowType
	{
		SelectScreen,
		People,
		Actions,
		Places,
		Things
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CairnInfo> _003C_003E9__253_0;

		public static Comparison<AuroraScreenInfo> _003C_003E9__253_1;

		public static Comparison<CairnInfo> _003C_003E9__339_0;

		public static Comparison<AuroraScreenInfo> _003C_003E9__340_0;

		public static Comparison<SurveyAchievementInfo> _003C_003E9__389_3;

		public static Comparison<SurveyAchievementInfo> _003C_003E9__389_4;

		public static Comparison<SurveyRegionInfo> _003C_003E9__389_0;

		public static Comparison<SurveyRegionInfo> _003C_003E9__389_1;

		public static Comparison<SurveyRegionInfo> _003C_003E9__389_2;

		public static Comparison<RegionInfo> _003C_003E9__554_0;

		public static Comparison<RegionInfo> _003C_003E9__554_1;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCollectibleList_003Eb__253_0(CairnInfo x, CairnInfo y)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCollectibleList_003Eb__253_1(AuroraScreenInfo x, AuroraScreenInfo y)
		{
			return default(int);
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal int _003CStoreCairnCollectiblesInRecord_003Eb__339_0(CairnInfo x, CairnInfo y)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CStoreAuroraScreenCollectiblesInRecord_003Eb__340_0(AuroraScreenInfo x, AuroraScreenInfo y)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCartographyRegionList_003Eb__389_3(SurveyAchievementInfo a, SurveyAchievementInfo b)
		{
			return default(int);
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal int _003CBuildCartographyRegionList_003Eb__389_4(SurveyAchievementInfo a, SurveyAchievementInfo b)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCartographyRegionList_003Eb__389_0(SurveyRegionInfo a, SurveyRegionInfo b)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCartographyRegionList_003Eb__389_1(SurveyRegionInfo a, SurveyRegionInfo b)
		{
			return default(int);
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 1)]
		internal int _003CBuildCartographyRegionList_003Eb__389_2(SurveyRegionInfo a, SurveyRegionInfo b)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CGenerateRockCacheScreenData_003Eb__554_0(RegionInfo a, RegionInfo b)
		{
			return default(int);
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CGenerateRockCacheScreenData_003Eb__554_1(RegionInfo a, RegionInfo b)
		{
			return default(int);
		}
	}

	public bool m_EnableDiaryOnExit;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public Color m_BoldColor;

	public NavigationTabs m_SurvivalTabs;

	public NavigationTabs m_StoryTabs;

	private NavigationTabState m_NavigationTabState;

	public UILabel m_PageHeader;

	public UILabel m_ScrollListHeader;

	public GameObject m_LogGridItemPrefab;

	public GameObject m_GridItemParent;

	public Vector2 m_GridItemSpacing;

	public GameObject m_SelectedSpriteObj;

	public TweenScale m_SelectedSpriteTweenScale;

	public GameObject m_MainLogObject;

	public GameObject m_NotesSectionObject;

	public GameObject m_LogSectionObject;

	public GameObject m_CollectibleSectionObject;

	public GameObject m_NotesObject;

	public GameObject m_RockCachesSectionObject;

	public GameObject m_CartographySectionObject;

	public GameObject m_DailyLogObject;

	public GameObject m_TOCObject;

	public GameObject m_DailyStatsPageObject;

	public GameObject m_NoDataMessageObject;

	public GameObject m_ExamineObject;

	public GameObject m_TabsObject;

	public GameObject m_TabsNotesObject;

	public GameObject m_StatsPages;

	public GameObject m_DailyScrollbar;

	public UILabel m_CurrentGameLabel;

	public UILabel m_StatsDayLabel;

	public UILabel m_StatsExploredLabel;

	public UILabel m_StatsRestedLabel;

	public UILabel m_StatsConditionLabel;

	public UILabel m_StatsCalorieLabel;

	public UILabel m_StatsInjuriesLabel;

	public UILabel m_StatsNumLocationsLabel;

	public UIGrid m_StatsLocationGrid;

	public GameObject m_StatsLocationPrefab;

	public TextInputField m_NotesTextField;

	public UIPanel m_NotesTextPanel;

	public GenericButtonMouseSpawner m_NotesButtonWrite;

	public UILabel m_CollectibleNameLabel;

	public UILabel m_CollectibleDescLabel;

	public UITexture m_CollectibleBigIcon;

	public UILabel m_CollectibleNameExamineLabel;

	public UILabel m_CollectibleReadTextLabel;

	public GameObject m_DescriptionPageObject;

	public GameObject m_NoCollectiblesObject;

	public UIPanel m_ExamineCollectibleTextPanel;

	public GameObject m_ButtonExamineCollectible;

	public UITexture m_CollectibleItemTexture;

	public GameObject m_ScrollbarDays;

	public GameObject m_ScrollbarStats;

	public GameObject m_ScrollbarNotes;

	public GameObject m_ScrollbarCollectibles;

	public GameObject m_ScrollbarExamineCollectible;

	public GameObject m_ScrollbarDetailedStats;

	public GameObject m_SectionNav;

	public Transform m_SectionNavSelectedSprite;

	public Transform m_SectionNavButtonStartPosition;

	public Vector3 m_SectionNavButtonSpacing;

	public UIButton m_DailyLogButton;

	public UIButton m_StatsButton;

	public UIButton m_CollectiblesButton;

	public UIButton m_GeneralNotesButton;

	public UIButton m_RockCachesButton;

	public UIButton m_CartographyButton;

	private GamepadButtonSprite[] m_GamepadButtonSprites;

	public UILabel m_Label_CauseOfDeath;

	public GameObject m_Object_FadeBackground;

	public UILabel m_SandboxHeader;

	public PanelLogState[] m_PanelLogStateOrder;

	public GameObject[] m_TopNavButtonOrder;

	public GameObject m_SectionNavArrowPrompts;

	public Transform m_SectionNavBottomArrow;

	public float m_SectionNavBottomArrowOffset;

	public GameObject m_KnowledgeNotificationPrefab;

	public GameObject m_CollectionsNotificationPrefab;

	public Log m_Log;

	private PanelLogState m_State;

	private List<GearItem> m_CollectibleGearItems;

	private List<CairnInfo> m_CollectibleCairnItems;

	private List<AuroraScreenInfo> m_CollectibleAuroraScreenItems;

	private float m_StatsPanelHeight;

	private float m_NotesPanelHeight;

	private float m_ExamineCollectiblePanelHeight;

	private string m_CachedNotesString;

	private int m_PrevCursorPosition;

	private bool m_ViewNotesToggle;

	private bool m_ReadyForInput;

	private bool m_WasRenamingInMouseScheme;

	private bool m_WasRenamingLastFrame;

	private UICamera.ControlScheme m_CachedScheme;

	private bool m_FadeInProgress;

	private bool m_OverwriteView;

	private bool m_HasSavedJournal;

	private NotificationFlag m_NotificationFlag;

	private Transform[] m_NotificationFlagChildren;

	private Transform[] m_KnowledgeChildren;

	private Transform[] m_CollectionChildren;

	public bool m_EnabledFromMainMenu;

	public int m_MaxJournals;

	public SummaryStatsView m_SummaryStatsView;

	public DetailedStatsView m_DetailedStatsView;

	public UIGrid m_MouseButtonGrid;

	public GameObject m_Button_SaveJournal;

	public GameObject m_Button_View;

	public GameObject m_Button_Overwrite;

	public GameObject m_Button_Delete;

	public GameObject m_Button_Rename;

	public GameObject m_Button_ResetAllTimeStats;

	public GameObject m_Button_Back;

	public UILabel m_Label_SurvivalRecordText;

	public UILabel m_Label_DiedFromText;

	public UITexture m_TOCRegionTexture;

	public UISprite m_Sprite_ExperienceMode;

	public UILabel m_Label_EndDate;

	public GameObject m_TOCContent;

	public GameObject m_NoTOCContent;

	public UIGrid m_TocButtonGrid;

	public ScrollList m_TocScrollList;

	public GameObject m_TocScrollbar;

	private List<Panel_Log_Toc_GridItem> m_TocItems;

	private bool m_LeftStickUpNonZeroOnEnter;

	public string m_OpenLogAudio;

	public string m_CloseLogAudio;

	public string m_CloseJournalSelectAudio;

	private int m_ExamineNotesAnchorLeft;

	private int m_ExamineNotesAnchorRight;

	private int m_ExamineNotesAnchorTop;

	private int m_ExamineNotesAnchorBottom;

	private int m_ExamineBufferMemoryAnchorLeft;

	private int m_ExamineBufferMemoryAnchorRight;

	private int m_ExamineBufferMemoryAnchorTop;

	private int m_ExamineBufferMemoryAnchorBottom;

	private int m_DefaultPanelDepth;

	private int m_RenderOverOtherScreensPanelDepth;

	private PanelReference<Panel_Actions> m_ActionsPanel;

	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	private PanelReference<Panel_Clothing> m_Clothing;

	private PanelReference<Panel_Confirmation> m_Confirmation;

	private PanelReference<Panel_Crafting> m_CraftingPanel;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Inventory> m_Inventory;

	private PanelReference<Panel_Loading> m_Loading;

	private PanelReference<Panel_Map> m_Map;

	private PanelReference<Panel_MissionsStory> m_MissionsStory;

	private List<CategoryButton> m_TopCategoryButtons;

	private List<LogGridItem> m_LogGridItemList;

	private int m_NumColumns;

	private int m_NumRows;

	private int m_NumGridItemsVisible;

	private int m_LogGridItemIndex;

	private int m_LogGridNumRowsScrolled;

	private int m_SectionNavIndex;

	private PanelLogState m_SectionNavCacheState;

	private List<PanelLogState> m_ActiveStates;

	private uint m_OpenCloseAudioID;

	private BackAction m_BackAction;

	private readonly Dictionary<GameplayTag, PanelLogState> m_EnableFromRadialTags;

	private readonly Dictionary<PanelLogState, GameplayTag> m_RetainInJournalTags;

	private SandboxRecordData m_SandboxRecordAtDeath;

	private int m_SandboxSelectedIndex;

	private SandboxRecordData m_SelectedSandboxRecord;

	private RegionSpecification m_SandboxRecordStartRegion;

	private GameModeConfig m_SandboxRecordGameMode;

	public static bool m_MarkFalseBlizzards;

	public GameObject m_AlmanacSectionObject;

	public UIButton m_AlmanacButton;

	public UIGrid m_AlmanacGrid;

	public GameObject m_AlmanacGridItemPrefab;

	public UILabel m_CatFiveLabel;

	public UILabel m_CatFiveChanceLabel;

	public int m_NumDaysShown;

	public float m_ThresholdHoursCat4;

	public float m_ThresholdHoursCat3;

	public float m_ThresholdHoursCat2;

	public int m_MinNumberFalseBlizzards;

	public int m_MaxNumberFalseBlizzards;

	public int m_DaysToBlockFalseBlizzard;

	public int m_MaxChanceShownForFalseBlizard;

	public int m_MinChanceShownForTrueBlizard;

	private List<AlmanacGridItem> m_AlmanacGridItems;

	public List<SurveyRegionListItem> m_SurveyRegionDisplayList;

	public GameObject m_SurveyListRegionScrollbar;

	public List<SurveyListItem> m_SurveyDisplayList;

	public GameObject m_SurveyListScrollbar;

	public GameObject m_ForceRevealButton;

	public List<Texture> m_SurveyRegionButtonTextures;

	private List<SurveyRegionInfo> m_SurveyRegionList;

	private int m_CurrentSurveyRegionIndex;

	private int m_CurrentSurveyAchievementIndex;

	private int m_SurveyRegionIndexOffset;

	private int m_SurvayAchievementIndexOffset;

	private PanelLogSurveyStates m_SurveyState;

	private int m_SurveyedLocations;

	private int m_TotalSurveyLocations;

	private bool m_ForceReveal;

	private const string LOC_FILTER_SURVEYSCREEN = "GAMEPLAY_CollectionFilterSurveyScreen";

	private const string LOC_FILTER_NOTES = "GAMEPLAY_CollectionFilterNotes";

	private const string LOC_FILTER_MATCHBOOKS = "GAMEPLAY_CollectionFilterMatchbooks";

	private const string LOC_FILTER_POSTCARDS = "GAMEPLAY_CollectionFilterPostcards";

	private const string LOC_FILTER_MEMENTOS = "GAMEPLAY_Mementos";

	private const string LOC_FILTER_CAIRNS = "GAMEPLAY_CollectionFilterCairns";

	private const string LOC_FILTER_AURORASCREENS = "GAMEPLAY_CollectionFilterAuroraScreens";

	private const string LOC_DESC_NOTES = "GAMEPLAY_CollectionNotesDescription";

	private const string LOC_DESC_MATCHBOOKS = "GAMEPLAY_CollectionMatchbooksDescription";

	private const string LOC_DESC_POSTCARDS = "GAMEPLAY_CollectionPostcardsDescription";

	private const string LOC_DESC_MEMENTOS = "GAMEPLAY_MementosFound";

	private const string LOC_DESC_CAIRNS = "GAMEPLAY_CollectionCairnsDescription";

	private const string LOC_DESC_AURORASCREENS = "GAMEPLAY_CollectionAuroraScreensDescription";

	private const string LOC_DESC_SURVEYSCREEN = "GAMEPLAY_CollectionSurveyScreenDescription";

	private const string LOC_COLLECTIONS = "GAMEPLAY_Collections";

	private const string LOC_SELECT = "GAMEPLAY_Select";

	private const string ACTION_CONTINUE = "Continue";

	private const string ACTION_ESCAPE = "Escape";

	public GameObject m_CollectiblesSubSectionObject;

	public GameObject m_CollectionsSubSectionObject;

	public ScrollList m_CollectionsScrollList;

	public UITexture m_CollectionsImage;

	public UILabel m_CollectionsNameLabel;

	public UILabel m_CollectionsDescLabel;

	public GameObject m_NoCollectionsOfType;

	public GameObject m_CollectionSelectSubScreenButton;

	public GameObject m_NoCollectionObject;

	public int m_TotalNumNoteCollectibles;

	public int m_TotalNumMatchbookCollectibles;

	public int m_TotalNumCairnCollectibles;

	public int m_TotalNumAuroraScreenCollectibles;

	public string m_NotesSpriteNameSmall;

	public string m_NotesSpriteNameBig;

	public string m_MatchbooksSpriteNameSmall;

	public string m_MatchbooksSpriteNameBig;

	public string m_CairnsSpriteNameSmall;

	public string m_CairnsSpriteNameBig;

	public string m_AuroraScreensSpriteNameSmall;

	public string m_AuroraScreensSpriteNameBig;

	public string m_SurveyScreenSpriteNameSmall;

	public string m_SurveyScreenSpriteNameBig;

	public AssetLabelReference m_PostcardLabel;

	public string m_PostcardsSpriteNameSmall;

	public string m_PostcardsSpriteNameBig;

	public AssetLabelReference m_MementoLabel;

	public string m_MementosSpriteNameSmall;

	public string m_MementosSpriteNameBig;

	private bool m_CollectionsToggle;

	private CollectionsType m_CollectionsCurrType;

	private readonly List<CollectionListItem> m_CollectionList;

	private int m_CollectionListSelectedIndex;

	private int m_CurrNumNoteCollectibles;

	private int m_CurrNumMatchbookCollectibles;

	private int m_CurrNumPostcardCollectibles;

	private int m_CurrNumCairnCollectibles;

	private int m_CurrNumAuroraScreenCollectibles;

	private int m_CurrNumMementoCollectibles;

	private readonly List<CollectionListItemInfo> m_CollectionDataList;

	private readonly List<NotificationFlagInfo> m_CollectionsNewEntry;

	private readonly List<NarrativeCollectibleItem> m_AvailablePostcards;

	private readonly List<NarrativeCollectibleItem> m_AvailableMementoItems;

	private bool m_CollectionsAddressablesLoaded;

	public GameObject m_MissionsSectionObject;

	public UILabel m_MissionNameLabel;

	public UILabel m_MissionNameHeaderLabel;

	public UILabel m_MissionDescriptionLabel;

	public Transform m_ObjectiveTransform;

	public UILabel m_MainObjectiveLabel;

	public ChallengeChecklistEntry[] m_ChecklistEntries;

	public float m_ChallengeChecklistOffsetY;

	public float m_ChallengeChecklistVerticalSpacing;

	public GameObject m_TimerObject;

	public UILabel m_TimerLabel;

	public UITexture m_ChallengeTexture;

	public UIButton m_MissionsButton;

	public int m_PixelBufferTimer;

	public UISprite m_MainObjectiveSprite;

	private GameplayTag m_UpdateMissionInfoFromPrefab;

	private GameplayTag m_UseMissionTimerTextFromActionsRadial;

	private GameplayTag m_ActivateObjectiveTransform;

	private StoryMissionInfo m_CurrentMissionInfo;

	private List<StoryMissionObjective> m_ObjectivesToShow;

	private List<LogMissionInfo> m_MissionsInfoList;

	public List<RockCacheListItem> m_RockCacheRegionDisplayList;

	public GameObject m_RockCacheRegionsScrollbar;

	public List<RockCacheListItem> m_RockCacheItemDisplayList;

	public GameObject m_RockCacheItemsScrollbar;

	public GameObject m_RockCacheDetails;

	public UILabel m_RockCacheNameLabel;

	public GameObject m_RockCacheMapButton;

	public TextInputField m_RockCacheNoteTextField;

	public UIInput m_RockCacheNoteUIInput;

	public GameObject m_RockCacheNoteScrollbar;

	public UIPanel m_RockCacheNoteTextPanel;

	public float m_RockCacheNotePanelHeight;

	public int m_RockCacheNotePrevCursorPosition;

	private List<RegionInfo> m_RegionNameList;

	private Dictionary<string, List<RockCacheInfo>> m_RockCacheListByRegion;

	private int m_CurrentRockCacheRegionIndex;

	private int m_CurrentRockCacheItemIndex;

	private int m_RockCacheRegionIndexOffset;

	private int m_RockCacheItemIndexOffset;

	private PanelLogRockCacheStates m_RockCacheState;

	private bool m_CanShowOnMap;

	private string m_SelectButtonString;

	private string m_RockCacheNoteString;

	private string m_CurrentRockCacheGuid;

	private bool m_NoteTakingStart;

	public List<SkillListItem> m_SkillsDisplayList;

	public GameObject m_SkillsScrollbar;

	public GameObject m_SkillsSectionObject;

	public GameObject m_SkillBenefitPrefab;

	public GameObject m_SkillBenefitsStartDummy;

	public int m_SkillBenefitLabelOffsetY;

	public int m_SkillBenefitSpacingY;

	public int m_DescriptionOffsetY;

	public ScrollList m_SkillsScrollList;

	public UITexture m_SkillImageLarge;

	public UILabel m_SkillName;

	public UILabel m_SkillLevelName;

	public UILabel m_SkillLevelIconLargeLabel;

	public UILabel m_SkillDescription;

	public UIButton m_SkillsButton;

	private const int MAX_SKILL_BENEFITS = 10;

	private List<GameObject> m_SkillBenefitLines;

	private int m_SkillListSelectedIndex;

	private int m_SkillListOffset;

	private bool m_SkillsAddressablesLoaded;

	public GameObject m_TrustSectionObject;

	public ScrollList m_TrustScrollList;

	public UITexture m_TrustImage;

	public UILabel m_TrustNameLabel;

	public UILabel m_TrustDescLabel;

	public UIButton m_TrustButton;

	public GameObject m_PeopleDescriptionSection;

	public GameObject m_PeopleTrustSection;

	public GameObject m_NoUnlocksSection;

	public GameObject m_HasUnlocksSection;

	public UILabel m_PeopleDescTrustValLabel;

	public UILabel m_PeopleTrustValLabel;

	public TrustListItemInfo[] m_TrustIDInfo;

	public GameObject m_NeedsHeadersObject;

	public UILabel m_NoNeedsLabel;

	public UILabel[] m_NeedsListNameLabels;

	public UILabel[] m_NeedsListTrustLabels;

	public TrustMapEntry[] m_TrustMapEntries;

	public UILabel m_TrustUnlockNameLabel;

	public UILabel m_TrustUnlockValueLabel;

	public UILabel m_TrustUnlockDescLabel;

	public Color m_TrustMapReqLockedColor;

	public Color m_TrustMapReqUnlockedColor;

	public int m_TrustGridNumColumns;

	private List<CollectionListItem> m_TrustList;

	private int m_TrustListSelectedIndex;

	private bool m_PeopleScreenTrustToggle;

	private int m_TrustMapSelectedIndex;

	private List<CollectionListItemInfo> m_TrustDataList;

	private NPC_NeedTracker m_CurrNeedTracker;

	private NPC_UnlockableTracker m_CurrUnlockableTracker;

	private bool m_TrustAddressablesLoaded;

	public GameObject m_WhatIKnowSectionObject;

	public ScrollList m_WhatIKnowScrollList;

	public UITexture m_WhatIKnowImage;

	public UILabel m_WhatIKnowNameLabel;

	public UILabel m_WhatIKnowDescLabel;

	public UIButton m_WhatIKnowButton;

	public GameObject m_SelectSubScreenButton;

	public GameObject m_SelectScreenOnly;

	public GameObject m_SubScreenOnly;

	public UILabel m_SubscreenHeaderLabel;

	public GameObject m_ScrollbarWhatIKnow;

	public GameObject m_ScrollbarWhatIKnowDesc;

	public UIPanel m_WhatIKnowDescPanel;

	public int m_TotalNumKnowledgePeople;

	public int m_TotalNumKnowledgePlaces;

	public int m_TotalNumKnowledgeThings;

	public int m_TotalNumKnowledgeActions;

	public string m_PeopleSpriteNameSmall;

	public string m_PeopleSpriteNameBig;

	public string m_PlacesSpriteNameSmall;

	public string m_PlacesSpriteNameBig;

	public string m_ThingsSpriteNameSmall;

	public string m_ThingsSpriteNameBig;

	public string m_ActionsSpriteNameSmall;

	public string m_ActionsSpriteNameBig;

	private WhatIKnowType m_WhatIKnowCurrType;

	private List<CollectionListItem> m_WhatIKnowList;

	private int m_WhatIKnowListSelectedIndex;

	private float m_WhatIKnowDescPanelHeight;

	private List<CollectionListItemInfo> m_WhatIKnowDataList;

	private List<string> m_ListKnowledgeUnlockedPeople;

	private List<string> m_ListKnowledgeUnlockedPlaces;

	private List<string> m_ListKnowledgeUnlockedThings;

	private List<string> m_ListKnowledgeUnlockedActions;

	private bool m_WasQuickSelectActivated;

	private List<NotificationFlagInfo> m_KnowledgeNewEntry;

	private Dictionary<string, bool> m_subCategories;

	private bool m_WhatIKnowAddressablesLoaded;

	private int TotalNumPostcardCollectibles
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	private int TotalNumMementoCollectibles
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public event Action<string, NotificationFlagInfo> m_ItemSelected
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		remove
		{
		}
	}

	[Calls(Type = typeof(Panel_Log), Member = "InstantiateLogGridItems")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Panel_Log), Member = "CacheComponents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Log), Member = "InitializeGameplayTagLookups")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[Calls(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectionListItemsColor")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForKnowledgeSubCategories")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewCollectionEntry")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewKnowledgeEntry")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenActionsPanelPressed")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	private void FixedUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsUnknownMethods(Count = 3)]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "BuildStatsView")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSelectedSandboxRecord")]
	[Calls(Type = typeof(Panel_Log), Member = "SetUpTopNav")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCurrentGameLabel")]
	[Calls(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "MaybeForceGC")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(Panel_Log), Member = "CleanupSelectedSandboxRecord")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_WhatIKnow")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Trust")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Skills")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Collections")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Disable()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnJournalNav")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnMissionNav")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnJournalNav")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnMissionsNav")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnJournalNav")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnMissionsNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnMissionsNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnJournalNav")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnMissionsNav")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalAction")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnJournalNav")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnMissionsNav")]
	[Calls(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnLog")]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(Utils), Member = "GetTitleString")]
	[Calls(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnJournalNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "HasEnableFromRadialOverride")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void EnableFromRadial(PanelLogState state)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "SetRegionAndRockCacheSelected")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	public void EnableRockCacheStateFromMap(string sceneName, string rockCacheCustomName)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnSkillsButton")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnRockCachesButton")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnCollectibleButton")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnStatsButton")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnDailyLogButton")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void EnableFromMissionsStory(PanelLogState state)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalActionFromMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "NavigateToMissionById")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	public void EnableFromMap(string missionId)
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalActionFromObjective")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "NavigateToMissionById")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	public void EnableFromObjective(string missionId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	public void EnableDailyView()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnLog")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	public void EnableStatsView()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "BeginFadeIn")]
	[Calls(Type = typeof(Panel_Log), Member = "CreateSandboxRecord")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[Calls(Type = typeof(Log), Member = "LockInTodaysValues")]
	public void EnableDeathView()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsAlmanac")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsMissions")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnCancel")]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyBack")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "OnQuitToMainMenu")]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "QuitToMainMenuOnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "OnMapNav")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "UncacheSandboxRecord")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	public void OnBack()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "DeselectLogGridItems")]
	public void LogGridItemCallback(int entryNum)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogGridItemCallback")]
	[CalledBy(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveSelectedSpriteAndTween")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectionsPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveSelectedSpriteAndTween")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void LogListItemCallback(int indexClicked)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	public void OnWriteButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	public void OnStatus()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnInventory()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	public void OnScrollbarDaysUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarDaysDown()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnScrollbarDaysChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DetailedStatsView), Member = "OnScrollBarPositionChanged")]
	[CallsUnknownMethods(Count = 1)]
	public void OnScrollbarStatsChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DetailedStatsView), Member = "ScrollUp")]
	[CallsUnknownMethods(Count = 1)]
	public void OnScrollbarStatsUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DetailedStatsView), Member = "ScrollDown")]
	[CallsUnknownMethods(Count = 1)]
	public void OnScrollbarStatsDown()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	public void OnScrollbarCollectiblesUp()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarCollectiblesDown()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	public void OnScrollbarCollectiblesChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateStatsSlider")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	public void OnScrollbarDayStatsUp()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateStatsSlider")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	public void OnScrollbarDayStatsDown()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateStatsSlider")]
	[CallerCount(Count = 0)]
	public void OnScrollbarStatsDaysChange()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarNotesUp()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	public void OnScrollbarNotesDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesSlider")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnScrollbarNotesChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	public void OnScrollbarExamineCollectibleUp()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	public void OnScrollbarExamineCollectibleDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateExamineCollectibleSlider")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnScrollbarExamineCollectibleChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnEnterGeneralNotes()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnShowDayStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnEnterNoteTaking")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[CallerCount(Count = 3)]
	public void NotesToggle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "NotesToggle")]
	public void OnEnterNoteTaking()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "NotesToggle")]
	public void OnShowDayStats()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnWriteButton")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Log), Member = "CanEditJournal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	public void NoteTakingStart()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void OnReadText()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnDailyLogButton()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	public void OnStatsButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnCollectibleButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnRockCachesButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnCartographyButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnExamineCollectible()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	public void OnInventoryNav()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void OnClothingNav()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CallsUnknownMethods(Count = 1)]
	public void OnCraftingNav()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnFirstAidNav()
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	public void OnMapNav()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	public void OnJournalNav()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	public void OnMissionsNav()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "ShowPanelLogMainCategoryNotificationIcon")]
	[Calls(Type = typeof(Panel_Log), Member = "AddNotificationToKnowledgeSubCategory")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void HandleOnNotificationAdded(NotificationFlagInfo nfi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "RemoveNotificationFromKnowledgeSubCategory")]
	public void HandleOnSubcategoryNotificationRemoved(NotificationFlagInfo nfi)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void HandleOnMainCategoryNotificationRemoved(NotificationFlagInfo nfi)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleOnNotificationAdded")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	public void ShowPanelLogMainCategoryNotificationIcon(MainCategory mainCategory, bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[CalledBy(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetWhatIKnowListSelectedToEntry")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustListSelectionScroll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectionListSelectionScroll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListSelectionScroll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromObjective")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMissionsStory")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableRockCacheStateFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallerCount(Count = 15)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDailyView")]
	private void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ExitInterfaceOnDeath()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReallyQuitToMainMenu")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ForceQuit")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Extras), Member = "ShouldShowExtras")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnQuitToMainMenu")]
	private void ExitInterface()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void OnQuitToMainMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	public void ForceQuit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	public void ReallyQuitToMainMenu()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsInSectionNav()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[CallsUnknownMethods(Count = 2)]
	private bool QuitToMainMenuOnBack()
	{
		return default(bool);
	}

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(Panel_Log), Member = "QuitToMainMenuOnBack")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private string GetOnBackText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void SelectSandbox(int index)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildSkillsList")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateAlmanacPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildTrustList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildRockCacheRegionScrollList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateExamineCollectible")]
	[CallerCount(Count = 43)]
	[CallsDeduplicatedMethods(Count = 21)]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Collections")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Skills")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Trust")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_WhatIKnow")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableAllLBRBButtons")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void EnterState(PanelLogState newState)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ResetNotificationsData()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_Log), Member = "ClearGrid")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateStatsSlider")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "NotesToggle")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Log), Member = "GetInfoForDay")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	private void UpdateDailyStatsPage()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarStatsDaysChange")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsDown")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsUp")]
	private void UpdateStatsSlider()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesSlider")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Log), Member = "CanEditJournal")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Log), Member = "GetInfoForDay")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateNotesPage()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarExamineCollectibleChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateExamineCollectible")]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateExamineCollectibleSlider()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarNotesChange")]
	private void UpdateNotesSlider()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesSlider")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(UILabel), Member = "get_printedSize")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesSlider")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesDown")]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(TextInputField), Member = "GetCursorLocation")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Input), Member = "GetMouseButton")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(Log), Member = "EnterNotesForDay")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	private void CheckForNotesChange()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnCollectionsSubScreen")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectionsPage")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Panel_Log), Member = "SetCollectionSubscreenNameLabel")]
	[Calls(Type = typeof(GearItem), Member = "get_Description")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateCollectibleList()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateExamineCollectibleSlider")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	private void UpdateExamineCollectible()
	{
	}

	[Calls(Type = typeof(SummaryStatsView), Member = "AddRandomStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddRandomStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddRandomStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddRandomStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "Populate")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddRandomStat")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DetailedStatsView), Member = "Start")]
	[CalledBy(Type = typeof(Panel_Log_Toc_GridItem), Member = "OnClick")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	private void BuildStatsView()
	{
	}

	[Calls(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarDaysChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CalledBy(Type = typeof(Panel_Log_Toc_GridItem), Member = "OnClick")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[Calls(Type = typeof(LogGridItem), Member = "SetupAsDayEntry")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Log), Member = "GetInfoForDay")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	private void BuildDailyList(bool doSelectionReset)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(LogGridItem), Member = "SetupAsCollectibleEntry")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnCollectionsSubScreen")]
	[CallsUnknownMethods(Count = 153)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(LogGridItem), Member = "HideAll")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectionsList")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(LogGridItem), Member = "HideAll")]
	[Calls(Type = typeof(LogGridItem), Member = "SetupAsCollectionEntry")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(LogGridItem), Member = "SetupAsCollectionEntry")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(NarrativeCollectibleItem), Member = "IsMementoItem")]
	private void BuildCollectibleList(bool doSelectionReset)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	private void ClearGrid(UIGrid gridToClear)
	{
	}

	[CallerCount(Count = 0)]
	private bool ShouldShowNotes()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanEditJournal()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	private bool CanSaveJournal()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListSelectionScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	private void ScrollListMovement(int moveVal)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	private void DoScrollListScrollLeft()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsUp")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesDown")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[CallerCount(Count = 2)]
	private void DoScrollListScrolLRight()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	private void DoControlsCollectibleList()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "CanEditJournal")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "NotesToggle")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	[Calls(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "CanEditJournal")]
	[Calls(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	private void DoControlsDailyListStats()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStats")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(DetailedStatsView), Member = "ScrollUp")]
	[Calls(Type = typeof(DetailedStatsView), Member = "ScrollDown")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	private void DoControlsStats()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStats")]
	[CallsUnknownMethods(Count = 1)]
	public void OnResetAllTimeStats()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarExamineCollectibleUp")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarExamineCollectibleDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarExamineCollectibleUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarExamineCollectibleDown")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void DoControlsExamineCollectible()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveSectionNavToButton")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveSectionNavToButton")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshActivePanelStates")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 1)]
	private void DoSectionNavControls()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetUpTopNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	private void RefreshActivePanelStates()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallsUnknownMethods(Count = 8)]
	private void DisableAllMouseButtons()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsMissions")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[Calls(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[Calls(Type = typeof(Panel_Log), Member = "DisableAllMouseButtons")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void DoControls()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDaysUp")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDaysDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsDown")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesUp")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesUp")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsUp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void DoMouseScrollControls()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateNavigationButtons()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	private void BeginFadeIn()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnFinalScreenShown()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Log), Member = "ToggleButtonColliders")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ToggleButtonColliders")]
	[CallsUnknownMethods(Count = 3)]
	private void ToggleButtonColliders(Transform transform, bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshActivePanelStates")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	private void SetUpTopNav()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateCurrentGameLabel()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	private void UpdateScrollbarThumbSize()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	private void UpdateScrollbarThumbSizeIndividual(UISlider slider, int numVisible, int total)
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableNavigationTabs")]
	[Calls(Type = typeof(Panel_Log), Member = "OnCraftingNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "OnMapNav")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableNavigationTabs")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	private void DoMainNavControls()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 0)]
	private bool ShouldRenderOverOtherScreens()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTocViewOverwriteButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTocViewButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	private void ActivateBackButton()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Initialize")]
	[CallsUnknownMethods(Count = 4)]
	private void InstantiateLogGridItems()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	private void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromObjective")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	private bool ShouldEnterSectionNav()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void MoveSectionNavToButton(PanelLogState buttonState)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDaysUp")]
	[Calls(Type = typeof(LogGridItem), Member = "SetSelected")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "DeselectLogGridItems")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDaysDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesDown")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	private void MoveGridSelection(int horizontal, int vertical)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	private int GetNumGridItemsShowing()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetNumGridItemsShowing")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogGridItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogGridItemCallback")]
	[CalledBy(Type = typeof(LogGridItem), Member = "SetSelected")]
	[CalledBy(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	private int GetTotalNumGridItems()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarDaysChange")]
	[Calls(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "DeselectLogGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	private void SetLogGridItemIndex(int index)
	{
	}

	[CallerCount(Count = 0)]
	private int GetCollectibleListTrueIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	private bool StateIsShowing(PanelLogState state)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSectionNavButtonColors()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void DoSectionNavUpdate()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromObjective")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableAllLBRBButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectionListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshActivePanelStates")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveSectionNavToButton")]
	[Calls(Type = typeof(Panel_Log), Member = "DeselectLogGridItems")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	private void EnterSectionNav()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogGridItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(LogGridItem), Member = "SetSelected")]
	private void DeselectLogGridItems()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "EnableSpriteIfActionIs")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "EnableSpriteIfActionIs")]
	private void EnableAllLBRBButtons(bool shouldEnable)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Log), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "SetActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "SetActive")]
	private void SetActiveTab(NavigationTabState state)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	private void SetActive(GameObject go, bool enable)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	private void CacheComponents()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_WhatIKnow")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Trust")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Collections")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Skills")]
	private void ReleaseTempResources()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	private bool HasEnableFromRadialOverride(out PanelLogState overrideState)
	{
		System.Runtime.CompilerServices.Unsafe.As<PanelLogState, @null>(ref overrideState) = null;
		return default(bool);
	}

	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void MaybeRemoveJournalState(GameModeConfig gameMode, PanelLogState state)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Initialize")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void InitializeGameplayTagLookups()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(DateTime), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRenameSandboxConfirmed")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "GetSurvivalRecordSummaryText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSelectedSandboxRecord")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	private void UpdateTOCSelection()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "CleanupSelectedSandboxRecord")]
	private void UpdateSelectedSandboxRecord()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSelectedSandboxRecord")]
	private void CleanupSelectedSandboxRecord()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(Panel_Log_Toc_GridItem), Member = "OnClick")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	[Calls(Type = typeof(StatContainer), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 4)]
	private void UncacheSandboxRecord(SandboxRecordData record)
	{
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetTimeSurvivedString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ZoneSpecification), Member = "get_ZoneName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "ColorToHex")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string GetSurvivalRecordSummaryText(SandboxRecordData record, Color boldColor)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "UncacheSandboxRecord")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildStatsView")]
	public void ViewSandbox()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	public void OnDeleteSandbox()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDeleteSandboxConfirmed()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public void OnRenameSandbox()
	{
	}

	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	public void OnRenameSandboxConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsUnknownMethods(Count = 2)]
	public void OnRenameSandboxCancelled(bool wasCancelled)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "ReallySaveJournal")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CallsUnknownMethods(Count = 6)]
	public void OnOverwriteSandbox()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "ReallySaveJournal")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnOverwriteSandboxConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsUnknownMethods(Count = 6)]
	private void OnSandboxLimitNotification()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[CallerCount(Count = 0)]
	private void OnSandboxLimitNotificationConfirmed()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	public void OnSaveJournal()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnOverwriteSandbox")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnOverwriteSandboxConfirmed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	private void ReallySaveJournal()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Log), Member = "CreateLogObject")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	public void EnableTableOfContentsView()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableTableOfContentsView")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	private void CreateLogObject()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void UpdateTocViewButtons()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[Calls(Type = typeof(Panel_Log), Member = "OnDeleteSandbox")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRenameSandbox")]
	[Calls(Type = typeof(InputManager), Member = "GetDeletePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewButtons")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetRenamePressed")]
	private void DoControlsTOCView()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	private void UpdateTocViewSelection()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRenameSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewButtons")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewOverwriteButtons")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void BuildTOCList()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnTocScrollbarChange()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTocViewSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableTableOfContentsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSandboxLimitNotificationConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSandboxLimitNotification")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(Panel_Log_Toc_GridItem), Member = "Update")]
	[Calls(Type = typeof(Panel_Log_Toc_GridItem), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public void OnTocItemClicked(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void UpdateTocViewOverwriteButtons()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildStatsView")]
	[Calls(Type = typeof(Panel_Log), Member = "UncacheSandboxRecord")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRenameSandbox")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewOverwriteButtons")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "OnOverwriteSandbox")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewSelection")]
	[Calls(Type = typeof(InputManager), Member = "GetRenamePressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	private void DoControlsTOCViewOverwrite()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "StoreNoteCollectiblesInRecord")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[Calls(Type = typeof(StatContainer), Member = ".ctor")]
	[Calls(Type = typeof(Panel_Log), Member = "StoreAuroraScreenCollectiblesInRecord")]
	[Calls(Type = typeof(Panel_Log), Member = "StoreCairnCollectiblesInRecord")]
	[Calls(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUserDefinedSlotName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private SandboxRecordData CreateSandboxRecord()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Log), Member = "CreateSandboxRecord")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void StoreNoteCollectiblesInRecord(SandboxRecordData record)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CreateSandboxRecord")]
	[CallsUnknownMethods(Count = 34)]
	private void StoreCairnCollectiblesInRecord(SandboxRecordData record)
	{
	}

	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(Panel_Log), Member = "CreateSandboxRecord")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void StoreAuroraScreenCollectiblesInRecord(SandboxRecordData record)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(AlmanacGridItem), Member = "ShowFalseBlizzard")]
	[Calls(Type = typeof(AlmanacGridItem), Member = "SetUpGridItem")]
	[Calls(Type = typeof(int), Member = "Parse")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(Panel_Log), Member = "InstantiateGridItems")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	private void UpdateAlmanacPage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnAlmanacButton()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	public void DoControlsAlmanac()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateAlmanacPage")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	private void InstantiateGridItems()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SurveyRegionListItem), Member = "SetRegionInfo")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public Texture GetRegionButtonTexture(string sceneName)
	{
		return null;
	}

	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnForceRevealHiddenDetailsToggle")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetRegionInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetSelected")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "Clear")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	public void UpdateCartographyPage()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyScrollbar")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyScrollbar")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyAchievementScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyRegionScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyRegionClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetAchievementInfo")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetRegionInfo")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void RefreshAchievementListForSelectedRegion(bool newRegion)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetSelected")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[CallerCount(Count = 2)]
	protected void OnSurveyRegionClicked(int index)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyRegionClicked")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSurveyScrollbar")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyClicked")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenMapPressed")]
	public void DoControlsCartography()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnForceRevealHiddenDetailsToggle()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	private void OnSurveyBack()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	protected void OnSurveyClicked(int index)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnSurveyRegionScrollbarChange()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 3)]
	public void OnSurveyAchievementScrollbarChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	public void HandleSurveyScrollbar(float amount)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyClicked")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSurveyScrollbar")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyRegionClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSurveyScrollbar")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyClicked")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CallsUnknownMethods(Count = 2)]
	private void HandleSurveyVerticalNavigation(float amount)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 189)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateCollectionSelectScreenDummyData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRegionUnlocked")]
	[Calls(Type = typeof(Panel_Map), Member = "GetLocIdsOfUnlockedMapElements")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 42)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(SurveyRegionInfo), Member = ".ctor")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	private void BuildCartographyRegionList()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Collections")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "SetCollectionSubscreenNameLabel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void UpdateCollectionsPage()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReleaseTempResources")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectionsPage")]
	[CallsUnknownMethods(Count = 1)]
	private void ReleaseTempResources_Collections()
	{
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void OnCollectiblesTab()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public void OnCollectionsTab()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void DoCollectionsToggle()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "SetCollectionSubscreenNameLabel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	public void DoControlsCollectionList()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Log), Member = "SetCollectionSubscreenNameLabel")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	public void OnCollectionsSubScreen()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "GenerateCollectionSelectScreenDummyData")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateAvailablePostCards")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateAvailableMementos")]
	private void BuildCollectionsList()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AssetLabelReference), Member = "RuntimeKeyIsValid")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectionsList")]
	[CallsUnknownMethods(Count = 16)]
	private void UpdateAvailablePostCards()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectionsList")]
	[Calls(Type = typeof(NarrativeCollectibleItem), Member = "IsMementoItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AssetLabelReference), Member = "RuntimeKeyIsValid")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void UpdateAvailableMementos()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void AddEntryToList(int scrollIndex, CollectionListItemInfo itemInfo)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	private void UpdateCollectionListSelectionScroll(int moveVal, ref int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetSelected")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void UpdateCollectionListItemsColor()
	{
	}

	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsUnknownMethods(Count = 53)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectionsList")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshCollectibleCounters")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	private void GenerateCollectionSelectScreenDummyData(List<CollectionListItemInfo> dummyDataList)
	{
	}

	[CallerCount(Count = 0)]
	private bool IsInCollectionsSelectScreen()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnCollectionsSubScreen")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectionsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 4)]
	private void SetCollectionSubscreenNameLabel()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateCollectionSelectScreenDummyData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(NarrativeCollectibleItem), Member = "IsMementoItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void RefreshCollectibleCounters()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewCollectionEntry")]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveNewCollectionEntry(NotificationFlagInfo nfi)
	{
	}

	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(Panel_Log), Member = "RemoveNewCollectionEntry")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeShowNotificationFlagForNewCollectionEntry()
	{
	}

	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Log), Member = "SetChallengeTextureAsync")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionInfoFromPrefab")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ChallengeChecklistEntry), Member = "UpdateEntry")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ChallengeChecklistEntry), Member = "UpdateEntry")]
	private void UpdateMissionsPage()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetChallengeTexture")]
	private void SetChallengeTextureAsync(ChallengeConfig challengeConfig)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_ChallengeNowhereToHideRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionInfoFromPrefab")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void UpdateMissionInfo(string name, string description, string[] checklistKeys, string[] checklistValues, bool[] checklistBools)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveMission(string name)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void ClearMissions()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnMissionsButton()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void DoControlsMissions()
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshObjectivesToShow")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetTrackedMission")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateMissionInfoFromPrefab()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[Calls(Type = typeof(RockCacheListItem), Member = "Clear")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(RockCacheListItem), Member = "Clear")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateRockCacheScreenData")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	private void BuildRockCacheRegionScrollList()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableRockCacheStateFromMap")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheRegionClicked")]
	private void SetRegionAndRockCacheSelected(string sceneName, string rockCacheName)
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "MapElementExists")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRegionClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleScrollbar")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleScrollbar")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRenameRockCacheConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheItemScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRegionScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildRockCacheRegionScrollList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRegionUnlocked")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheNameFromGuid")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheUserTextFromGuid")]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetItemInfo")]
	private void RefreshRockCacheListForSelectedRegion(bool newRegion)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private int GetNumberOfRockCachesInCurrentRegion()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 3)]
	public void OnRockCacheRegionScrollbarChange()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnRockCacheItemScrollbarChange()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheNameFromGuid")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetupInputField")]
	public void OnRockCacheRenameButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void OnRenameRockCacheConfirmed()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallerCount(Count = 0)]
	public void OnRockCacheEditNoteClicked()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateRockCacheNoteSlider")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CallsUnknownMethods(Count = 4)]
	public void OnRockCacheNoteScrollbarUp()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateRockCacheNoteSlider")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	public void OnRockCacheNoteScrollbarDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateRockCacheNoteSlider")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnRockCacheNoteScrollbarChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarChange")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarDown")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarUp")]
	private void UpdateRockCacheNoteSlider()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheEditNoteClicked")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheUserTextFromGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	public void RockCacheNoteTakingStart()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheBack")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheUserText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void MaybeUpdateNote()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarDown")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeUpdateNote")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeUpdateNote")]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarUp")]
	[Calls(Type = typeof(TextInputField), Member = "GetCursorLocation")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UILabel), Member = "get_printedSize")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheUserText")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheUserTextFromGuid")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarDown")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateRockCacheNoteSlider")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public void MaybeUpdateRockCacheNoteView()
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheRegionClicked")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheBack")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleScrollbar")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheRenameButton")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenMapPressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void DoControlsRockCaches()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeUpdateNote")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	private void OnRockCacheBack()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	public void HandleScrollbar(float amount)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleScrollbar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheRegionClicked")]
	private void HandleVerticalNavigation(float amount)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "SetRegionAndRockCacheSelected")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	protected void OnRockCacheRegionClicked(int index)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetRegionAndRockCacheSelected")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheUserTextFromGuid")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheNameFromGuid")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	protected void OnRockCacheItemClicked(int index)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRegionUnlocked")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "CenterOnPoint")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[Calls(Type = typeof(Panel_Map), Member = "ForceZoomIn")]
	[Calls(Type = typeof(Panel_Log), Member = "OnMapNav")]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	public void OnRockCacheShowOnMapClicked()
	{
	}

	[CallsUnknownMethods(Count = 66)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildRockCacheRegionScrollList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRegionUnlocked")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void GenerateRockCacheScreenData()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	private void UpdateSkillsPage()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "ReleaseTempResources")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	private void ReleaseTempResources_Skills()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnSkillsButton()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSkillScrollbar")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	public void DoControlsSkillsListStats()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSkillScrollbar")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	private void HandleSkillVerticalNavigation(float amount)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	[CallsUnknownMethods(Count = 3)]
	private void HandleSkillScrollbar(float amount)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	public void OnScrollbarSkillsChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	protected void OnSkillItemClicked(int index)
	{
	}

	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Skill), Member = "GetProgressToNextLevelAsNormalizedValue")]
	[Calls(Type = typeof(SkillListItem), Member = "SetProgress")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSkillsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarSkillsChange")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkillFromIndex")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Skill), Member = "GetTierPoints")]
	[Calls(Type = typeof(SkillListItem), Member = "SetSkillLevel")]
	private void RefreshSkillsList()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillScrollbar")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSkillsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarSkillsChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSkillItemClicked")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Skills")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void RefreshSelectedSkillDescriptionView()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	private void BuildSkillsList()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSkillsPage")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarSkillsChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	private void UpdateSkillListItemsColor()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "SetupNeedsInfo")]
	[Calls(Type = typeof(Panel_Log), Member = "SetupTrustMap")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoPeopleTabToggle")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Trust")]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateTrustPage()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReleaseTempResources")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[CallsUnknownMethods(Count = 1)]
	private void ReleaseTempResources_Trust()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshTrustMapSelection")]
	[CalledBy(Type = typeof(TrustMapEntry), Member = "TrustMapClicked")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnTrustMapClicked(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnTrustButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "DoPeopleTabToggle")]
	public void OnPeopleDescriptionTab()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "DoPeopleTabToggle")]
	[CallerCount(Count = 0)]
	public void OnPeopleTrustTab()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnPeopleTrustTab")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnPeopleDescriptionTab")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void DoPeopleTabToggle()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTrustMapClicked")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontalRightStick")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(Panel_Log), Member = "DoPeopleTabToggle")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	public void DoControlsTrustList()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateTrustListData")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	private void BuildTrustList()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	private void AddTrustEntryToList(int scrollIndex, CollectionListItemInfo itemInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateTrustListSelectionScroll(int moveVal, ref int index)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetSelected")]
	private void UpdateTrustListItemsColor()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildTrustList")]
	private void GenerateTrustListData()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	private string GetTrustIDFromNameID(string nameLocID)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(TrustManager), Member = "GetNeedTracker")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "GetStringForNeed")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "IsTrustWithinNeedRange")]
	private void SetupNeedsInfo(string trustID)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetupNeedsInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetGearDisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetGearDisplayName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString")]
	public string GetStringForNeed(NeedPrefabSaveData needData)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetupNeedsInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	private bool IsTrustWithinNeedRange(NeedPrefabSaveData needData, string trustID)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshTrustMapSelection")]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(TrustManager), Member = "GetUnlockableTracker")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	private void SetupTrustMap(string trustID)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetupTrustMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnTrustMapClicked")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void RefreshTrustMapSelection()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[CallsUnknownMethods(Count = 2)]
	private void DeselectAllTrustMapEntries()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnWhatIKnowSubScreen")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowDescScrollbar")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_WhatIKnow")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	private void UpdateWhatIKnowPage()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReleaseTempResources")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[CallsUnknownMethods(Count = 1)]
	private void ReleaseTempResources_WhatIKnow()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnWhatIKnowButton()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarWhatIKnowDescUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarWhatIKnowDescDown")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void DoControlsWhatIKnowList()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	private void SetWhatIKnowListSelectedToEntry(string nameLocID)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsUnknownMethods(Count = 2)]
	private void PointToWhatIKnowEntryOnQuickKeyActive(KnowledgeCateogry category, string nameLocID)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	public void OnWhatIKnowSubScreen()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnWhatIKnowScrollbarChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowDescScrollbar")]
	[CallsUnknownMethods(Count = 2)]
	public void OnScrollbarWhatIKnowDescUp()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowDescScrollbar")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	public void OnScrollbarWhatIKnowDescDown()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowDescScrollbar")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnWhatIKnowDescScrollbarChange()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "AddNotificationToKnowledgeSubCategory")]
	[Calls(Type = typeof(Panel_Log), Member = "RemoveNotificationFromKnowledgeSubCategory")]
	[CallerCount(Count = 0)]
	public void ShowPanelLogSubCategoryNotificationIcon(SubCategory subCategory, bool enable)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarWhatIKnowDescUp")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarWhatIKnowDescDown")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnWhatIKnowDescScrollbarChange")]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateWhatIKnowDescScrollbar()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnWhatIKnowSubScreen")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateSelectScreenData")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateSubscreenData")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateSubscreenData")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateSubscreenData")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateSubscreenData")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void BuildWhatIKnowList()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void AddWhatIKnowEntryToList(int scrollIndex, CollectionListItemInfo itemInfo)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	private void UpdateWhatIKnowListSelectionScroll(int moveVal, ref int index)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void UpdateWhatIKnowListItemsColor()
	{
	}

	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString")]
	private void GenerateSelectScreenData()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetNameIDFromDescID")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void GenerateSubscreenData(List<string> knowledgeList)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildTrustList")]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetListUnlockedKnowledgeOfType")]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetListUnlockedKnowledgeOfType")]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetListUnlockedKnowledgeOfType")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetListUnlockedKnowledgeOfType")]
	private void RefreshCachedKnowledgeUnlocks()
	{
	}

	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(Panel_Log), Member = "RemoveNewKnowledgeEntry")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void MaybeShowNotificationFlagForNewKnowledgeEntry()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallsUnknownMethods(Count = 19)]
	private void MaybeShowNotificationFlagForKnowledgeSubCategories()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewKnowledgeEntry")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void RemoveNewKnowledgeEntry(NotificationFlagInfo nfi)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleOnNotificationAdded")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ShowPanelLogSubCategoryNotificationIcon")]
	[CallsUnknownMethods(Count = 1)]
	private void AddNotificationToKnowledgeSubCategory(string descId)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleOnSubcategoryNotificationRemoved")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ShowPanelLogSubCategoryNotificationIcon")]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveNotificationFromKnowledgeSubCategory(string descId)
	{
	}

	[CallsUnknownMethods(Count = 157)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 28)]
	public Panel_Log()
	{
	}
}
