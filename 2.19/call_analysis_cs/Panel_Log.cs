using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using InteractiveObjects;
using TLD.AddressableAssets;
using TLD.Cooking;
using TLD.Gameplay;
using TLD.GameplayTags;
using TLD.Missions;
using TLD.SaveState;
using TLD.Scenes;
using TLD.Stats;
using TLD.Transmitters.UI;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Pool;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.ResourceManagement.AsyncOperations;

public class Panel_Log : Panel_AutoReferenced, INotificationHandler, IMiniTopNav
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
		Mementos,
		Transmitters,
		Recipes
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

		public static Comparison<CairnInfo> _003C_003E9__254_0;

		public static Comparison<AuroraScreenInfo> _003C_003E9__254_1;

		public static Comparison<CairnInfo> _003C_003E9__343_0;

		public static Comparison<AuroraScreenInfo> _003C_003E9__344_0;

		public static Comparison<SurveyAchievementInfo> _003C_003E9__393_3;

		public static Comparison<SurveyAchievementInfo> _003C_003E9__393_4;

		public static Comparison<SurveyRegionInfo> _003C_003E9__393_0;

		public static Comparison<SurveyRegionInfo> _003C_003E9__393_1;

		public static Comparison<SurveyRegionInfo> _003C_003E9__393_2;

		public static Comparison<RegionInfo> _003C_003E9__568_0;

		public static Comparison<RegionInfo> _003C_003E9__568_1;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCollectibleList_003Eb__254_0(CairnInfo x, CairnInfo y)
		{
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCollectibleList_003Eb__254_1(AuroraScreenInfo x, AuroraScreenInfo y)
		{
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CStoreCairnCollectiblesInRecord_003Eb__343_0(CairnInfo x, CairnInfo y)
		{
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CStoreAuroraScreenCollectiblesInRecord_003Eb__344_0(AuroraScreenInfo x, AuroraScreenInfo y)
		{
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCartographyRegionList_003Eb__393_3(SurveyAchievementInfo a, SurveyAchievementInfo b)
		{
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCartographyRegionList_003Eb__393_4(SurveyAchievementInfo a, SurveyAchievementInfo b)
		{
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCartographyRegionList_003Eb__393_0(SurveyRegionInfo a, SurveyRegionInfo b)
		{
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCartographyRegionList_003Eb__393_1(SurveyRegionInfo a, SurveyRegionInfo b)
		{
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCartographyRegionList_003Eb__393_2(SurveyRegionInfo a, SurveyRegionInfo b)
		{
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CGenerateRockCacheScreenData_003Eb__568_0(RegionInfo a, RegionInfo b)
		{
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CGenerateRockCacheScreenData_003Eb__568_1(RegionInfo a, RegionInfo b)
		{
			return 0;
		}
	}

	public bool m_EnableDiaryOnExit;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public Color m_BoldColor;

	public MiniTopNav m_MiniTopNav;

	public MiniTopNav m_MiniTopNavChallengeMode;

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

	public TransmitterSiteUIController m_TransmittersSectionObject;

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

	private const string LOC_FILTER_TRANSMITTERS = "GAMEPLAY_CollectionTransmitters";

	private const string LOC_FILTER_RECIPES = "GAMEPLAY_CollectionRecipes";

	private const string LOC_DESC_NOTES = "GAMEPLAY_CollectionNotesDescription";

	private const string LOC_DESC_MATCHBOOKS = "GAMEPLAY_CollectionMatchbooksDescription";

	private const string LOC_DESC_POSTCARDS = "GAMEPLAY_CollectionPostcardsDescription";

	private const string LOC_DESC_MEMENTOS = "GAMEPLAY_MementosFound";

	private const string LOC_DESC_CAIRNS = "GAMEPLAY_CollectionCairnsDescription";

	private const string LOC_DESC_AURORASCREENS = "GAMEPLAY_CollectionAuroraScreensDescription";

	private const string LOC_DESC_SURVEYSCREEN = "GAMEPLAY_CollectionSurveyScreenDescription";

	private const string LOC_DESC_TRANSMITTERS = "GAMEPLAY_CollectionTransmittersDescription";

	private const string LOC_DESC_RECIPES = "GAMEPLAY_CollectionRecipesDescription";

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

	public string m_TransmitterSpriteSmall;

	public string m_TransmitterSpriteBig;

	public string m_RecipesSpriteSmall;

	public string m_RecipesSpriteBig;

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
			return 0;
		}
	}

	private int TotalNumMementoCollectibles
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	public event Action<string, NotificationFlagInfo> m_ItemSelected
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(Panel_Log), Member = "InitializeGameplayTagLookups")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_Log), Member = "InstantiateLogGridItems")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Log), Member = "CacheComponents")]
	[Calls(Type = typeof(Panel_Log), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 13)]
	public override void Initialize()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenActionsPanelPressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[Calls(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectionListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewKnowledgeEntry")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForKnowledgeSubCategories")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewCollectionEntry")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void FixedUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Collections")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Skills")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Trust")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_WhatIKnow")]
	[Calls(Type = typeof(Panel_Log), Member = "CleanupSelectedSandboxRecord")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PanelReference<>), Member = "TrySetEnabled")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "AreTalesAvailable")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[Calls(Type = typeof(SummaryStatsView), Member = "Start")]
	[Calls(Type = typeof(DetailedStatsView), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSelectedSandboxRecord")]
	[Calls(Type = typeof(Panel_Log), Member = "SetUpTopNav")]
	[Calls(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(GameManager), Member = "MaybeForceGC")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Disable()
	{
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnLog")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnJournalNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnMissionsNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnMiniTopNavButtonClick")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMiniTopNavButtonClick")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalAction")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Utils), Member = "GetTitleString")]
	[Calls(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[Calls(Type = typeof(Panel_Log), Member = "HasEnableFromRadialOverride")]
	[Calls(Type = typeof(Panel_Log), Member = "AreTalesAvailable")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "IsChallengeMode")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void EnableFromRadial(PanelLogState state)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "SetRegionAndRockCacheSelected")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void EnableRockCacheStateFromMap(string sceneName, string rockCacheCustomName)
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnDailyLogButton")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnStatsButton")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnCollectibleButton")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnRockCachesButton")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnSkillsButton")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void EnableFromMissionsStory(PanelLogState state)
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalActionFromMap")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "AreTalesAvailable")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "NavigateToMissionById")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void EnableFromMap(string missionId)
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalActionFromObjective")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "AreTalesAvailable")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "NavigateToMissionById")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void EnableFromObjective(string missionId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EnableDailyView()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnLog")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EnableStatsView()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Log), Member = "LockInTodaysValues")]
	[Calls(Type = typeof(Panel_Log), Member = "CreateSandboxRecord")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	[Calls(Type = typeof(Panel_Log), Member = "BeginFadeIn")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void EnableDeathView()
	{
	}

	[CallerCount(Count = 21)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "QuitToMainMenuOnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "UncacheSandboxRecord")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "OnMapNav")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void OnBack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "DeselectLogGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	public void LogGridItemCallback(int entryNum)
	{
	}

	[CalledBy(Type = typeof(LogGridItem), Member = "SetSelected")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogGridItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveSelectedSpriteAndTween")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectionsPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void LogListItemCallback(int indexClicked)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	public void OnWriteButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnStatus()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TrySetEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnInventory()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarDaysUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarDaysDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CallsUnknownMethods(Count = 4)]
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

	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarCollectiblesUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarCollectiblesDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CallsUnknownMethods(Count = 4)]
	public void OnScrollbarCollectiblesChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateStatsSlider")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarDayStatsUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateStatsSlider")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarDayStatsDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateStatsSlider")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnScrollbarStatsDaysChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarNotesUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 3)]
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
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarExamineCollectibleUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(Panel_Log), Member = "OnEnterNoteTaking")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnShowDayStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
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

	[CalledBy(Type = typeof(Panel_Log), Member = "OnWriteButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "CanEditJournal")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsUnknownMethods(Count = 3)]
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
	public void OnTransmittersButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnExamineCollectible()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Initialize")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnCraftingNav()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMapNav")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnMapNav()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	public void OnJournalNav()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
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

	[CalledBy(Type = typeof(Panel_Log), Member = "HandleOnNotificationAdded")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ShowPanelLogMainCategoryNotificationIcon(MainCategory mainCategory, bool enable)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableRockCacheStateFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMissionsStory")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromObjective")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDailyView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectionListSelectionScroll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustListSelectionScroll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetWhatIKnowListSelectedToEntry")]
	[CalledBy(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListSelectionScroll")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	[CallerCount(Count = 16)]
	private void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ExitInterfaceOnDeath()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnQuitToMainMenu")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ForceQuit")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReallyQuitToMainMenu")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandboxConfirmed")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Extras), Member = "ShouldShowExtras")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void ExitInterface()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
		return false;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 2)]
	private bool QuitToMainMenuOnBack()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTransmitters")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTocViewButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTocViewOverwriteButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsAlmanac")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsMissions")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(Panel_Log), Member = "QuitToMainMenuOnBack")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private string GetOnBackText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	private void SelectSandbox(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionInfoFromPrefab")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "AreTalesAvailable")]
	[CallsUnknownMethods(Count = 1)]
	private bool AreTalesAvailable()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 2)]
	private bool IsChallengeMode()
	{
		return false;
	}

	[CallerCount(Count = 41)]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableAllLBRBButtons")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Collections")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Skills")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Trust")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_WhatIKnow")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "AreTalesAvailable")]
	[Calls(Type = typeof(Panel_Log), Member = "IsChallengeMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateExamineCollectible")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildSkillsList")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateAlmanacPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildTrustList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildRockCacheRegionScrollList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 21)]
	private void EnterState(PanelLogState newState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public void ResetNotificationsData()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "NotesToggle")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(Log), Member = "GetInfoForDay")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Log), Member = "ClearGrid")]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UIGrid), Member = "AddChild")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateStatsSlider")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 26)]
	private void UpdateDailyStatsPage()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsUp")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsDown")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarStatsDaysChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateStatsSlider()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "CanEditJournal")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Log), Member = "GetInfoForDay")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesSlider")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateNotesPage()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarExamineCollectibleChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateExamineCollectible")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateExamineCollectibleSlider()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateNotesSlider()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Input), Member = "GetMouseButton")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Log), Member = "EnterNotesForDay")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesSlider")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UILabel), Member = "get_printedSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(TextInputField), Member = "GetCursorLocation")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesDown")]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	private void CheckForNotesChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnCollectionsSubScreen")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectionsPage")]
	[Calls(Type = typeof(Panel_Log), Member = "SetCollectionSubscreenNameLabel")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_Description")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateCollectibleList()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateExamineCollectibleSlider")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateExamineCollectible()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SummaryStatsView), Member = "Start")]
	[Calls(Type = typeof(DetailedStatsView), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	private void BuildStatsView()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarDaysChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Log), Member = "GetInfoForDay")]
	[Calls(Type = typeof(LogGridItem), Member = "SetupAsDayEntry")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void BuildDailyList(bool doSelectionReset)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnCollectionsSubScreen")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectionsList")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(HashSet<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[Calls(Type = typeof(LogGridItem), Member = "SetupAsCollectionEntry")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NarrativeCollectibleItem), Member = "IsMementoItem")]
	[Calls(Type = typeof(LogGridItem), Member = "SetupAsCollectibleEntry")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 29)]
	private void BuildCollectibleList(bool doSelectionReset)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 28)]
	private void ClearGrid(UIGrid gridToClear)
	{
	}

	[CallerCount(Count = 0)]
	private bool ShouldShowNotes()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanEditJournal()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 2)]
	private bool CanSaveJournal()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListSelectionScroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 1)]
	private void ScrollListMovement(int moveVal)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	private void DoScrollListScrollLeft()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsUp")]
	private void DoScrollListScrolLRight()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDaysDown")]
	[Calls(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DoControlsCollectibleList()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	[Calls(Type = typeof(Panel_Log), Member = "CanEditJournal")]
	[Calls(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "NotesToggle")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void DoControlsDailyListStats()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(DetailedStatsView), Member = "ScrollUp")]
	[Calls(Type = typeof(DetailedStatsView), Member = "ScrollDown")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStatsConfirmed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void DoControlsStats()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(TransmitterSiteUIController), Member = "UpdateScrollFromSmallMovement")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetDeletePressed")]
	[Calls(Type = typeof(TransmitterSiteUIController), Member = "SelectNextAvailableWorldMap")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[CallsUnknownMethods(Count = 1)]
	private void DoControlsTransmitters()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStatsConfirmed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnResetAllTimeStats()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool CanShowMiniTopNav()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool OnMiniTopNavButtonClick(Panel_Base owner)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarExamineCollectibleDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarExamineCollectibleUp")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void DoControlsExamineCollectible()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshActivePanelStates")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveSectionNavToButton")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private void DoSectionNavControls()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetUpTopNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshActivePanelStates()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private void DisableAllMouseButtons()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(MiniTopNav), Member = "Show")]
	[Calls(Type = typeof(MiniTopNav), Member = "Hide")]
	[Calls(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[Calls(Type = typeof(Panel_Log), Member = "DisableAllMouseButtons")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsMissions")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsTransmitters")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void DoControls()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesUp")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDaysUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDaysDown")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void DoMouseScrollControls()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateNavigationButtons()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallerCount(Count = 2)]
	private void BeginFadeIn()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnFinalScreenShown()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "ToggleButtonColliders")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "ToggleButtonColliders")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void ToggleButtonColliders(Transform transform, bool enabled)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshActivePanelStates")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void SetUpTopNav()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateCurrentGameLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateScrollbarThumbSize()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateScrollbarThumbSizeIndividual(UISlider slider, int numVisible, int total)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(MiniTopNav), Member = "Show")]
	[Calls(Type = typeof(MiniTopNav), Member = "Hide")]
	[CallsUnknownMethods(Count = 2)]
	private void DoMainNavControls()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldRenderOverOtherScreens()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTransmitters")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTocViewButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTocViewOverwriteButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ActivateBackButton()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void InstantiateLogGridItems()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromObjective")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	private bool ShouldEnterSectionNav()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallerCount(Count = 3)]
	private void MoveSectionNavToButton(PanelLogState buttonState)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDaysDown")]
	[Calls(Type = typeof(Panel_Log), Member = "DeselectLogGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDaysUp")]
	[Calls(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void MoveGridSelection(int horizontal, int vertical)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	private int GetNumGridItemsShowing()
	{
		return 0;
	}

	[CalledBy(Type = typeof(LogGridItem), Member = "SetSelected")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogGridItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetNumGridItemsShowing")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CallerCount(Count = 13)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private int GetTotalNumGridItems()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarDaysChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "DeselectLogGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	private void SetLogGridItemIndex(int index)
	{
	}

	[CallerCount(Count = 0)]
	private int GetCollectibleListTrueIndex()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	private bool StateIsShowing(PanelLogState state)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateSectionNavButtonColors()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void DoSectionNavUpdate()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromObjective")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectionListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "DeselectLogGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveSectionNavToButton")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshActivePanelStates")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableAllLBRBButtons")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "DeselectAllMissions")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustListItemsColor")]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void EnterSectionNav()
	{
	}

	[CalledBy(Type = typeof(LogGridItem), Member = "SetSelected")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogGridItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallerCount(Count = 5)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void DeselectLogGridItems()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "EnableSpriteIfActionIs")]
	[CallsUnknownMethods(Count = 2)]
	private void EnableAllLBRBButtons(bool shouldEnable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MiniTopNav), Member = "Hide")]
	[Calls(Type = typeof(MiniTopNav), Member = "Show")]
	[CallsUnknownMethods(Count = 1)]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "AreTalesAvailable")]
	[CallsUnknownMethods(Count = 1)]
	private void SetActiveTab(NavigationTabState state)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void SetActive(GameObject go, bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private void CacheComponents()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Collections")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Skills")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Trust")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_WhatIKnow")]
	private void ReleaseTempResources()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[CallsUnknownMethods(Count = 3)]
	private bool HasEnableFromRadialOverride(out PanelLogState overrideState)
	{
		overrideState = default(PanelLogState);
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeRemoveJournalState(GameModeConfig gameMode, PanelLogState state)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	private void InitializeGameplayTagLookups()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRenameSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSelectedSandboxRecord")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "GetSurvivalRecordSummaryText")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[Calls(Type = typeof(DateTime), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateTOCSelection()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_Log), Member = "CleanupSelectedSandboxRecord")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSelectedSandboxRecord()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSelectedSandboxRecord")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	private void CleanupSelectedSandboxRecord()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(StatContainer), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(AssetHelper), Member = "TryInstantiateAsset")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UncacheSandboxRecord(SandboxRecordData record)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "ColorToHex")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ZoneSpecification), Member = "get_ZoneName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Utils), Member = "GetTimeSurvivedString")]
	[CallsUnknownMethods(Count = 1)]
	private string GetSurvivalRecordSummaryText(SandboxRecordData record, Color boldColor)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CalledBy(Type = typeof(Panel_Log_Toc_GridItem), Member = "OnClick")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "UncacheSandboxRecord")]
	[Calls(Type = typeof(SummaryStatsView), Member = "Start")]
	[Calls(Type = typeof(DetailedStatsView), Member = "Start")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsUnknownMethods(Count = 1)]
	public void ViewSandbox()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDeleteSandbox()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDeleteSandboxConfirmed()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void OnRenameSandbox()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Panel_Log), Member = "ReallySaveJournal")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnOverwriteSandbox()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Panel_Log), Member = "ReallySaveJournal")]
	[CallsUnknownMethods(Count = 1)]
	private void OnOverwriteSandboxConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnSandboxLimitNotification()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	private void OnSandboxLimitNotificationConfirmed()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[CallerCount(Count = 4)]
	public void OnSaveJournal()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnOverwriteSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnOverwriteSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsUnknownMethods(Count = 1)]
	private void ReallySaveJournal()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "CreateLogObject")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void EnableTableOfContentsView()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnableTableOfContentsView")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void CreateLogObject()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateTocViewButtons()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewButtons")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetDeletePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetRenamePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRenameSandbox")]
	[Calls(Type = typeof(Panel_Log), Member = "OnDeleteSandbox")]
	[Calls(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewSelection")]
	[CallsUnknownMethods(Count = 1)]
	private void DoControlsTOCView()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateTocViewSelection()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRenameSandboxConfirmed")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewOverwriteButtons")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewButtons")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void BuildTOCList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsUnknownMethods(Count = 4)]
	public void OnTocScrollbarChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnSandboxLimitNotification")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSandboxLimitNotificationConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableTableOfContentsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTocViewSelection")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Log_Toc_GridItem), Member = "Update")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void OnTocItemClicked(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateTocViewOverwriteButtons()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewOverwriteButtons")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Panel_Log), Member = "ReallySaveJournal")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(InputManager), Member = "GetRenamePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRenameSandbox")]
	[Calls(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewSelection")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DoControlsTOCViewOverwrite()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUserDefinedSlotName")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[Calls(Type = typeof(Panel_Log), Member = "StoreNoteCollectiblesInRecord")]
	[Calls(Type = typeof(Panel_Log), Member = "StoreCairnCollectiblesInRecord")]
	[Calls(Type = typeof(Panel_Log), Member = "StoreAuroraScreenCollectiblesInRecord")]
	[Calls(Type = typeof(StatContainer), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private SandboxRecordData CreateSandboxRecord()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "CreateSandboxRecord")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void StoreNoteCollectiblesInRecord(SandboxRecordData record)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "CreateSandboxRecord")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentNullException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	private void StoreCairnCollectiblesInRecord(SandboxRecordData record)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "CreateSandboxRecord")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HashSet<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentNullException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void StoreAuroraScreenCollectiblesInRecord(SandboxRecordData record)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "InstantiateGridItems")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionManagerBase), Member = "GetMissionBlackboardVar")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(int), Member = "Parse")]
	[Calls(Type = typeof(AlmanacGridItem), Member = "SetUpGridItem")]
	[Calls(Type = typeof(AlmanacGridItem), Member = "ShowFalseBlizzard")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
	private void UpdateAlmanacPage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnAlmanacButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void DoControlsAlmanac()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateAlmanacPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 11)]
	private void InstantiateGridItems()
	{
	}

	[CalledBy(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[CalledBy(Type = typeof(SurveyRegionListItem), Member = "SetRegionInfo")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 4)]
	public Texture GetRegionButtonTexture(string sceneName)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnForceRevealHiddenDetailsToggle")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "Clear")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetSelected")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetRegionInfo")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateCartographyPage()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyRegionClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyRegionScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyAchievementScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyScrollbar")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetRegionInfo")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetAchievementInfo")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 12)]
	private void RefreshAchievementListForSelectedRegion(bool newRegion)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetSelected")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	protected void OnSurveyRegionClicked(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenMapPressed")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyRegionClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSurveyScrollbar")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void DoControlsCartography()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnForceRevealHiddenDetailsToggle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void OnSurveyBack()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	protected void OnSurveyClicked(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 3)]
	public void OnSurveyRegionScrollbarChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 3)]
	public void OnSurveyAchievementScrollbarChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public void HandleSurveyScrollbar(float amount)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSurveyScrollbar")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyRegionClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyClicked")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void HandleSurveyVerticalNavigation(float amount)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateCollectionSelectScreenDummyData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(SurveyRegionInfo), Member = ".ctor")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRegionUnlocked")]
	[Calls(Type = typeof(Panel_Map), Member = "GetLocIdsOfUnlockedMapElements")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 80)]
	private void BuildCartographyRegionList()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "SetCollectionSubscreenNameLabel")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Collections")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateCollectionsPage()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReleaseTempResources")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectionsPage")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void DoCollectionsToggle()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Log), Member = "SetCollectionSubscreenNameLabel")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void DoControlsCollectionList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Log), Member = "SetCollectionSubscreenNameLabel")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnCollectionsSubScreen()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateAvailablePostCards")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateAvailableMementos")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateCollectionSelectScreenDummyData")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void BuildCollectionsList()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectionsList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetLabelReference), Member = "RuntimeKeyIsValid")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAssets")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateAvailablePostCards()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectionsList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetLabelReference), Member = "RuntimeKeyIsValid")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAssets")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(NarrativeCollectibleItem), Member = "IsMementoItem")]
	[Calls(Type = typeof(DisableForCurrentModeExtensions), Member = "ShouldDisableForCurrentMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateAvailableMementos()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(NarrativeCollectibleItem), Member = "IsMementoItem")]
	[Calls(Type = typeof(DisableForCurrentModeExtensions), Member = "ShouldDisableForCurrentMode")]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsActiveMemento(GameObject prefab, out NarrativeCollectibleItem collectibleItem)
	{
		collectibleItem = null;
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void AddEntryToList(int scrollIndex, CollectionListItemInfo itemInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateCollectionListSelectionScroll(int moveVal, ref int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetSelected")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateCollectionListItemsColor()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectionsList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshCollectibleCounters")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Log), Member = "CountDiscoveredTransmitters")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_IsDone")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(GenericPool<>), Member = "Get")]
	[Calls(Type = typeof(RecipeBook), Member = "GetFilteredRecipes")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void GenerateCollectionSelectScreenDummyData(List<CollectionListItemInfo> dummyDataList)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateCollectionSelectScreenDummyData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(TransmitterManager), Member = "GetTransmitterState")]
	[CallsUnknownMethods(Count = 3)]
	private int CountDiscoveredTransmitters(List<TransmitterData> allTransmitters)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	private bool IsInCollectionsSelectScreen()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectionsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnCollectionsSubScreen")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void SetCollectionSubscreenNameLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateCollectionSelectScreenDummyData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NarrativeCollectibleItem), Member = "IsMementoItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshCollectibleCounters()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveNewCollectionEntry(NotificationFlagInfo nfi)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallerCount(Count = 1)]
	private void MaybeShowNotificationFlagForNewCollectionEntry()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionInfoFromPrefab")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ChallengeChecklistEntry), Member = "UpdateEntry")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetChallengeTexture")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(Action<>), Member = ".ctor")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 21)]
	private void UpdateMissionsPage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetChallengeTexture")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(Action<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "add_Completed")]
	[CallsUnknownMethods(Count = 1)]
	private void SetChallengeTextureAsync(ChallengeConfig challengeConfig)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionInfoFromPrefab")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "UpdateMissionInfo")]
	[CalledBy(Type = typeof(Action_ChallengeNowhereToHideRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 11)]
	public void UpdateMissionInfo(string name, string description, string[] checklistKeys, string[] checklistValues, bool[] checklistBools)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveMission(string name)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public void ClearMissions()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnMissionsButton()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void DoControlsMissions()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Log), Member = "AreTalesAvailable")]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetTrackedMission")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshObjectivesToShow")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionInfo")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateMissionInfoFromPrefab()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateRockCacheScreenData")]
	[Calls(Type = typeof(RockCacheListItem), Member = "Clear")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 14)]
	private void BuildRockCacheRegionScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnableRockCacheStateFromMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheRegionClicked")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void SetRegionAndRockCacheSelected(string sceneName, string rockCacheName)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildRockCacheRegionScrollList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRegionScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheItemScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRenameRockCacheConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleScrollbar")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRegionClicked")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheNameFromGuid")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheUserTextFromGuid")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRegionUnlocked")]
	[Calls(Type = typeof(Panel_Map), Member = "MapElementExists")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 19)]
	private void RefreshRockCacheListForSelectedRegion(bool newRegion)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private int GetNumberOfRockCachesInCurrentRegion()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 3)]
	public void OnRockCacheRegionScrollbarChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 3)]
	public void OnRockCacheItemScrollbarChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheNameFromGuid")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetupInputField")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnRockCacheRenameButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void OnRenameRockCacheConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnRockCacheEditNoteClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateRockCacheNoteSlider")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void OnRockCacheNoteScrollbarUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateRockCacheNoteSlider")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void OnRockCacheNoteScrollbarDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateRockCacheNoteSlider")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnRockCacheNoteScrollbarChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarUp")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarDown")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateRockCacheNoteSlider()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheEditNoteClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheUserTextFromGuid")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[CallsUnknownMethods(Count = 1)]
	public void RockCacheNoteTakingStart()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheBack")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheUserText")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeUpdateNote()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheUserTextFromGuid")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarDown")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateRockCacheNoteSlider")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheUserText")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UILabel), Member = "get_printedSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(TextInputField), Member = "GetCursorLocation")]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeUpdateNote")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public void MaybeUpdateRockCacheNoteView()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheRenameButton")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenMapPressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheRegionClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeUpdateNote")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleScrollbar")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	private void DoControlsRockCaches()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeUpdateNote")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void OnRockCacheBack()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void HandleScrollbar(float amount)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "HandleScrollbar")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheRegionClicked")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void HandleVerticalNavigation(float amount)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "SetRegionAndRockCacheSelected")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	protected void OnRockCacheRegionClicked(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "SetRegionAndRockCacheSelected")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheNameFromGuid")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheUserTextFromGuid")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	protected void OnRockCacheItemClicked(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Panel_Log), Member = "OnMapNav")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRegionUnlocked")]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[Calls(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Panel_Map), Member = "ForceZoomIn")]
	[Calls(Type = typeof(Panel_Map), Member = "CenterOnPoint")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void OnRockCacheShowOnMapClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildRockCacheRegionScrollList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRegionUnlocked")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 17)]
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

	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReleaseTempResources")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void ReleaseTempResources_Skills()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnSkillsButton()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSkillScrollbar")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DoControlsSkillsListStats()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSkillScrollbar")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void HandleSkillVerticalNavigation(float amount)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 3)]
	private void HandleSkillScrollbar(float amount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarSkillsChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	protected void OnSkillItemClicked(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSkillsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarSkillsChange")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(SkillListItem), Member = "SetSkillLevel")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Skill), Member = "GetTierPoints")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Skill), Member = "GetProgressToNextLevelAsNormalizedValue")]
	[Calls(Type = typeof(SkillListItem), Member = "SetProgress")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	private void RefreshSkillsList()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSkillsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillScrollbar")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarSkillsChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSkillItemClicked")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Skills")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierName")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 19)]
	private void RefreshSelectedSkillDescriptionView()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 1)]
	private void BuildSkillsList()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSkillsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarSkillsChange")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSkillListItemsColor()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoPeopleTabToggle")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_Trust")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(Panel_Log), Member = "SetupNeedsInfo")]
	[Calls(Type = typeof(Panel_Log), Member = "SetupTrustMap")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateTrustPage()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReleaseTempResources")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void ReleaseTempResources_Trust()
	{
	}

	[CalledBy(Type = typeof(TrustMapEntry), Member = "TrustMapClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshTrustMapSelection")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "DoPeopleTabToggle")]
	public void OnPeopleTrustTab()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnPeopleDescriptionTab")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnPeopleTrustTab")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	public void DoPeopleTabToggle()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(Panel_Log), Member = "DoPeopleTabToggle")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontalRightStick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTrustMapClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void DoControlsTrustList()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateTrustListData")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void BuildTrustList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetSelected")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateTrustListItemsColor()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildTrustList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void GenerateTrustListData()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	private string GetTrustIDFromNameID(string nameLocID)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrustManager), Member = "GetNeedTracker")]
	[Calls(Type = typeof(Panel_Log), Member = "IsTrustWithinNeedRange")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "GetStringForNeed")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void SetupNeedsInfo(string trustID)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "SetupNeedsInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(GearItem), Member = "GetGearDisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[CallsUnknownMethods(Count = 2)]
	public string GetStringForNeed(NeedPrefabSaveData needData)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "SetupNeedsInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsTrustWithinNeedRange(NeedPrefabSaveData needData, string trustID)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrustManager), Member = "GetUnlockableTracker")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshTrustMapSelection")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void SetupTrustMap(string trustID)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnTrustMapClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetupTrustMap")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshTrustMapSelection()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[CallsUnknownMethods(Count = 2)]
	private void DeselectAllTrustMapEntries()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnWhatIKnowSubScreen")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Log), Member = "ReleaseTempResources_WhatIKnow")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowDescScrollbar")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateWhatIKnowPage()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReleaseTempResources")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void ReleaseTempResources_WhatIKnow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnWhatIKnowButton()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarWhatIKnowDescDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarWhatIKnowDescUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void DoControlsWhatIKnowList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void SetWhatIKnowListSelectedToEntry(string nameLocID)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void PointToWhatIKnowEntryOnQuickKeyActive(KnowledgeCateogry category, string nameLocID)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnWhatIKnowSubScreen()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsUnknownMethods(Count = 3)]
	public void OnWhatIKnowScrollbarChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowDescScrollbar")]
	[CallsUnknownMethods(Count = 2)]
	public void OnScrollbarWhatIKnowDescUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowDescScrollbar")]
	[CallsUnknownMethods(Count = 2)]
	public void OnScrollbarWhatIKnowDescDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowDescScrollbar")]
	public void OnWhatIKnowDescScrollbarChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "RemoveNotificationFromKnowledgeSubCategory")]
	[Calls(Type = typeof(Panel_Log), Member = "AddNotificationToKnowledgeSubCategory")]
	public void ShowPanelLogSubCategoryNotificationIcon(SubCategory subCategory, bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarWhatIKnowDescUp")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarWhatIKnowDescDown")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnWhatIKnowDescScrollbarChange")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateWhatIKnowDescScrollbar()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnWhatIKnowSubScreen")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateSubscreenData")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateSelectScreenData")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void BuildWhatIKnowList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void AddWhatIKnowEntryToList(int scrollIndex, CollectionListItemInfo itemInfo)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateWhatIKnowListSelectionScroll(int moveVal, ref int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetSelected")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateWhatIKnowListItemsColor()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 9)]
	private void GenerateSelectScreenData()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetNameIDFromDescID")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void GenerateSubscreenData(List<string> knowledgeList)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildTrustList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetListUnlockedKnowledgeOfType")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshCachedKnowledgeUnlocks()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallerCount(Count = 1)]
	private void MaybeShowNotificationFlagForNewKnowledgeEntry()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallerCount(Count = 1)]
	private void MaybeShowNotificationFlagForKnowledgeSubCategories()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveNewKnowledgeEntry(NotificationFlagInfo nfi)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "HandleOnNotificationAdded")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ShowPanelLogSubCategoryNotificationIcon")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void AddNotificationToKnowledgeSubCategory(string descId)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "HandleOnSubcategoryNotificationRemoved")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ShowPanelLogSubCategoryNotificationIcon")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
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
