using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using UnityEngine;

public class Panel_MissionsStory : Panel_Base
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
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[Calls(Type = typeof(Panel_MissionsStory), Member = "LoadMissionDataFromResources")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsUnknownMethods(Count = 48)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "CacheComponents")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "MaybeShowNewMissionEntryNotificationFlagIcon")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateTabsObjects")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnMapNav")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshGamepadButtons")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenMapPressed")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateGamepadControls")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(StoryMissionObjective), Member = "CopyConstantDataFromResources")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshGamepadButtons")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateTabsObjects")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void DeselectAllMissions()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "LoadMissionDataFromResources")]
	public void ClearMissions()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnMissionListEntrySelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	public void SelectMissionListEntry(string missionID)
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateGamepadControls")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnBack")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	public void OnCancel()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(StoryMissionListEntry), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateTabsObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "HandleVerticalMovement")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "NavigateToMissionById")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "CanPlaySpecialUIEntrySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public void OnNavigationChanged(UIButton button)
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "SelectMissionListEntry")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "HandleVerticalMovement")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "NavigateToMissionById")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionListScrollingForCurrentIndex")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "CanPlaySpecialUIEntrySound")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	public void OnMissionListEntrySelected(int index)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void OnExamineCollectible()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void OnSeeLocationOnMap()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	public bool ObjectiveIsActiveOrComplete(string objectiveID)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public StoryMissionObjective GetActiveObjective(string objectiveID)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 37)]
	[CalledBy(Type = typeof(Action_MissionAddNew), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionIndex")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(TrustManager), Member = "AddTrustDecayGracePeriod")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	[Calls(Type = typeof(HUDChapter), Member = "Enqueue")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddNotification")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	public void AddMission(string missionID, bool suppressUI, bool suppressMission, bool suppressChapter)
	{
	}

	[CalledBy(Type = typeof(Action_MissionUpdateName), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public void UpdateMissionName(string missionID, string nameLocID, bool suppressUI)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Action_MissionUpdateDesc), Member = "OnExecute")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void UpdateMissionDesc(string missionID, string descriptionLocID, bool suppressUI)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Action_MissionUpdateTexture), Member = "OnExecute")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public void UpdateMissionTexture(string missionID, string textureName, bool suppressUI)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Action_MissionUpdateTimer), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	public void UpdateMissionTimer(string missionID, string timerID, bool suppressUI)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool TryGetObjectiveIsComplete(string objectiveID, out bool result)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref result) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Action_MissionMarkComplete), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionIndex")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void MarkMissionComplete(string missionID, bool missionSuccess, bool suppressUI)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Action_ObjectiveAddNew), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddNotification")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	public void AddObjective(string objectiveID, bool suppressUI)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Action_ObjectiveUpdateDesc), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	public void UpdateObjectiveDesc(string objectiveID, string descriptionLocID, bool suppressUI)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Action_ObjectiveUpdateTimer), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	public void UpdateObjectiveTimer(string objectiveID, string timerID, bool suppressUI)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Action_ObjectiveCompleteMain), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	public void MarkObjectiveComplete(string objectiveID, bool suppressUI)
	{
	}

	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void MarkObjectiveInvisible(string objectiveID)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearMessage), Member = "AddJournalQueueMessage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void MaybeShowNotificationsInQueue()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddObjective")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapMarkerToMap")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "GetMissionId")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "EnqueueSideMission")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	[CalledBy(Type = typeof(HUDMission), Member = "Enqueue")]
	[CalledBy(Type = typeof(HUDChapter), Member = "Enqueue")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(HUDMission), Member = "Dequeue")]
	public StoryMissionInfo GetMissionInfoFromID(string missionID)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "NavigateToMissionById")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public bool IsSideMission(string missionID)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDescScrollbar")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "HandleVerticalRightStick")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateGamepadControls")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	public void OnScrollbarMissionDescUp()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateGamepadControls")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDescScrollbar")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "HandleVerticalRightStick")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	public void OnScrollbarMissionDescDown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDescScrollbar")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnScrollbarMissionDescChange()
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

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Panel_Map), Member = "ShowNoMapsUnlockedMessage")]
	[Calls(Type = typeof(Panel_Map), Member = "CenterOn")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Map), Member = "NoMapsUnlocked")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "OnMapNav")]
	public void OnMapNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromMissionsStory")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDailyLogButton()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnableFromMissionsStory")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	public void OnStatsButton()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromMissionsStory")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnCollectibleButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromMissionsStory")]
	[CallsUnknownMethods(Count = 1)]
	public void OnRockCachesButton()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromMissionsStory")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnSkillsButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	public void OnCraftingButton()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public StoryMissionInfo GetTrackedMainMission()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionInfoFromPrefab")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public StoryMissionInfo GetTrackedMission()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public List<StoryMissionObjective> GetObjectivesToShow()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerMode")]
	[CalledBy(Type = typeof(Panel_Container), Member = "CanEnterContainerMissionMode")]
	[CalledBy(Type = typeof(MissionUI), Member = "UpdateObjectives")]
	[CalledBy(Type = typeof(MissionUI), Member = "UpdateObjectives")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
	[CalledBy(Type = typeof(HUDMission), Member = "EnqueueObjective")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "SetObjectiveInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(HUDMission), Member = "Dequeue")]
	[CallerCount(Count = 10)]
	public StoryMissionObjective GetObjective(string objectiveID)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public string GetCurrentMissionId()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[CallsUnknownMethods(Count = 3)]
	public StoryMissionInfo GetActiveStoryMissionInfo()
	{
		return null;
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnScrollbarMissionDescUp")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnScrollbarMissionDescDown")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "HandleVerticalMovement")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	private void UpdateGamepadControls()
	{
	}

	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnMissionListEntrySelected")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateGamepadControls")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void HandleVerticalMovement(float movement)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnScrollbarMissionDescDown")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnScrollbarMissionDescUp")]
	private void HandleVerticalRightStick(float verticalRS)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnCancel")]
	private void OnBack()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionName")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDesc")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkMissionComplete")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTimer")]
	[CallsUnknownMethods(Count = 51)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddObjective")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveTimer")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveComplete")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveInvisible")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "FSMForceRefresh")]
	[CalledBy(Type = typeof(Action_ObjectiveToggleInvisible), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTexture")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveDesc")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshMissionsToShow")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetNumObjectivesForMission")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetNumCompletedObjectivesForMission")]
	[Calls(Type = typeof(StoryMissionListEntry), Member = "Refresh")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetNumObjectivesForMission")]
	[Calls(Type = typeof(StoryMissionListEntry), Member = "SetSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionListScrollingForCurrentIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(StoryMissionListEntry), Member = "SetSelected")]
	[Calls(Type = typeof(StoryMissionListEntry), Member = "Refresh")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetNumCompletedObjectivesForMission")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	private void RefreshScrollList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionListScrollIndex")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarMissionListChanged()
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMissionListEntrySelected")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionListScrollIndex")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	public void UpdateMissionListScrollingForCurrentIndex()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromObjective")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnMissionListEntrySelected")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "IsSideMission")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void NavigateToMissionById(string missionId)
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionListScrollingForCurrentIndex")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnScrollbarMissionListChanged")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	private int GetMissionListScrollIndex()
	{
		return default(int);
	}

	[Calls(Type = typeof(MissionObjectiveEntry), Member = "SetObjectiveInfo")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "SetupMissionDescScrollbar")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMissionListEntrySelected")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionName")]
	[CallsUnknownMethods(Count = 43)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTimer")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkMissionComplete")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddObjective")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveDesc")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveTimer")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveComplete")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveInvisible")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "FSMForceRefresh")]
	[CalledBy(Type = typeof(Action_ObjectiveToggleInvisible), Member = "OnExecute")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDesc")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTexture")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshObjectivesToShow")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionTimerByName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(MissionTimer), Member = "get_Time")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(MissionTimer), Member = "get_Time")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void RefreshDescriptionPage()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void RefreshMissionsToShow()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	private bool HasSideMissionsInLog()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	private bool HasCompletedMissionsInLog()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionInfoFromPrefab")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void RefreshObjectivesToShow(string missionID)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public StoryMissionObjective GetActiveObjectiveForMission(string missionID)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCurrentMissionDisplay")]
	[CallsUnknownMethods(Count = 7)]
	public void GetAllActiveObjectivesForMission(string missionID, ref List<StoryMissionObjective> results)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void ResetNotificationsData()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "ShowPanelMissionSubCategoryNotificationIcon")]
	[CallsUnknownMethods(Count = 2)]
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
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "HandleOnNotificationAdded")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[CallerCount(Count = 1)]
	public void ShowPanelMissionSubCategoryNotificationIcon(SubCategory subCategory, bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void AddNewMissionEntry(NotificationFlagInfo nfi)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 4)]
	private int GetNumObjectivesForMission(string missionID)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	private int GetNumCompletedObjectivesForMission(string missionID)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 7)]
	private void QueueMissionNotification(string header, string body)
	{
	}

	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[CallsUnknownMethods(Count = 80)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "ClearMissions")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Initialize")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	private void LoadMissionDataFromResources()
	{
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionName")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDesc")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTexture")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTimer")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkMissionComplete")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private int GetMissionIndex(string missionID)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveInvisible")]
	[CalledBy(Type = typeof(Condition_ObjectiveIsActiveOrComplete), Member = "OnCheck")]
	[CalledBy(Type = typeof(Action_ObjectiveToggleInvisible), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveTimer")]
	[CalledBy(Type = typeof(Condition_ObjectiveCompleted), Member = "OnCheck")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveDesc")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveComplete")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "TryGetObjectiveIsComplete")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddObjective")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "ObjectiveIsActiveOrComplete")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "GetActiveObjective")]
	[CalledBy(Type = typeof(ContainerMissionHoverText), Member = "GetHoverText")]
	private int GetObjectiveIndex(string objectiveID)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	private int GetMissionListEntryIndex(string missionID)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDescScrollbar")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 1)]
	private void SetupMissionDescScrollbar(float pixelHeightRightSide)
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnScrollbarMissionDescUp")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "SetupMissionDescScrollbar")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnScrollbarMissionDescChange")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnScrollbarMissionDescDown")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
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

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void RefreshGamepadButtons()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void UpdateTabsObjects()
	{
	}

	[CallerCount(Count = 0)]
	private void SetPanelState(PanelState panelState)
	{
	}

	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static void MaybeLoadMissionTexturesAssetBundle()
	{
	}

	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RemoveNewMissionEntry")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	private void MaybeShowNewMissionEntryNotificationFlagIcon()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MaybeShowNewMissionEntryNotificationFlagIcon")]
	[CallsUnknownMethods(Count = 3)]
	private void RemoveNewMissionEntry(NotificationFlagInfo nfi)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Initialize")]
	[CallsUnknownMethods(Count = 5)]
	private void CacheComponents()
	{
	}

	[CallsUnknownMethods(Count = 49)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	public Panel_MissionsStory()
	{
	}
}
