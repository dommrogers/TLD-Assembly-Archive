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

	[Calls(Type = typeof(StatusUpdate), Member = "Clear")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CalledBy(Type = typeof(HUDMission), Member = "OnAnimationComplete")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Disable()
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDesc")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTexture")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionName")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkMissionComplete")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTimer")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(HUDMission), Member = "Dequeue")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Enqueue(MissionStatusType type, string id)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[Calls(Type = typeof(HUDMission), Member = "Dequeue")]
	[CallsUnknownMethods(Count = 2)]
	public void EnqueueObjective(MissionStatusType type, string objectiveId)
	{
	}

	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(HUDMission), Member = "EnqueueObjective")]
	[CalledBy(Type = typeof(HUDMission), Member = "OnAnimationComplete")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(HUDMission), Member = "Enqueue")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(StatusUpdate), Member = "Clear")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 4)]
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
	[CallsUnknownMethods(Count = 6)]
	public HUDMission()
	{
	}
}
