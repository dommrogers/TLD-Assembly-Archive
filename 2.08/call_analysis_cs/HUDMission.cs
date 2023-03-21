using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
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

	private Panel_HUD m_HUD;

	public UILabel m_MissionInfo;

	public UILabel m_MissionStatus;

	public MissionStatusDisplaySettings m_DisplaySettings;

	private PanelReference<Panel_MissionsStory> m_MissionsStory;

	public bool m_RestoreDisplay;

	private StatusUpdate m_CurrentStatus;

	private Queue<StatusUpdate> m_Queue;

	private Animator m_Animator;

	private float m_AnimationStartTime;

	private float m_AnimationElapsedSec;

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StatusUpdate), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(HUDMission), Member = "OnAnimationComplete")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CallsUnknownMethods(Count = 3)]
	public void Disable()
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDesc")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTexture")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkMissionComplete")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTimer")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionName")]
	[Calls(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(HUDMission), Member = "Dequeue")]
	public void Enqueue(MissionStatusType type, string id)
	{
	}

	[Calls(Type = typeof(HUDMission), Member = "Dequeue")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EnqueueObjective(MissionStatusType type, string objectiveId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 1)]
	public string GetDebugText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 4)]
	public void HideDisplay()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[CallsUnknownMethods(Count = 3)]
	public void RestoreDisplay()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(HUDMission), Member = "EnqueueObjective")]
	[CalledBy(Type = typeof(HUDMission), Member = "OnAnimationComplete")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(HUDMission), Member = "Enqueue")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(StatusUpdate), Member = "Clear")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void Dequeue()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(HUDMission), Member = "Dequeue")]
	[Calls(Type = typeof(HUDMission), Member = "Disable")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StatusUpdate), Member = "Clear")]
	private void OnAnimationComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public HUDMission()
	{
	}
}
