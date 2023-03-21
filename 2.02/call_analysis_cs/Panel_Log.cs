using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using SpecialEvents;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Log : Panel_Base
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
		SurveyScreen
	}

	public class LogMissionInfo
	{
		public string name;

		public string description;

		public string[] checklistKeys;

		public string[] checklistValues;

		public bool[] checklistBools;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

		public static Comparison<CairnInfo> _003C_003E9__262_0;

		public static Comparison<AuroraScreenInfo> _003C_003E9__262_1;

		public static Comparison<SurveyAchievementInfo> _003C_003E9__366_3;

		public static Comparison<SurveyAchievementInfo> _003C_003E9__366_4;

		public static Comparison<SurveyRegionInfo> _003C_003E9__366_0;

		public static Comparison<SurveyRegionInfo> _003C_003E9__366_1;

		public static Comparison<SurveyRegionInfo> _003C_003E9__366_2;

		public static Comparison<RegionInfo> _003C_003E9__495_0;

		public static Comparison<RegionInfo> _003C_003E9__495_1;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCollectibleList_003Eb__262_0(CairnInfo x, CairnInfo y)
		{
			return default(int);
		}

		[Calls(Type = typeof(string), Member = "CompareTo")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal int _003CBuildCollectibleList_003Eb__262_1(AuroraScreenInfo x, AuroraScreenInfo y)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "CompareTo")]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCartographyRegionList_003Eb__366_3(SurveyAchievementInfo a, SurveyAchievementInfo b)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "CompareTo")]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCartographyRegionList_003Eb__366_4(SurveyAchievementInfo a, SurveyAchievementInfo b)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "CompareTo")]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCartographyRegionList_003Eb__366_0(SurveyRegionInfo a, SurveyRegionInfo b)
		{
			return default(int);
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "CompareTo")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal int _003CBuildCartographyRegionList_003Eb__366_1(SurveyRegionInfo a, SurveyRegionInfo b)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "CompareTo")]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CBuildCartographyRegionList_003Eb__366_2(SurveyRegionInfo a, SurveyRegionInfo b)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "CompareTo")]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CGenerateRockCacheScreenData_003Eb__495_0(RegionInfo a, RegionInfo b)
		{
			return default(int);
		}

		[Calls(Type = typeof(string), Member = "CompareTo")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CGenerateRockCacheScreenData_003Eb__495_1(RegionInfo a, RegionInfo b)
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

	private int m_SandboxSelectedIndex;

	private List<LogListItem> m_CollectibleList;

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

	private SandboxRecord m_SandboxRecordAtDeath;

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

	private AssetBundleRef m_LogImagesBundle;

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

	private int m_AlmanacListSelectedIndex;

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

	public int m_TotalNumPostcardCollectibles;

	public int m_TotalNumCairnCollectibles;

	public int m_TotalNumAuroraScreenCollectibles;

	public string m_NotesSpriteNameSmall;

	public string m_NotesSpriteNameBig;

	public string m_MatchbooksSpriteNameSmall;

	public string m_MatchbooksSpriteNameBig;

	public string m_PostcardsSpriteNameSmall;

	public string m_PostcardsSpriteNameBig;

	public string m_CairnsSpriteNameSmall;

	public string m_CairnsSpriteNameBig;

	public string m_AuroraScreensSpriteNameSmall;

	public string m_AuroraScreensSpriteNameBig;

	public string m_SurveyScreenSpriteNameSmall;

	public string m_SurveyScreenSpriteNameBig;

	private bool m_CollectionsToggle;

	private CollectionsType m_CollectionsCurrType;

	private List<CollectionListItem> m_CollectionList;

	private int m_CollectionListSelectedIndex;

	private int m_CurrNumNoteCollectibles;

	private int m_CurrNumMatchbookCollectibles;

	private int m_CurrNumPostcardCollectibles;

	private int m_CurrNumCairnCollectibles;

	private int m_CurrNumAuroraScreenCollectibles;

	private List<CollectionListItemInfo> m_CollectionDataList;

	private List<NotificationFlagInfo> m_CollectionsNewEntry;

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
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[Calls(Type = typeof(Panel_Log), Member = "CacheComponents")]
	[Calls(Type = typeof(Panel_Log), Member = "InstantiateLogGridItems")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[Calls(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectionListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSectionNavButtonColors")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewKnowledgeEntry")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForKnowledgeSubCategories")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewCollectionEntry")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Panel_Log), Member = "DoSectionNavUpdate")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	private void FixedUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsUnknownMethods(Count = 5)]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "UpdateCurrentGameLabel")]
	[Calls(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "CanPlaySpecialUIEntrySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameManager), Member = "MaybeForceGC")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Panel_Log), Member = "SetUpTopNav")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[Calls(Type = typeof(DetailedStatsView), Member = "Start")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[Calls(Type = typeof(SummaryStatsView), Member = "Start")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public override void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Disable()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void EnableTableOfContentsView()
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnMissionsNav")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnJournalNav")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnMissionNav")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnJournalNav")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnMissionsNav")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnJournalNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnMissionsNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnJournalNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnJournalNav")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalAction")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnMissionsNav")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnJournalNav")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnMissionsNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnLog")]
	[Calls(Type = typeof(Utils), Member = "GetTitleString")]
	[Calls(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[Calls(Type = typeof(Utils), Member = "XPModeIsChallenge")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSectionNavButtonColors")]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void EnableFromRadial(PanelLogState state)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "SetRegionAndRockCacheSelected")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSectionNavButtonColors")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	public void EnableRockCacheStateFromMap(string sceneName, string rockCacheCustomName)
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnStatsButton")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSectionNavButtonColors")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnDailyLogButton")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnCollectibleButton")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnRockCachesButton")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnSkillsButton")]
	[CallsUnknownMethods(Count = 1)]
	public void EnableFromMissionsStory(PanelLogState state)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalActionFromMap")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSectionNavButtonColors")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "NavigateToMissionById")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	public void EnableFromMap(string missionId)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "NavigateToMissionById")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSectionNavButtonColors")]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalActionFromObjective")]
	[CallsUnknownMethods(Count = 2)]
	public void EnableFromObjective(string missionId)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void EnableDailyView()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnLog")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[CallsUnknownMethods(Count = 1)]
	public void EnableStatsView()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "BeginFadeIn")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSectionNavButtonColors")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[Calls(Type = typeof(Log), Member = "LockInTodaysValues")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	public void EnableDeathView()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsAlmanac")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsMissions")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnCancel")]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallerCount(Count = 18)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "OnMapNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(Type = typeof(Panel_Log), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "QuitToMainMenuOnBack")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "UncacheSandboxRecord")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "OnQuitToMainMenu")]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	public void OnBack()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	public void OnTocScrollbarChange()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTocViewSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSandboxLimitNotificationConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableTableOfContentsView")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log_Toc_GridItem), Member = "Update")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Log_Toc_GridItem), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	public void OnTocItemClicked(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	public void LogGridItemCallback(int entryNum)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	public void LogListItemCallback(int indexClicked)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[CallerCount(Count = 0)]
	public void OnWriteButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	public void OnStatus()
	{
	}

	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnInventory()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallsUnknownMethods(Count = 5)]
	public void OnScrollbarDaysUp()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	public void OnScrollbarDaysDown()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	public void OnScrollbarDaysChange()
	{
	}

	[Calls(Type = typeof(DetailedStatsView), Member = "OnScrollBarPositionChanged")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	public void OnScrollbarCollectiblesUp()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallsUnknownMethods(Count = 5)]
	public void OnScrollbarCollectiblesDown()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallerCount(Count = 0)]
	public void OnScrollbarCollectiblesChange()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateStatsSlider")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	public void OnScrollbarDayStatsUp()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateStatsSlider")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallerCount(Count = 2)]
	public void OnScrollbarDayStatsDown()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateStatsSlider")]
	public void OnScrollbarStatsDaysChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public void OnScrollbarNotesUp()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMouseScrollControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	public void OnScrollbarNotesDown()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesSlider")]
	public void OnScrollbarNotesChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	public void OnScrollbarExamineCollectibleUp()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[CallsUnknownMethods(Count = 6)]
	public void OnScrollbarExamineCollectibleDown()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateExamineCollectibleSlider")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnScrollbarExamineCollectibleChange()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnEnterGeneralNotes()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnShowDayStats")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[Calls(Type = typeof(Panel_Log), Member = "NotesToggle")]
	[CallerCount(Count = 0)]
	public void OnShowDayStats()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnWriteButton")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[Calls(Type = typeof(Panel_Log), Member = "CanEditJournal")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	public void NoteTakingStart()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void OnReadText()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnDailyLogButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnStatsButton()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnCollectibleButton()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnRockCachesButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnCartographyButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnExamineCollectible()
	{
	}

	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	public void OnInventoryNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	public void OnClothingNav()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[Calls(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnCraftingNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	public void OnFirstAidNav()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[Calls(Type = typeof(Panel_Map), Member = "ShowNoMapsUnlockedMessage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[Calls(Type = typeof(Panel_Map), Member = "NoMapsUnlocked")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	public void OnMapNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsUnknownMethods(Count = 1)]
	public void OnJournalNav()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnMissionsNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Panel_Log), Member = "AddNotificationToKnowledgeSubCategory")]
	[Calls(Type = typeof(Panel_Log), Member = "ShowPanelLogMainCategoryNotificationIcon")]
	[CallsUnknownMethods(Count = 4)]
	public void HandleOnNotificationAdded(NotificationFlagInfo nfi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "RemoveNotificationFromKnowledgeSubCategory")]
	public void HandleOnSubcategoryNotificationRemoved(NotificationFlagInfo nfi)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void HandleOnMainCategoryNotificationRemoved(NotificationFlagInfo nfi)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleOnNotificationAdded")]
	[CallsUnknownMethods(Count = 2)]
	public void ShowPanelLogMainCategoryNotificationIcon(MainCategory mainCategory, bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromObjective")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableRockCacheStateFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMissionsStory")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDailyView")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectionListSelectionScroll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustListSelectionScroll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetWhatIKnowListSelectedToEntry")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListSelectionScroll")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[CalledBy(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateExamineCollectible")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateAlmanacPage")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	private void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ExitInterfaceOnDeath()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "ReallyQuitToMainMenu")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ForceQuit")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnQuitToMainMenu")]
	private void ExitInterface()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CallsUnknownMethods(Count = 8)]
	public void OnQuitToMainMenu()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[CallerCount(Count = 0)]
	public void ForceQuit()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[CallsUnknownMethods(Count = 2)]
	private bool QuitToMainMenuOnBack()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Log), Member = "QuitToMainMenuOnBack")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateAlmanacPage")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildSkillsList")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildTrustList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildRockCacheRegionScrollList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 39)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 21)]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableAllLBRBButtons")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateExamineCollectible")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	private void EnterState(PanelLogState newState)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log_Toc_GridItem), Member = "OnClick")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DetailedStatsView), Member = "Start")]
	[Calls(Type = typeof(SummaryStatsView), Member = "Start")]
	[Calls(Type = typeof(Panel_Log), Member = "UncacheSandboxRecord")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	public void ViewSandbox()
	{
	}

	[Calls(Type = typeof(DateTime), Member = "ToString")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRenameSandboxConfirmed")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SandboxRecord), Member = "GetSurvivalRecordSummaryText")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	private void UpdateTOCSelection()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[CallsUnknownMethods(Count = 8)]
	public void OnDeleteSandbox()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	public void OnDeleteSandboxConfirmed()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CallsUnknownMethods(Count = 21)]
	public void OnRenameSandbox()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	public void OnRenameSandboxConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsUnknownMethods(Count = 2)]
	public void OnRenameSandboxCancelled(bool wasCancelled)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void OnOverwriteSandbox()
	{
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void ResetNotificationsData()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "ReallySaveJournal")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnOverwriteSandboxConfirmed()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	[CallsUnknownMethods(Count = 8)]
	private void OnSandboxLimitNotification()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	private void OnSandboxLimitNotificationConfirmed()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "ReallySaveJournal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSandboxLimitNotification")]
	public void OnSaveJournal()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[CallsUnknownMethods(Count = 57)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(StatContainer), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "InstantiateGearFromPrefabName")]
	private void UncacheSandboxRecord(SandboxRecord record)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnOverwriteSandboxConfirmed")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	private void ReallySaveJournal()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateStatsSlider")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "NotesToggle")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsUnknownMethods(Count = 52)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "ClearGrid")]
	[Calls(Type = typeof(Log), Member = "GetInfoForDay")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateDailyStatsPage()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsDown")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarStatsDaysChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsUp")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	private void UpdateStatsSlider()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesSlider")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Log), Member = "CanEditJournal")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Log), Member = "GetInfoForDay")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateNotesPage()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateExamineCollectible")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarExamineCollectibleChange")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallerCount(Count = 2)]
	private void UpdateExamineCollectibleSlider()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarNotesChange")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	private void UpdateNotesSlider()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(UILabel), Member = "get_printedSize")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesSlider")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsUnknownMethods(Count = 43)]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesUp")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesDown")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateNotesSlider")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(TextInputField), Member = "GetCursorLocation")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(Input), Member = "GetMouseButton")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(Log), Member = "EnterNotesForDay")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	private void CheckForNotesChange()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnCollectionsSubScreen")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectionsPage")]
	[Calls(Type = typeof(Panel_Log), Member = "SetCollectionSubscreenNameLabel")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateCollectibleList()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateExamineCollectibleSlider")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Refresh")]
	[CallsUnknownMethods(Count = 49)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateExamineCollectible()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewOverwriteButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRenameSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewButtons")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	private void BuildTOCList()
	{
	}

	[Calls(Type = typeof(DetailedStatsView), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SummaryStatsView), Member = "Start")]
	private void BuildStatsView()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarDaysChange")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(LogGridItem), Member = "SetupAsDayEntry")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Log), Member = "GetInfoForDay")]
	private void BuildDailyList(bool doSelectionReset)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnCollectionsSubScreen")]
	[CallsUnknownMethods(Count = 137)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(LogGridItem), Member = "SetupAsCollectibleEntry")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectionsList")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(LogGridItem), Member = "SetupAsCollectionEntry")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(LogGridItem), Member = "HideAll")]
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
	private void BuildCollectibleList(bool doSelectionReset)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	private void ClearGrid(UIGrid gridToClear)
	{
	}

	[CallerCount(Count = 0)]
	private bool ShouldShowNotes()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private bool CanEditJournal()
	{
		return default(bool);
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[CallsUnknownMethods(Count = 2)]
	private bool CanSaveJournal()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustListSelectionScroll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectionListSelectionScroll")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListSelectionScroll")]
	private void ScrollListMovement(int moveVal)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[Calls(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	private void DoScrollListScrollLeft()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesUp")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsUp")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesDown")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private void DoScrollListScrolLRight()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	private void DoControlsCollectibleList()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "NotesToggle")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[Calls(Type = typeof(Panel_Log), Member = "CanEditJournal")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "CanEditJournal")]
	[Calls(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	private void DoControlsDailyListStats()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStats")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	[Calls(Type = typeof(DetailedStatsView), Member = "ScrollUp")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	[Calls(Type = typeof(DetailedStatsView), Member = "ScrollDown")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	private void DoControlsStats()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStats")]
	public void OnResetAllTimeStats()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarExamineCollectibleUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarExamineCollectibleDown")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarExamineCollectibleUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarExamineCollectibleDown")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void DoControlsExamineCollectible()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void UpdateTocViewButtons()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRenameSandbox")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "GetRenamePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewButtons")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "OnDeleteSandbox")]
	private void DoControlsTOCView()
	{
	}

	[CallsUnknownMethods(Count = 3)]
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

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildTOCList")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void UpdateTocViewOverwriteButtons()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewSelection")]
	[Calls(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRenameSandbox")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "OnOverwriteSandbox")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTocViewOverwriteButtons")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetRenamePressed")]
	private void DoControlsTOCViewOverwrite()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshActivePanelStates")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveSectionNavToButton")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveSectionNavToButton")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	private void DoSectionNavControls()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "SetUpTopNav")]
	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 3)]
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

	[Calls(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsAlmanac")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsMissions")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[Calls(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[Calls(Type = typeof(Panel_Log), Member = "DisableAllMouseButtons")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void DoControls()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDaysUp")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDaysDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsDown")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesDown")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarNotesUp")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesUp")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDayStatsUp")]
	private void DoMouseScrollControls()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSectionNavButtonColors")]
	private void UpdateNavigationButtons()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	private void BeginFadeIn()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void OnFinalScreenShown()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Log), Member = "ToggleButtonColliders")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ToggleButtonColliders")]
	[CallsUnknownMethods(Count = 6)]
	private void ToggleButtonColliders(Transform transform, bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 30)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshActivePanelStates")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void SetUpTopNav()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	private void UpdateCurrentGameLabel()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSizeIndividual")]
	private void UpdateScrollbarThumbSize()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnMapNav")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableNavigationTabs")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	private void DoMainNavControls()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ShouldRenderOverOtherScreens()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTocViewButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTocViewOverwriteButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	private void ActivateBackButton()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Initialize")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	private void InstantiateLogGridItems()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsUnknownMethods(Count = 7)]
	private void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromObjective")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMap")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	private bool ShouldEnterSectionNav()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void MoveSectionNavToButton(PanelLogState buttonState)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(LogGridItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDaysUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesUp")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarDaysDown")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesDown")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
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
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetNumGridItemsShowing")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
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
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarCollectiblesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarDaysChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(LogGridItem), Member = "SetSelected")]
	[CalledBy(Type = typeof(Panel_Log), Member = "LogGridItemCallback")]
	[Calls(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "DeselectLogGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
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

	[CalledBy(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNavigationButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromObjective")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMap")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMissionsStory")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableRockCacheStateFromMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	private void UpdateSectionNavButtonColors()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void DoSectionNavUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	private Texture2D GetTOCTextureFromRegion(GameRegion region)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromObjective")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectionListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableAllLBRBButtons")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshActivePanelStates")]
	[Calls(Type = typeof(Panel_Log), Member = "MoveSectionNavToButton")]
	[Calls(Type = typeof(Panel_Log), Member = "DeselectLogGridItems")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustListItemsColor")]
	private void EnterSectionNav()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void DeselectLogGridItems()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "EnableSpriteIfActionIs")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "EnableSpriteIfActionIs")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallsUnknownMethods(Count = 4)]
	private void EnableAllLBRBButtons(bool shouldEnable)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Log), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Log), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "SetActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "SetActive")]
	private void SetActiveTab(NavigationTabState state)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	private void SetActive(GameObject go, bool enable)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void CacheComponents()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 46)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(AlmanacGridItem), Member = "ShowFalseBlizzard")]
	[Calls(Type = typeof(AlmanacGridItem), Member = "SetUpGridItem")]
	[Calls(Type = typeof(System.Number), Member = "ParseInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Panel_Log), Member = "InstantiateGridItems")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateAlmanacPage()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnAlmanacButton()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	public void DoControlsAlmanac()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateAlmanacPage")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void InstantiateGridItems()
	{
	}

	[CalledBy(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SurveyRegionListItem), Member = "SetRegionInfo")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public Texture GetRegionButtonTexture(string sceneName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 66)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnForceRevealHiddenDetailsToggle")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetSelected")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetRegionInfo")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void UpdateCartographyPage()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyRegionClicked")]
	[CallsUnknownMethods(Count = 40)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyAchievementScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyScrollbar")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyScrollbar")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyRegionScrollbarChange")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetRegionInfo")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetAchievementInfo")]
	private void RefreshAchievementListForSelectedRegion(bool newRegion)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetSelected")]
	[Calls(Type = typeof(SurveyRegionListItem), Member = "SetSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	protected void OnSurveyRegionClicked(int index)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyRegionClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSurveyScrollbar")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenMapPressed")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	public void DoControlsCartography()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnForceRevealHiddenDetailsToggle()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	private void OnSurveyBack()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[Calls(Type = typeof(SurveyListItem), Member = "SetSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	protected void OnSurveyClicked(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 2)]
	public void OnSurveyRegionScrollbarChange()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	public void OnSurveyAchievementScrollbarChange()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSurveyVerticalNavigation")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	public void HandleSurveyScrollbar(float amount)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyClicked")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Log), Member = "OnSurveyRegionClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSurveyScrollbar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSurveyScrollbar")]
	private void HandleSurveyVerticalNavigation(float amount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 22)]
	private bool UpdateRandomSpawnObjectDuplicates(string foundLocId, List<RandomSpawnObjectAchievementGroup> randomSpawnObjectGroupList, ExperienceModeType emt, List<string> mapElements)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Map), Member = "IsRegionUnlocked")]
	[Calls(Type = typeof(Panel_Map), Member = "GetLocIdsOfUnlockedMapElements")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateCollectionSelectScreenDummyData")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[CallsUnknownMethods(Count = 196)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(SurveyRegionInfo), Member = ".ctor")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "GetExperienceMode")]
	[Calls(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 42)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	private void BuildCartographyRegionList()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "SetCollectionSubscreenNameLabel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateCollectionsPage()
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

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void DoCollectionsToggle()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "SetCollectionSubscreenNameLabel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public void DoControlsCollectionList()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Log), Member = "SetCollectionSubscreenNameLabel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnCollectionsSubScreen()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateCollectionSelectScreenDummyData")]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void BuildCollectionsList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 9)]
	private void AddEntryToList(int scrollIndex, CollectionListItemInfo itemInfo)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	private void UpdateCollectionListSelectionScroll(int moveVal, ref int index)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetSelected")]
	private void UpdateCollectionListItemsColor()
	{
	}

	[CallsUnknownMethods(Count = 56)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectionsList")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshCollectibleCounters")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private List<CollectionListItemInfo> GenerateCollectionSelectScreenDummyData()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private bool IsInCollectionsSelectScreen()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnCollectionsSubScreen")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectionsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	private void SetCollectionSubscreenNameLabel()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateCollectionSelectScreenDummyData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void RefreshCollectibleCounters()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewCollectionEntry")]
	[CallsUnknownMethods(Count = 3)]
	private void RemoveNewCollectionEntry(NotificationFlagInfo nfi)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Panel_Log), Member = "RemoveNewCollectionEntry")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void MaybeShowNotificationFlagForNewCollectionEntry()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetCurrentDayNumber")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsUnknownMethods(Count = 163)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 35)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionInfoFromPrefab")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ChallengeChecklistEntry), Member = "UpdateEntry")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ChallengeChecklistEntry), Member = "UpdateEntry")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	private void UpdateMissionsPage()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "UpdateMissionInfo")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionInfoFromPrefab")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Action_ChallengeNowhereToHideRequirements), Member = "OnUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	public void UpdateMissionInfo(string name, string description, string[] checklistKeys, string[] checklistValues, bool[] checklistBools)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public void RemoveMission(string name)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void ClearMissions()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnMissionsButton()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	public void DoControlsMissions()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CallsUnknownMethods(Count = 48)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionInfo")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshObjectivesToShow")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetTrackedMission")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	private void UpdateMissionInfoFromPrefab()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsUnknownMethods(Count = 71)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateRockCacheScreenData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(RockCacheListItem), Member = "Clear")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(RockCacheListItem), Member = "Clear")]
	private void BuildRockCacheRegionScrollList()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableRockCacheStateFromMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheRegionClicked")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void SetRegionAndRockCacheSelected(string sceneName, string rockCacheName)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildRockCacheRegionScrollList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRegionScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheItemScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRenameRockCacheConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleScrollbar")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleScrollbar")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRegionClicked")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 68)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheUserTextFromGuid")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRegionUnlocked")]
	[Calls(Type = typeof(Panel_Map), Member = "MapElementExists")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheNameFromGuid")]
	private void RefreshRockCacheListForSelectedRegion(bool newRegion)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private int GetNumberOfRockCachesInCurrentRegion()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 2)]
	public void OnRockCacheRegionScrollbarChange()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	public void OnRockCacheItemScrollbarChange()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheNameFromGuid")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetupInputField")]
	public void OnRockCacheRenameButton()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 9)]
	private void OnRenameRockCacheConfirmed()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	public void OnRockCacheEditNoteClicked()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateRockCacheNoteSlider")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	public void OnRockCacheNoteScrollbarUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateRockCacheNoteSlider")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	public void OnRockCacheNoteScrollbarDown()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "UpdateRockCacheNoteSlider")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnRockCacheNoteScrollbarChange()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarUp")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarDown")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	private void UpdateRockCacheNoteSlider()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheEditNoteClicked")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheUserTextFromGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	public void RockCacheNoteTakingStart()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheUserText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybeUpdateNote()
	{
	}

	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(TextInputField), Member = "GetCursorLocation")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarUp")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarDown")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeUpdateNote")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UILabel), Member = "get_printedSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheUserText")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheUserTextFromGuid")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarUp")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheNoteScrollbarDown")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateRockCacheNoteSlider")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public void MaybeUpdateRockCacheNoteView()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheRegionClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheBack")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleScrollbar")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheRenameButton")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenMapPressed")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	private void DoControlsRockCaches()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "MaybeUpdateNote")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	private void OnRockCacheBack()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	public void HandleScrollbar(float amount)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheRegionClicked")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleScrollbar")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	private void HandleVerticalNavigation(float amount)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetRegionAndRockCacheSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	protected void OnRockCacheRegionClicked(int index)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetRegionAndRockCacheSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheUserTextFromGuid")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheNameFromGuid")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(RockCacheListItem), Member = "SetSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	protected void OnRockCacheItemClicked(int index)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Map), Member = "CenterOnPoint")]
	[Calls(Type = typeof(Panel_Map), Member = "ForceZoomIn")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRegionUnlocked")]
	[Calls(Type = typeof(Panel_Log), Member = "OnMapNav")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "SetRegion")]
	public void OnRockCacheShowOnMapClicked()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRegionUnlocked")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildRockCacheRegionScrollList")]
	[CallsUnknownMethods(Count = 67)]
	private void GenerateRockCacheScreenData()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	private void UpdateSkillsPage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Log), Member = "OnSaveJournal")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSkillScrollbar")]
	[Calls(Type = typeof(Panel_Log), Member = "CanSaveJournal")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void DoControlsSkillsListStats()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "HandleSkillScrollbar")]
	[Calls(Type = typeof(SkillsManager), Member = "GetNumSkills")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	private void HandleSkillVerticalNavigation(float amount)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsSkillsListStats")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	private void HandleSkillScrollbar(float amount)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	public void OnScrollbarSkillsChange()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	protected void OnSkillItemClicked(int index)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarSkillsChange")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSkillsPage")]
	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SkillListItem), Member = "SetProgress")]
	[Calls(Type = typeof(SkillsManager), Member = "GetNumSkills")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Skill), Member = "GetProgressToNextLevelAsNormalizedValue")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(SkillListItem), Member = "SetSkillLevel")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkillFromIndex")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Skill), Member = "GetTierPoints")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	private void RefreshSkillsList()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarSkillsChange")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSkillsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillScrollbar")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSkillItemClicked")]
	[CallsUnknownMethods(Count = 69)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierName")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	private void RefreshSelectedSkillDescriptionView()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	private void BuildSkillsList()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarSkillsChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSkillsPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(SkillListItem), Member = "SetSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateSkillListItemsColor()
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoPeopleTabToggle")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "SetupTrustMap")]
	[Calls(Type = typeof(Panel_Log), Member = "SetupNeedsInfo")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	private void UpdateTrustPage()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(TrustMapEntry), Member = "TrustMapClicked")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshTrustMapSelection")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public void OnTrustMapClicked(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnPeopleTrustTab")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnPeopleDescriptionTab")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	public void DoPeopleTabToggle()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "OnTrustMapClicked")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_Log), Member = "DoPeopleTabToggle")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontalRightStick")]
	public void DoControlsTrustList()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateTrustListData")]
	[CallsUnknownMethods(Count = 19)]
	private void BuildTrustList()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void AddTrustEntryToList(int scrollIndex, CollectionListItemInfo itemInfo)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateTrustListSelectionScroll(int moveVal, ref int index)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(CollectionListItem), Member = "SetSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private void UpdateTrustListItemsColor()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(TrustManager), Member = "GetAllTrustIDs")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildTrustList")]
	[CallsUnknownMethods(Count = 37)]
	private void GenerateTrustListData()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetTrustIDFromNameID(string nameLocID)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 40)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "GetStringForNeed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "IsTrustWithinNeedRange")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(TrustManager), Member = "GetNeedTracker")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void SetupNeedsInfo(string trustID)
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetupNeedsInfo")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetGearDisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetGearDisplayName")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public string GetStringForNeed(NeedPrefabSaveData needData)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetupNeedsInfo")]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private bool IsTrustWithinNeedRange(NeedPrefabSaveData needData, string trustID)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 39)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshTrustMapSelection")]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(TrustManager), Member = "GetUnlockableTracker")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void SetupTrustMap(string trustID)
	{
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetupTrustMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnTrustMapClicked")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private void RefreshTrustMapSelection()
	{
	}

	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void DeselectAllTrustMapEntries()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnWhatIKnowSubScreen")]
	[CalledBy(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowDescScrollbar")]
	private void UpdateWhatIKnowPage()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnWhatIKnowButton()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarWhatIKnowDescDown")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "GetOnBackText")]
	[Calls(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Log), Member = "OnScrollbarWhatIKnowDescUp")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "DoScrollListScrollLeft")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void DoControlsWhatIKnowList()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void SetWhatIKnowListSelectedToEntry(string nameLocID)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	private void PointToWhatIKnowEntryOnQuickKeyActive(KnowledgeCateogry category, string nameLocID)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnWhatIKnowSubScreen()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	public void OnWhatIKnowScrollbarChange()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowDescScrollbar")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarWhatIKnowDescUp()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowDescScrollbar")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnScrollbarWhatIKnowDescDown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowDescScrollbar")]
	public void OnWhatIKnowDescScrollbarChange()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "RemoveNotificationFromKnowledgeSubCategory")]
	[Calls(Type = typeof(Panel_Log), Member = "AddNotificationToKnowledgeSubCategory")]
	[CallerCount(Count = 0)]
	public void ShowPanelLogSubCategoryNotificationIcon(SubCategory subCategory, bool enable)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnWhatIKnowDescScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarWhatIKnowDescDown")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarWhatIKnowDescUp")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	private void UpdateWhatIKnowDescScrollbar()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "PointToWhatIKnowEntryOnQuickKeyActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnWhatIKnowSubScreen")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateSubscreenData")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateSubscreenData")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateSubscreenData")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateSelectScreenData")]
	[Calls(Type = typeof(Panel_Log), Member = "GenerateSubscreenData")]
	private void BuildWhatIKnowList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetItemInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 9)]
	private void AddWhatIKnowEntryToList(int scrollIndex, CollectionListItemInfo itemInfo)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Log), Member = "ScrollListMovement")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	private void UpdateWhatIKnowListSelectionScroll(int moveVal, ref int index)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CollectionListItem), Member = "SetSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateWhatIKnowListItemsColor()
	{
	}

	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void GenerateSelectScreenData()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetNameIDFromDescID")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	private void GenerateSubscreenData(List<string> knowledgeList)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetListUnlockedKnowledgeOfType")]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetListUnlockedKnowledgeOfType")]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetListUnlockedKnowledgeOfType")]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetListUnlockedKnowledgeOfType")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildTrustList")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void RefreshCachedKnowledgeUnlocks()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(Panel_Log), Member = "RemoveNewKnowledgeEntry")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	private void MaybeShowNotificationFlagForNewKnowledgeEntry()
	{
	}

	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	private void MaybeShowNotificationFlagForKnowledgeSubCategories()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewKnowledgeEntry")]
	[CallsUnknownMethods(Count = 3)]
	private void RemoveNewKnowledgeEntry(NotificationFlagInfo nfi)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "ShowPanelLogSubCategoryNotificationIcon")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleOnNotificationAdded")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void AddNotificationToKnowledgeSubCategory(string descId)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleOnSubcategoryNotificationRemoved")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ShowPanelLogSubCategoryNotificationIcon")]
	[CallsUnknownMethods(Count = 2)]
	private void RemoveNotificationFromKnowledgeSubCategory(string descId)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 179)]
	public Panel_Log()
	{
	}
}
