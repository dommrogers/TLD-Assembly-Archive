using System;
using System.Collections.Generic;
using System.Linq;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

		public static Comparison<RegionInfo> _003C_003E9__555_0;

		public static Comparison<RegionInfo> _003C_003E9__555_1;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCollectibleList_003Eb__253_0(CairnInfo x, CairnInfo y)
		{
			return default(int);
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal int _003CBuildCollectibleList_003Eb__253_1(AuroraScreenInfo x, AuroraScreenInfo y)
		{
			return default(int);
		}

		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal int _003CStoreCairnCollectiblesInRecord_003Eb__339_0(CairnInfo x, CairnInfo y)
		{
			return default(int);
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal int _003CStoreAuroraScreenCollectiblesInRecord_003Eb__340_0(AuroraScreenInfo x, AuroraScreenInfo y)
		{
			return default(int);
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal int _003CBuildCartographyRegionList_003Eb__389_3(SurveyAchievementInfo a, SurveyAchievementInfo b)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCartographyRegionList_003Eb__389_4(SurveyAchievementInfo a, SurveyAchievementInfo b)
		{
			return default(int);
		}

		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCartographyRegionList_003Eb__389_2(SurveyRegionInfo a, SurveyRegionInfo b)
		{
			return default(int);
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal int _003CGenerateRockCacheScreenData_003Eb__555_0(RegionInfo a, RegionInfo b)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CGenerateRockCacheScreenData_003Eb__555_1(RegionInfo a, RegionInfo b)
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
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
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
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Calls(Type = typeof(Panel_Log), Member = "CacheComponents")]
	[Calls(Type = typeof(Panel_Log), Member = "InstantiateLogGridItems")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "InitializeGameplayTagLookups")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectionListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[Calls(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustListItemsColor")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewKnowledgeEntry")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForKnowledgeSubCategories")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewCollectionEntry")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenActionsPanelPressed")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
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

	[Calls(Type = typeof(DetailedStatsView), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSelectedSandboxRecord")]
	[Calls(Type = typeof(Panel_Log), Member = "SetUpTopNav")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "MaybeForceGC")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(SummaryStatsView), Member = "Start")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(Panel_Log), Member = "CleanupSelectedSandboxRecord")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_WhatIKnow")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Trust")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Skills")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Collections")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	public override void Enable(bool enable)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Disable()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnMissionNav")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnJournalNav")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnMissionsNav")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnJournalNav")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnMissionsNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnJournalNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnJournalNav")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalAction")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnMissionsNav")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnJournalNav")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnMissionsNav")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnJournalNav")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnMissionsNav")]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[Calls(Type = typeof(Panel_Log), Member = "HasEnableFromRadialOverride")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Utils), Member = "GetTitleString")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnLog")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void EnableFromRadial(PanelLogState state)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "SetRegionAndRockCacheSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void EnableRockCacheStateFromMap(string sceneName, string rockCacheCustomName)
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnCollectibleButton")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnSkillsButton")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnRockCachesButton")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnDailyLogButton")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnStatsButton")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	public void EnableFromMissionsStory(PanelLogState state)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "NavigateToMissionById")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallsUnknownMethods(Count = 1)]
	public void EnableFromMap(string missionId)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "NavigateToMissionById")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	public void EnableFromObjective(string missionId)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void EnableDailyView()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnLog")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void EnableStatsView()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Log), Member = "LockInTodaysValues")]
	[Calls(Type = typeof(Panel_Log), Member = "CreateSandboxRecord")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	[Calls(Type = typeof(Panel_Log), Member = "BeginFadeIn")]
	[CallsUnknownMethods(Count = 1)]
	public void EnableDeathView()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "UncacheSandboxRecord")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(Panel_Log), Member = "OnMapNav")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "QuitToMainMenuOnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	public void OnBack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "DeselectLogGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	public void LogGridItemCallback(int entryNum)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogGridItemCallback")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[CalledBy(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectionsPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveSelectedSpriteAndTween")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "MoveSelectedSpriteAndTween")]
	public void LogListItemCallback(int indexClicked)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	public void OnScrollbarDaysUp()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarDaysDown()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	public void OnScrollbarCollectiblesUp()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	public void OnScrollbarCollectiblesDown()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnScrollbarCollectiblesChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateStatsSlider")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	public void OnScrollbarDayStatsUp()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateStatsSlider")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	public void OnScrollbarDayStatsDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateStatsSlider")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnScrollbarStatsDaysChange()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	public void OnScrollbarNotesUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	public void OnScrollbarExamineCollectibleUp()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	public void OnScrollbarExamineCollectibleDown()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateExamineCollectibleSlider")]
	[CallerCount(Count = 0)]
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
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnEnterNoteTaking")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	public void NotesToggle()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "NotesToggle")]
	[CallerCount(Count = 0)]
	public void OnEnterNoteTaking()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "NotesToggle")]
	public void OnShowDayStats()
	{
	}

	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnWriteButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_Log), Member = "CanEditJournal")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnStatsButton()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnCollectibleButton()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
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
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
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

	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	public void OnMapNav()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnJournalNav()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnMissionsNav()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "AddNotificationToKnowledgeSubCategory")]
	[Calls(Type = typeof(Panel_Log), Member = "ShowPanelLogMainCategoryNotificationIcon")]
	[CallsUnknownMethods(Count = 4)]
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

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleOnNotificationAdded")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	public void ShowPanelLogMainCategoryNotificationIcon(MainCategory mainCategory, bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "SetWhatIKnowListSelectedToEntry")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectionListSelectionScroll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustListSelectionScroll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalActionFromMap")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalActionFromObjective")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListSelectionScroll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableRockCacheStateFromMap")]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromObjective")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMissionsStory")]
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
	[CalledBy(Type = typeof(Panel_Log), Member = "OnQuitToMainMenu")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ForceQuit")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(Panel_Extras), Member = "ShouldShowExtras")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	private void ExitInterface()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	public void OnQuitToMainMenu()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(Panel_Log), Member = "QuitToMainMenuOnBack")]
	private string GetOnBackText()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void SelectSandbox(int index)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildSkillsList")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildTrustList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildRockCacheRegionScrollList")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateAlmanacPage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableAllLBRBButtons")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Collections")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Trust")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_WhatIKnow")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Skills")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateExamineCollectible")]
	private void EnterState(PanelLogState newState)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void ResetNotificationsData()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "ClearGrid")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateStatsSlider")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "NotesToggle")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Log), Member = "GetInfoForDay")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void UpdateDailyStatsPage()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarStatsDaysChange")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsDown")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsUp")]
	private void UpdateStatsSlider()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 6)]
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
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "CanEditJournal")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[CallerCount(Count = 2)]
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

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesSlider")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(UILabel), Member = "get_printedSize")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesSlider")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(TextInputField), Member = "GetCursorLocation")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesUp")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesDown")]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[Calls(Type = typeof(Input), Member = "GetMouseButton")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(Log), Member = "EnterNotesForDay")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	private void CheckForNotesChange()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnCollectionsSubScreen")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
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
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateCollectibleList()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateExamineCollectibleSlider")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateExamineCollectible()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DetailedStatsView), Member = "Start")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SummaryStatsView), Member = "Start")]
	private void BuildStatsView()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarDaysChange")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(LogGridItem), Member = "SetupAsDayEntry")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Log), Member = "GetInfoForDay")]
	private void BuildDailyList(bool doSelectionReset)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NarrativeCollectibleItem), Member = "IsMementoItem")]
	[Calls(Type = typeof(LogGridItem), Member = "SetupAsCollectibleEntry")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnCollectionsSubScreen")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectionsList")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(LogGridItem), Member = "SetupAsCollectionEntry")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(LogGridItem), Member = "SetupAsCollectionEntry")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void BuildCollectibleList(bool doSelectionReset)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
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
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	private bool CanSaveJournal()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListSelectionScroll")]
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
	[Calls(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	private void DoScrollListScrollLeft()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsUp")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesUp")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesDown")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsDown")]
	private void DoScrollListScrolLRight()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDaysDown")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	private void DoControlsCollectibleList()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "NotesToggle")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[Calls(Type = typeof(Panel_Log), Member = "CanEditJournal")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "CanEditJournal")]
	private void DoControlsDailyListStats()
	{
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStatsConfirmed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	[Calls(Type = typeof(DetailedStatsView), Member = "ScrollDown")]
	[Calls(Type = typeof(DetailedStatsView), Member = "ScrollUp")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	private void DoControlsStats()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStatsConfirmed")]
	public void OnResetAllTimeStats()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarExamineCollectibleUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarExamineCollectibleDown")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarExamineCollectibleUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarExamineCollectibleDown")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void DoControlsExamineCollectible()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
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

	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetUpTopNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[CallsUnknownMethods(Count = 4)]
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
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsMissions")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[Calls(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[Calls(Type = typeof(Panel_Log), Member = "DisableAllMouseButtons")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
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
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsUp")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesUp")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void DoMouseScrollControls()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	private void UpdateNavigationButtons()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	private void BeginFadeIn()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnFinalScreenShown()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "ToggleButtonColliders")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Log), Member = "ToggleButtonColliders")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void ToggleButtonColliders(Transform transform, bool enabled)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshActivePanelStates")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CallsUnknownMethods(Count = 6)]
	private void SetUpTopNav()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	private void UpdateCurrentGameLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
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
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	private void UpdateScrollbarThumbSizeIndividual(UISlider slider, int numVisible, int total)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableNavigationTabs")]
	[Calls(Type = typeof(Panel_Log), Member = "OnCraftingNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnMapNav")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableNavigationTabs")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
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

	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromObjective")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	private bool ShouldEnterSectionNav()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[CallerCount(Count = 3)]
	[CallAnalysisFailed]
	private void MoveSectionNavToButton(PanelLogState buttonState)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDaysUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesUp")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesDown")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDaysDown")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "DeselectLogGridItems")]
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
	[CalledBy(Type = typeof(Panel_Log), Member = "GetNumGridItemsShowing")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogGridItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogGridItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(LogGridItem), Member = "SetSelected")]
	[CalledBy(Type = typeof(LogGridItem), Member = "SetSelected")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CallerCount(Count = 13)]
	private int GetTotalNumGridItems()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarDaysChange")]
	[Calls(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "DeselectLogGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[CallerCount(Count = 11)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[CallsUnknownMethods(Count = 4)]
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

	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalActionFromObjective")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalActionFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromObjective")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableAllLBRBButtons")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshActivePanelStates")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveSectionNavToButton")]
	[Calls(Type = typeof(Panel_Log), Member = "DeselectLogGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectionListItemsColor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	private void EnterSectionNav()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogGridItemCallback")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(LogGridItem), Member = "SetSelected")]
	private void DeselectLogGridItems()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "EnableSpriteIfActionIs")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "EnableSpriteIfActionIs")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallsUnknownMethods(Count = 2)]
	private void EnableAllLBRBButtons(bool shouldEnable)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "SetActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "SetActive")]
	private void SetActiveTab(NavigationTabState state)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 7)]
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

	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Trust")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Skills")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_WhatIKnow")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Collections")]
	private void ReleaseTempResources()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsUnknownMethods(Count = 4)]
	private bool HasEnableFromRadialOverride(out PanelLogState overrideState)
	{
		System.Runtime.CompilerServices.Unsafe.As<PanelLogState, @null>(ref overrideState) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeRemoveJournalState(GameModeConfig gameMode, PanelLogState state)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Initialize")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	private void InitializeGameplayTagLookups()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRenameSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[Calls(Type = typeof(DateTime), Member = "ToString")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSelectedSandboxRecord")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "GetSurvivalRecordSummaryText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 6)]
	private void UpdateTOCSelection()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "CleanupSelectedSandboxRecord")]
	private void UpdateSelectedSandboxRecord()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSelectedSandboxRecord")]
	private void CleanupSelectedSandboxRecord()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(StatContainer), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void UncacheSandboxRecord(SandboxRecordData record)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetTimeSurvivedString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ZoneSpecification), Member = "get_ZoneName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "ColorToHex")]
	[CallerCount(Count = 1)]
	private string GetSurvivalRecordSummaryText(SandboxRecordData record, Color boldColor)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log_Toc_GridItem), Member = "OnClick")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(DetailedStatsView), Member = "Start")]
	[Calls(Type = typeof(SummaryStatsView), Member = "Start")]
	[Calls(Type = typeof(Panel_Log), Member = "UncacheSandboxRecord")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	public void ViewSandbox()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
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

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "ReallySaveJournal")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(Panel_Log), Member = "OnOverwriteSandboxConfirmed")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnOverwriteSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	private void ReallySaveJournal()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "CreateLogObject")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	public void EnableTableOfContentsView()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableTableOfContentsView")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
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

	[Calls(Type = typeof(Panel_Log), Member = "OnDeleteSandbox")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRenameSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(InputManager), Member = "GetDeletePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewButtons")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetRenamePressed")]
	[CallerCount(Count = 1)]
	private void DoControlsTOCView()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	private void UpdateTocViewSelection()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewOverwriteButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRenameSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewButtons")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	private void BuildTOCList()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnTocScrollbarChange()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTocViewSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableTableOfContentsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSandboxLimitNotificationConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSandboxLimitNotification")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(Panel_Log_Toc_GridItem), Member = "Update")]
	[Calls(Type = typeof(Panel_Log_Toc_GridItem), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	public void OnTocItemClicked(int index)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private void UpdateTocViewOverwriteButtons()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRenameSandbox")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetRenamePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewOverwriteButtons")]
	[Calls(Type = typeof(Panel_Log), Member = "ReallySaveJournal")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	private void DoControlsTOCViewOverwrite()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "StoreNoteCollectiblesInRecord")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(StatContainer), Member = ".ctor")]
	[Calls(Type = typeof(Panel_Log), Member = "StoreAuroraScreenCollectiblesInRecord")]
	[Calls(Type = typeof(Panel_Log), Member = "StoreCairnCollectiblesInRecord")]
	[Calls(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUserDefinedSlotName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private SandboxRecordData CreateSandboxRecord()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "CreateSandboxRecord")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void StoreNoteCollectiblesInRecord(SandboxRecordData record)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "CreateSandboxRecord")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	private void StoreCairnCollectiblesInRecord(SandboxRecordData record)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CreateSandboxRecord")]
	[CallsUnknownMethods(Count = 8)]
	private void StoreAuroraScreenCollectiblesInRecord(SandboxRecordData record)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "InstantiateGridItems")]
	[Calls(Type = typeof(AlmanacGridItem), Member = "ShowFalseBlizzard")]
	[Calls(Type = typeof(AlmanacGridItem), Member = "SetUpGridItem")]
	[Calls(Type = typeof(int), Member = "Parse")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
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

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateAlmanacPage")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 1)]
	private void InstantiateGridItems()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[CalledBy(Type = typeof(SurveyRegionListItem), Member = "SetRegionInfo")]
	[CallsUnknownMethods(Count = 5)]
	public Texture GetRegionButtonTexture(string sceneName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnForceRevealHiddenDetailsToggle")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetRegionInfo")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetSelected")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "Clear")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	public void UpdateCartographyPage()
	{
	}

	[CallsUnknownMethods(Count = 12)]
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

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetSelected")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	protected void OnSurveyRegionClicked(int index)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyRegionClicked")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSurveyScrollbar")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
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
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void OnSurveyBack()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 3)]
	protected void OnSurveyClicked(int index)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	public void HandleSurveyScrollbar(float amount)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyRegionClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSurveyScrollbar")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSurveyScrollbar")]
	private void HandleSurveyVerticalNavigation(float amount)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateCollectionSelectScreenDummyData")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 85)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRegionUnlocked")]
	[Calls(Type = typeof(Panel_Map), Member = "GetLocIdsOfUnlockedMapElements")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 27)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(SurveyRegionInfo), Member = ".ctor")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	private void BuildCartographyRegionList()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Collections")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "SetCollectionSubscreenNameLabel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateCollectionsPage()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectionsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReleaseTempResources")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	private void ReleaseTempResources_Collections()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnCollectiblesTab()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnCollectionsTab()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void DoCollectionsToggle()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "SetCollectionSubscreenNameLabel")]
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

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateCollectionSelectScreenDummyData")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateAvailableMementos")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateAvailablePostCards")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void BuildCollectionsList()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AssetLabelReference), Member = "RuntimeKeyIsValid")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectionsList")]
	[CallsUnknownMethods(Count = 17)]
	private void UpdateAvailablePostCards()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectionsList")]
	[Calls(Type = typeof(DisableForCurrentModeExtensions), Member = "ShouldDisableForCurrentMode")]
	[Calls(Type = typeof(NarrativeCollectibleItem), Member = "IsMementoItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetLabelReference), Member = "RuntimeKeyIsValid")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void UpdateAvailableMementos()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DisableForCurrentModeExtensions), Member = "ShouldDisableForCurrentMode")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NarrativeCollectibleItem), Member = "IsMementoItem")]
	private static bool IsActiveMemento(GameObject prefab, out NarrativeCollectibleItem collectibleItem)
	{
		collectibleItem = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void AddEntryToList(int scrollIndex, CollectionListItemInfo itemInfo)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	private void UpdateCollectionListSelectionScroll(int moveVal, ref int index)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateCollectionListItemsColor()
	{
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshCollectibleCounters")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectionsList")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	private void GenerateCollectionSelectScreenDummyData(List<CollectionListItemInfo> dummyDataList)
	{
	}

	[CallerCount(Count = 0)]
	private bool IsInCollectionsSelectScreen()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnCollectionsSubScreen")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectionsPage")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void SetCollectionSubscreenNameLabel()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateCollectionSelectScreenDummyData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NarrativeCollectibleItem), Member = "IsMementoItem")]
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

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(Panel_Log), Member = "RemoveNewCollectionEntry")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void MaybeShowNotificationFlagForNewCollectionEntry()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetChallengeTexture")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 21)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionInfoFromPrefab")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ChallengeChecklistEntry), Member = "UpdateEntry")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ChallengeChecklistEntry), Member = "UpdateEntry")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	private void UpdateMissionsPage()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetChallengeTexture")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void SetChallengeTextureAsync(ChallengeConfig challengeConfig)
	{
	}

	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "UpdateMissionInfo")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionInfoFromPrefab")]
	[CalledBy(Type = typeof(Action_ChallengeNowhereToHideRequirements), Member = "OnUpdate")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 4)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	public void ClearMissions()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnMissionsButton()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	public void DoControlsMissions()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetTrackedMission")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshObjectivesToShow")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateMissionInfoFromPrefab()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(RockCacheListItem), Member = "Clear")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(RockCacheListItem), Member = "Clear")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateRockCacheScreenData")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	private void BuildRockCacheRegionScrollList()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheRegionClicked")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableRockCacheStateFromMap")]
	private void SetRegionAndRockCacheSelected(string sceneName, string rockCacheName)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheItemScrollbarChange")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildRockCacheRegionScrollList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRegionScrollbarChange")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetItemInfo")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleScrollbar")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleScrollbar")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRegionClicked")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Panel_Map), Member = "MapElementExists")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRenameRockCacheConfirmed")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRegionUnlocked")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheUserTextFromGuid")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheNameFromGuid")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	private void RefreshRockCacheListForSelectedRegion(bool newRegion)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int GetNumberOfRockCachesInCurrentRegion()
	{
		return default(int);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnRockCacheRegionScrollbarChange()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 3)]
	public void OnRockCacheItemScrollbarChange()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheNameFromGuid")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetupInputField")]
	public void OnRockCacheRenameButton()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	private void OnRenameRockCacheConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnRockCacheEditNoteClicked()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "UpdateRockCacheNoteSlider")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public void OnRockCacheNoteScrollbarUp()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateRockCacheNoteSlider")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CallsUnknownMethods(Count = 4)]
	public void OnRockCacheNoteScrollbarDown()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateRockCacheNoteSlider")]
	public void OnRockCacheNoteScrollbarChange()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarUp")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarDown")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateRockCacheNoteSlider()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheEditNoteClicked")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheUserTextFromGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	public void RockCacheNoteTakingStart()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheUserText")]
	private void MaybeUpdateNote()
	{
	}

	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(TextInputField), Member = "GetCursorLocation")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarDown")]
	[Calls(Type = typeof(UILabel), Member = "get_printedSize")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeUpdateNote")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeUpdateNote")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheUserTextFromGuid")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheUserText")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarUp")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateRockCacheNoteSlider")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarDown")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void MaybeUpdateRockCacheNoteView()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheRegionClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeUpdateNote")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleScrollbar")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheRenameButton")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenMapPressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	private void DoControlsRockCaches()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeUpdateNote")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void OnRockCacheBack()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetRegionAndRockCacheSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	protected void OnRockCacheRegionClicked(int index)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetRegionAndRockCacheSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheNameFromGuid")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheUserTextFromGuid")]
	protected void OnRockCacheItemClicked(int index)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Map), Member = "CenterOnPoint")]
	[Calls(Type = typeof(Panel_Map), Member = "ForceZoomIn")]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRegionUnlocked")]
	[Calls(Type = typeof(Panel_Log), Member = "OnMapNav")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	public void OnRockCacheShowOnMapClicked()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRegionUnlocked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildRockCacheRegionScrollList")]
	private void GenerateRockCacheScreenData()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	private void UpdateSkillsPage()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReleaseTempResources")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[CallsUnknownMethods(Count = 1)]
	private void ReleaseTempResources_Skills()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnSkillsButton()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSkillScrollbar")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	public void DoControlsSkillsListStats()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSkillScrollbar")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	private void HandleSkillVerticalNavigation(float amount)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private void HandleSkillScrollbar(float amount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarSkillsChange()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	protected void OnSkillItemClicked(int index)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarSkillsChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSkillsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SkillListItem), Member = "SetProgress")]
	[Calls(Type = typeof(Skill), Member = "GetProgressToNextLevelAsNormalizedValue")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Skill), Member = "GetTierPoints")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(SkillListItem), Member = "SetSkillLevel")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(int), Member = "ToString")]
	private void RefreshSkillsList()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSkillItemClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSkillsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillScrollbar")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarSkillsChange")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierName")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 24)]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Skills")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarSkillsChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSkillsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	private void UpdateSkillListItemsColor()
	{
	}

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
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Trust")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateTrustPage()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
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
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_Log), Member = "DoPeopleTabToggle")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontalRightStick")]
	public void DoControlsTrustList()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateTrustListData")]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void BuildTrustList()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void UpdateTrustListItemsColor()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildTrustList")]
	[CallsUnknownMethods(Count = 6)]
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

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "GetStringForNeed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "IsTrustWithinNeedRange")]
	[Calls(Type = typeof(TrustManager), Member = "GetNeedTracker")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void SetupNeedsInfo(string trustID)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetupNeedsInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetGearDisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetGearDisplayName")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetStringForNeed(NeedPrefabSaveData needData)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetupNeedsInfo")]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[CallerCount(Count = 1)]
	private bool IsTrustWithinNeedRange(NeedPrefabSaveData needData, string trustID)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshTrustMapSelection")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(TrustManager), Member = "GetUnlockableTracker")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	private void SetupTrustMap(string trustID)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetupTrustMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnTrustMapClicked")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshTrustMapSelection()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[CallsUnknownMethods(Count = 2)]
	private void DeselectAllTrustMapEntries()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnWhatIKnowSubScreen")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_WhatIKnow")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowDescScrollbar")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void UpdateWhatIKnowPage()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReleaseTempResources")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	private void ReleaseTempResources_WhatIKnow()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnWhatIKnowButton()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarWhatIKnowDescDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarWhatIKnowDescUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	public void DoControlsWhatIKnowList()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void SetWhatIKnowListSelectedToEntry(string nameLocID)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void PointToWhatIKnowEntryOnQuickKeyActive(KnowledgeCateogry category, string nameLocID)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowDescScrollbar")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CallsUnknownMethods(Count = 2)]
	public void OnScrollbarWhatIKnowDescUp()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowDescScrollbar")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CallsUnknownMethods(Count = 2)]
	public void OnScrollbarWhatIKnowDescDown()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowDescScrollbar")]
	[CallerCount(Count = 0)]
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
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnWhatIKnowSubScreen")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateSubscreenData")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateSubscreenData")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateSubscreenData")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateSubscreenData")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateSelectScreenData")]
	private void BuildWhatIKnowList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void AddWhatIKnowEntryToList(int scrollIndex, CollectionListItemInfo itemInfo)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	private void UpdateWhatIKnowListSelectionScroll(int moveVal, ref int index)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(CollectionListItem), Member = "SetSelected")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void UpdateWhatIKnowListItemsColor()
	{
	}

	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void GenerateSelectScreenData()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetNameIDFromDescID")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void GenerateSubscreenData(List<string> knowledgeList)
	{
	}

	[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(KnowledgeManager), Member = "GetListUnlockedKnowledgeOfType")]
	private void RefreshCachedKnowledgeUnlocks()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "RemoveNewKnowledgeEntry")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void MaybeShowNotificationFlagForNewKnowledgeEntry()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallsUnknownMethods(Count = 19)]
	private void MaybeShowNotificationFlagForKnowledgeSubCategories()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewKnowledgeEntry")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleOnSubcategoryNotificationRemoved")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ShowPanelLogSubCategoryNotificationIcon")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void RemoveNotificationFromKnowledgeSubCategory(string descId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallsUnknownMethods(Count = 3)]
	public Panel_Log()
	{
	}
}
