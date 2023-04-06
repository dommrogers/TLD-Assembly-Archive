using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.Missions;

public class ActiveMissionManager
{
	public Action OnUpdateCallback;

	private readonly List<StoryMissionInfo> m_ResourceMissionInfoList;

	private readonly List<StoryMissionObjective> m_ResourceObjectiveInfoList;

	private readonly List<StoryMissionInfo> m_MissionInfoList;

	private readonly List<StoryMissionObjective> m_ObjectiveInfoList;

	private static ActiveMissionManager s_ActiveMissionManager;

	private static StoryMissionSaveData s_StoryMissionSaveData;

	private const int FRACTION_OBJ_PRECISION_FACTOR = 100;

	private PanelReference<Panel_HUD> m_HUD;

	public static ActiveMissionManager Instance
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public List<StoryMissionInfo> MissionInfoList
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
		get
		{
			return null;
		}
	}

	public List<StoryMissionObjective> ObjectiveInfoList
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 58)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(ActiveMissionManager), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActiveMissionManager), Member = "LoadMissionDataFromResources")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public ActiveMissionManager()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetObjectiveIndex")]
	public bool ObjectiveIsActiveOrComplete(string objectiveID)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetObjectiveIndex")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public StoryMissionObjective GetActiveObjective(string objectiveID)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetObjectiveIndex")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public bool TryGetObjectiveIsComplete(string objectiveID, out bool result)
	{
		result = default(bool);
		return false;
	}

	[CalledBy(Type = typeof(Action_MissionAddNew), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetMissionIndex")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(TrustManager), Member = "AddTrustDecayGracePeriod")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	[Calls(Type = typeof(HUDChapter), Member = "Enqueue")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddNotification")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public void AddMission(string missionID, bool suppressUI, bool suppressMission, bool suppressChapter)
	{
	}

	[CalledBy(Type = typeof(Action_MissionUpdateName), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetMissionIndex")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateMissionName(string missionID, string nameLocID, bool suppressUI)
	{
	}

	[CalledBy(Type = typeof(Action_MissionUpdateDesc), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetMissionIndex")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateMissionDesc(string missionID, string descriptionLocID, bool suppressUI)
	{
	}

	[CalledBy(Type = typeof(Action_MissionUpdateTexture), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetMissionIndex")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateMissionTexture(string missionID, string textureName, bool suppressUI)
	{
	}

	[CalledBy(Type = typeof(Action_MissionUpdateTimer), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetMissionIndex")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateMissionTimer(string missionID, string timerID, bool suppressUI)
	{
	}

	[CalledBy(Type = typeof(Action_MissionMarkComplete), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetMissionIndex")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(HUDMission), Member = "Enqueue")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public void MarkMissionComplete(string missionID, bool missionSuccess, bool suppressUI)
	{
	}

	[CalledBy(Type = typeof(Action_ObjectiveAddNew), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetObjectiveIndex")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddNotification")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public void AddObjective(string objectiveID, bool suppressUI)
	{
	}

	[CalledBy(Type = typeof(Action_ObjectiveUpdateDesc), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetObjectiveIndex")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateObjectiveDesc(string objectiveID, string descriptionLocID, bool suppressUI)
	{
	}

	[CalledBy(Type = typeof(Action_ObjectiveUpdateTimer), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetObjectiveIndex")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateObjectiveTimer(string objectiveID, string timerID, bool suppressUI)
	{
	}

	[CalledBy(Type = typeof(Action_ObjectiveCompleteMain), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetObjectiveIndex")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void MarkObjectiveComplete(string objectiveID, bool suppressUI)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetObjectiveIndex")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void MarkObjectiveInvisible(string objectiveID)
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "NavigateToMissionById")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsSideMission(string missionID)
	{
		return false;
	}

	[CalledBy(Type = typeof(HUDChapter), Member = "Enqueue")]
	[CalledBy(Type = typeof(HUDMission), Member = "Enqueue")]
	[CalledBy(Type = typeof(HUDMission), Member = "Dequeue")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "EnqueueSideMission")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "GetMissionId")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapMarkerToMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "AddObjective")]
	[CallerCount(Count = 11)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public StoryMissionInfo GetMissionInfoFromID(string missionID)
	{
		return null;
	}

	[CalledBy(Type = typeof(ActiveMissionManager), Member = "AddMission")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "UpdateMissionName")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "UpdateMissionDesc")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "UpdateMissionTexture")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "UpdateMissionTimer")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "MarkMissionComplete")]
	[CallerCount(Count = 6)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private int GetMissionIndex(string missionID)
	{
		return 0;
	}

	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "SetObjectiveInfo")]
	[CalledBy(Type = typeof(HUDMission), Member = "EnqueueObjective")]
	[CalledBy(Type = typeof(HUDMission), Member = "Dequeue")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(MissionUI), Member = "UpdateObjectives")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "CanEnterContainerMissionMode")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerMode")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetObjectiveIndex")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public StoryMissionObjective GetObjective(string objectiveID)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	public StoryMissionInfo GetActiveStoryMissionInfo()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public bool HasSideMissionsInLog()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public bool HasCompletedMissionsInLog()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	public StoryMissionInfo GetTrackedMainMission()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionInfoFromPrefab")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AreTalesAvailable")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public StoryMissionInfo GetTrackedMission(bool maybeGetCompleted = false)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 7)]
	public void GetAllActiveObjectivesForMission(string missionID, ref List<StoryMissionObjective> results)
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CallsUnknownMethods(Count = 4)]
	public int GetNumObjectivesForMission(string missionID)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CallsUnknownMethods(Count = 4)]
	public int GetNumCompletedObjectivesForMission(string missionID)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ActiveMissionManager), Member = "LoadMissionDataFromResources")]
	[CallsUnknownMethods(Count = 1)]
	public void ClearMissions()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(StoryMissionObjective), Member = "CopyConstantDataFromResources")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(ContainerMissionHoverText), Member = "GetHoverText")]
	[CalledBy(Type = typeof(Condition_ObjectiveIsActiveOrComplete), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_ObjectiveCompleted), Member = "OnCheck")]
	[CalledBy(Type = typeof(Action_ObjectiveToggleInvisible), Member = "OnExecute")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "ObjectiveIsActiveOrComplete")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "GetActiveObjective")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "TryGetObjectiveIsComplete")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "AddObjective")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "UpdateObjectiveDesc")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "UpdateObjectiveTimer")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "MarkObjectiveComplete")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "MarkObjectiveInvisible")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "GetObjective")]
	[CallerCount(Count = 13)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private int GetObjectiveIndex(string objectiveID)
	{
		return 0;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = ".ctor")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "ClearMissions")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MissionInfo), Member = "GetAllMissionInfos")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(ObjectiveInfo), Member = "GetSubObjectives")]
	[Calls(Type = typeof(MissionInfo), Member = "ReleaseAllMissionInfos")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 69)]
	private void LoadMissionDataFromResources()
	{
	}
}
