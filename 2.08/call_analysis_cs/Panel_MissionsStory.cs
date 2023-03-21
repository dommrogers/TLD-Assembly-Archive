using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.Serialization;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;

public class Panel_MissionsStory : Panel_AutoReferenced, INotificationHandler
{
	private enum NavArea
	{
		Category,
		Missions
	}

	private enum PanelState
	{
		Main,
		Side,
		Completed
	}

	public static int OBJECT_POOL_SIZE;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public ScrollList m_MainMissionScrollList;

	public ScrollList m_SideMissionScrollList;

	public ScrollList m_CompletedMissionScrollList;

	public GameObject m_MissionListScrollbar;

	public UITexture m_EpisodeOnePoster;

	public UITexture m_EpisodeTwoPoster;

	public GameObject m_SectionNavSelected;

	public GameObject m_TabsMainObject;

	public GameObject m_TabsSideObject;

	public GameObject m_TabsCompletedObject;

	public GameObject m_RightPageObject;

	public GameObject m_MissionObjectivePrefab;

	public Transform m_MissionObjetivePoolParent;

	public Transform m_MissionObjetiveActiveObjects;

	public UILabel m_SelectedMissionName;

	public UILabel m_TimerLabel;

	public UISprite m_TimerBGSprite;

	public GameObject m_TimerObject;

	public UILabel m_SideMissionDescLabel;

	public UILabel m_CompletedMissionDescLabel;

	public UIPanel m_MissionDescPanel;

	public Transform m_MissionDescPanelOffset;

	public GameObject m_MissionDescScrollbar;

	public UIButton[] m_FilterButtons;

	public GameObject m_Button_Back;

	public GameObject m_Button_SeeMap;

	public GameObject m_Button_Main;

	public GameObject m_Button_Side;

	public GameObject m_Button_Completed;

	public UITexture m_MissionArtTexture;

	private GamepadButtonSprite[] m_GamepadButtonSprites;

	public float m_LowTimeValue;

	public int m_PixelBufferDescAndObjectives;

	public int m_PixelBufferTimer;

	public Color m_TimerColorNormal;

	public Color m_TimerColorLowTime;

	public GameObject m_ButtonMainNotificationFlag;

	public GameObject m_ButtonSideNotificationFlag;

	private PanelReference<Panel_Clothing> m_Clothing;

	private PanelReference<Panel_Crafting> m_CraftingPanel;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Inventory> m_Inventory;

	private PanelReference<Panel_Log> m_Log;

	private PanelReference<Panel_Map> m_Map;

	[NonSerialized]
	public bool m_HasBeenUpdated;

	private List<StoryMissionInfo> m_MissionInfoList;

	private List<StoryMissionInfo> m_MissionsToShowScrollList;

	private List<StoryMissionObjective> m_ObjectiveInfoList;

	private List<StoryMissionObjective> m_ObjectivesToShowRightPage;

	private List<StoryMissionListEntry> m_MissionScrollListEntries;

	private int m_CurrentMissionIndex;

	private float m_MissionDescPanelHeight;

	private List<string> m_QueueNotificationHeaders;

	private List<string> m_QueueNotificationBodies;

	private List<StoryMissionInfo> m_ResourceMissionInfoList;

	private List<StoryMissionObjective> m_ResourceObjectiveInfoList;

	private static StoryMissionSaveData m_StoryMissionSaveData;

	private UISlider m_MissionListScrollbarSlider;

	private ScrollList m_MissionScrollList;

	private UILabel m_MissionDescLabel;

	private List<CategoryButton> m_CategoryButtons;

	private int m_SectionNavIndex;

	private UIButton m_ButtonMain;

	private UIButton m_ButtonSide;

	private List<NotificationFlagInfo> m_MissionNewEntry;

	private NotificationFlag m_NotificationFlag;

	private Transform[] m_NotificationFlagChildren;

	private UIButton m_ButtonCompleted;

	private NavArea m_CurrentNavArea;

	private PanelState m_PanelState;

	private static AssetBundleRef s_MissionTexturesBundle;

	private const int FRACTION_OBJ_PRECISION_FACTOR = 100;

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

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "CacheComponents")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "LoadMissionDataFromResources")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_Map), Member = "CenterOn")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateTabsObjects")]
	[Calls(Type = typeof(Panel_Log), Member = "OnMapNav")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "MaybeShowNewMissionEntryNotificationFlagIcon")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshGamepadButtons")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateGamepadControls")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenMapPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(StoryMissionObjective), Member = "CopyConstantDataFromResources")]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateTabsObjects")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshGamepadButtons")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void DeselectAllMissions()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "LoadMissionDataFromResources")]
	public void ClearMissions()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnMissionListEntrySelected")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public void SelectMissionListEntry(string missionID)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateGamepadControls")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnBack")]
	[CallsUnknownMethods(Count = 1)]
	public void OnCancel()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "HandleVerticalMovement")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateGamepadControls")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateGamepadControls")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateTabsObjects")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "NavigateToMissionById")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	public void OnNavigationChanged(UIButton button)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "NavigateToMissionById")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "HandleVerticalMovement")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "HandleVerticalMovement")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateGamepadControls")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "SelectMissionListEntry")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "CanPlaySpecialUIEntrySound")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionListScrollingForCurrentIndex")]
	public void OnMissionListEntrySelected(int index)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void OnExamineCollectible()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void OnSeeLocationOnMap()
	{
	}

	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[CallerCount(Count = 0)]
	public bool ObjectiveIsActiveOrComplete(string objectiveID)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	public StoryMissionObjective GetActiveObjective(string objectiveID)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Action_MissionAddNew), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(HUDChapter), Member = "Enqueue")]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(TrustManager), Member = "AddTrustDecayGracePeriod")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionIndex")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddNotification")]
	public void AddMission(string missionID, bool suppressUI, bool suppressMission, bool suppressChapter)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_MissionUpdateName), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	public void UpdateMissionName(string missionID, string nameLocID, bool suppressUI)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_MissionUpdateDesc), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public void UpdateMissionDesc(string missionID, string descriptionLocID, bool suppressUI)
	{
	}

	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	[CalledBy(Type = typeof(Action_MissionUpdateTexture), Member = "OnExecute")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void UpdateMissionTexture(string missionID, string textureName, bool suppressUI)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Action_MissionUpdateTimer), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	public void UpdateMissionTimer(string missionID, string timerID, bool suppressUI)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public bool TryGetObjectiveIsComplete(string objectiveID, out bool result)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref result) = null;
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_MissionMarkComplete), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionIndex")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void MarkMissionComplete(string missionID, bool missionSuccess, bool suppressUI)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Action_ObjectiveAddNew), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddNotification")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	public void AddObjective(string objectiveID, bool suppressUI)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_ObjectiveUpdateDesc), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public void UpdateObjectiveDesc(string objectiveID, string descriptionLocID, bool suppressUI)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_ObjectiveUpdateTimer), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	public void UpdateObjectiveTimer(string objectiveID, string timerID, bool suppressUI)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_ObjectiveCompleteMain), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public void MarkObjectiveComplete(string objectiveID, bool suppressUI)
	{
	}

	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void MarkObjectiveInvisible(string objectiveID)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearMessage), Member = "AddJournalQueueMessage")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeShowNotificationsInQueue()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddObjective")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapMarkerToMap")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "GetMissionId")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "EnqueueSideMission")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	[CalledBy(Type = typeof(HUDMission), Member = "Enqueue")]
	[CalledBy(Type = typeof(HUDMission), Member = "Enqueue")]
	[CalledBy(Type = typeof(HUDChapter), Member = "Enqueue")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(HUDMission), Member = "Dequeue")]
	public StoryMissionInfo GetMissionInfoFromID(string missionID)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MapIcon), Member = "DoSetup")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "NavigateToMissionById")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public bool IsSideMission(string missionID)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDescScrollbar")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateGamepadControls")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "HandleVerticalRightStick")]
	[CallsUnknownMethods(Count = 4)]
	public void OnScrollbarMissionDescUp()
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateGamepadControls")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "HandleVerticalRightStick")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDescScrollbar")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	public void OnScrollbarMissionDescDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDescScrollbar")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnScrollbarMissionDescChange()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnInventoryNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	public void OnClothingNav()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnFirstAidNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Log), Member = "OnMapNav")]
	[Calls(Type = typeof(Panel_Map), Member = "CenterOn")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnMapNav()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromMissionsStory")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnDailyLogButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromMissionsStory")]
	[CallsUnknownMethods(Count = 1)]
	public void OnStatsButton()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromMissionsStory")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 0)]
	public void OnCollectibleButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromMissionsStory")]
	[CallsUnknownMethods(Count = 1)]
	public void OnRockCachesButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromMissionsStory")]
	[CallsUnknownMethods(Count = 1)]
	public void OnSkillsButton()
	{
	}

	[Calls(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnCraftingButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	public StoryMissionInfo GetTrackedMainMission()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionInfoFromPrefab")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CallsUnknownMethods(Count = 3)]
	public StoryMissionInfo GetTrackedMission()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public List<StoryMissionObjective> GetObjectivesToShow()
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionUI), Member = "UpdateObjectives")]
	[CalledBy(Type = typeof(MissionUI), Member = "UpdateObjectives")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerMode")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(Panel_Container), Member = "CanEnterContainerMissionMode")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
	[CalledBy(Type = typeof(HUDMission), Member = "Dequeue")]
	[CalledBy(Type = typeof(HUDMission), Member = "EnqueueObjective")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "SetObjectiveInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[CallerCount(Count = 11)]
	public StoryMissionObjective GetObjective(string objectiveID)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetCurrentMissionId()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[CallsUnknownMethods(Count = 4)]
	public StoryMissionInfo GetActiveStoryMissionInfo()
	{
		return null;
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateButtonLegend()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnScrollbarMissionDescUp")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnScrollbarMissionDescDown")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnMissionListEntrySelected")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	private void UpdateGamepadControls()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnMissionListEntrySelected")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnMissionListEntrySelected")]
	private void HandleVerticalMovement(float movement)
	{
	}

	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnScrollbarMissionDescUp")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnScrollbarMissionDescDown")]
	private void HandleVerticalRightStick(float verticalRS)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnCancel")]
	private void OnBack()
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionName")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDesc")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTexture")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTimer")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkMissionComplete")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveDesc")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveTimer")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveComplete")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveInvisible")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "FSMForceRefresh")]
	[CalledBy(Type = typeof(Action_ObjectiveToggleInvisible), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddObjective")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionListScrollingForCurrentIndex")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshMissionsToShow")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetNumObjectivesForMission")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetNumCompletedObjectivesForMission")]
	[Calls(Type = typeof(StoryMissionListEntry), Member = "Refresh")]
	[Calls(Type = typeof(StoryMissionListEntry), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetNumObjectivesForMission")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetNumCompletedObjectivesForMission")]
	[Calls(Type = typeof(StoryMissionListEntry), Member = "Refresh")]
	[Calls(Type = typeof(StoryMissionListEntry), Member = "SetSelected")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	private void RefreshScrollList()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionListScrollIndex")]
	public void OnScrollbarMissionListChanged()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMissionListEntrySelected")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionListScrollIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	public void UpdateMissionListScrollingForCurrentIndex()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalActionFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromObjective")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnMissionListEntrySelected")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalActionFromObjective")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "IsSideMission")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public void NavigateToMissionById(string missionId)
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionListScrollingForCurrentIndex")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnScrollbarMissionListChanged")]
	private int GetMissionListScrollIndex()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionName")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(MissionObjectiveEntry), Member = "SetObjectiveInfo")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "SetupMissionDescScrollbar")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMissionListEntrySelected")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDesc")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTimer")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkMissionComplete")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddObjective")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveDesc")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveTimer")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveComplete")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveInvisible")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "FSMForceRefresh")]
	[CalledBy(Type = typeof(Action_ObjectiveToggleInvisible), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTexture")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(MissionTimer), Member = "get_Time")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshObjectivesToShow")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionTimerByName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(MissionTimer), Member = "get_Time")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void RefreshDescriptionPage()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 12)]
	private void RefreshMissionsToShow()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	private bool HasSideMissionsInLog()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private bool HasCompletedMissionsInLog()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionInfoFromPrefab")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[CallsUnknownMethods(Count = 4)]
	public void RefreshObjectivesToShow(string missionID)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public StoryMissionObjective GetActiveObjectiveForMission(string missionID)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCurrentMissionDisplay")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public void GetAllActiveObjectivesForMission(string missionID, ref List<StoryMissionObjective> results)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 8)]
	public void ResetNotificationsData()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "ShowPanelMissionSubCategoryNotificationIcon")]
	public void HandleOnNotificationAdded(NotificationFlagInfo nfi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[CallsUnknownMethods(Count = 1)]
	public void HandleOnSubcategoryNotificationRemoved(NotificationFlagInfo nfi)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "HandleOnNotificationAdded")]
	public void ShowPanelMissionSubCategoryNotificationIcon(SubCategory subCategory, bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void AddNewMissionEntry(NotificationFlagInfo nfi)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 5)]
	private int GetNumObjectivesForMission(string missionID)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 2)]
	private int GetNumCompletedObjectivesForMission(string missionID)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private void QueueMissionNotification(string header, string body)
	{
	}

	[Calls(Type = typeof(MissionInfo), Member = "ReleaseAllMissionInfos")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Initialize")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "ClearMissions")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(MissionInfo), Member = "GetAllMissionInfos")]
	private void LoadMissionDataFromResources()
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkMissionComplete")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionName")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDesc")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTexture")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTimer")]
	[CallsUnknownMethods(Count = 2)]
	private int GetMissionIndex(string missionID)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveComplete")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveInvisible")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "TryGetObjectiveIsComplete")]
	[CalledBy(Type = typeof(Condition_ObjectiveCompleted), Member = "OnCheck")]
	[CalledBy(Type = typeof(Action_ObjectiveToggleInvisible), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Condition_ObjectiveIsActiveOrComplete), Member = "OnCheck")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveTimer")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "ObjectiveIsActiveOrComplete")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddObjective")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "GetActiveObjective")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(ContainerMissionHoverText), Member = "GetHoverText")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveDesc")]
	private int GetObjectiveIndex(string objectiveID)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private int GetMissionListEntryIndex(string missionID)
	{
		return default(int);
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDescScrollbar")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	private void SetupMissionDescScrollbar(float pixelHeightRightSide)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "SetupMissionDescScrollbar")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnScrollbarMissionDescChange")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnScrollbarMissionDescDown")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnScrollbarMissionDescUp")]
	private void UpdateMissionDescScrollbar()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	private void FSMForceRefresh()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	private void RefreshGamepadButtons()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void UpdateTabsObjects()
	{
	}

	[CallerCount(Count = 0)]
	private void SetPanelState(PanelState panelState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	private static void MaybeLoadMissionTexturesAssetBundle()
	{
	}

	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RemoveNewMissionEntry")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void MaybeShowNewMissionEntryNotificationFlagIcon()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MaybeShowNewMissionEntryNotificationFlagIcon")]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveNewMissionEntry(NotificationFlagInfo nfi)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void CacheComponents()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_MissionsStory()
	{
	}
}
