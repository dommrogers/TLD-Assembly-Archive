using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HUDMission : MonoBehaviour
{
	private struct StatusUpdate
	{
		public string mission;

		public string objective;

		public MissionStatusType type;

		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(HUDMission), Member = "Disable")]
		[CalledBy(Type = typeof(HUDMission), Member = "Dequeue")]
		[CalledBy(Type = typeof(HUDMission), Member = "OnAnimationComplete")]
		public void Clear()
		{
		}

		[CallerCount(Count = 0)]
		public bool IsValid()
		{
			return default(bool);
		}
	}

	public UILabel m_MissionInfo;

	public UILabel m_MissionStatus;

	public MissionStatusDisplaySettings m_DisplaySettings;

	public bool m_RestoreDisplay;

	private StatusUpdate m_CurrentStatus;

	private Queue<StatusUpdate> m_Queue;

	private Animator m_Animator;

	private float m_AnimationStartTime;

	private float m_AnimationElapsedSec;

	[CalledBy(Type = typeof(HUDMission), Member = "OnAnimationComplete")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(StatusUpdate), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Disable()
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTexture")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkMissionComplete")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTimer")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDesc")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionName")]
	[Calls(Type = typeof(HUDMission), Member = "Dequeue")]
	[Calls(Type = typeof(HUDObjectives), Member = "EnqueueSideMission")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	public void Enqueue(MissionStatusType type, string id)
	{
	}

	[CalledBy(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[Calls(Type = typeof(HUDMission), Member = "Dequeue")]
	[CallsUnknownMethods(Count = 3)]
	public void EnqueueObjective(MissionStatusType type, string objectiveId)
	{
	}

	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	public string GetDebugText()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CallsUnknownMethods(Count = 4)]
	public void HideDisplay()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void RestoreDisplay()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(MissionStatusDisplaySettings), Member = "GetWwiseEvent")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CalledBy(Type = typeof(HUDMission), Member = "Enqueue")]
	[CalledBy(Type = typeof(HUDMission), Member = "EnqueueObjective")]
	[CalledBy(Type = typeof(HUDMission), Member = "OnAnimationComplete")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(StatusUpdate), Member = "Clear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(MissionStatusDisplaySettings), Member = "GetLocID")]
	[Calls(Type = typeof(MissionStatusDisplaySettings), Member = "GetLocID")]
	private void Dequeue()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(HUDMission), Member = "Dequeue")]
	[Calls(Type = typeof(HUDMission), Member = "Disable")]
	[Calls(Type = typeof(StatusUpdate), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnAnimationComplete()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HUDMission()
	{
	}
}
