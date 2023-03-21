using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.Playables;

namespace NodeCanvas.Tasks.Actions;

public class Action_PlayTimelineV2 : ActionTask
{
	public TimelineRef m_TimelineRef;

	public bool m_ShouldStowItemInHands;

	public BBParameter<GameObject> m_Target;

	public BBParameter<string> m_MissionIdentifierTarget;

	public BBParameter<bool> m_PlayerTimeline;

	public PlayerControlMode m_PlayerControlMode;

	public BBParameter<bool> m_SkipDisableCrouch;

	public BBParameter<Animator> m_BindingAnimator;

	public BBParameter<string> m_BindingTrackName;

	public BBParameter<GameObject> m_SyncBoneOverride;

	public BBParameter<DirectorWrapMode> m_WrapMode;

	public BBParameter<float> m_TimeToSyncPlayerToBone;

	public BBParameter<float> m_TimeToTransitionOut;

	public BBParameter<float> m_DesiredFov;

	public BBParameter<bool> m_UnloadAfterPlay;

	private TimelinePlayback.TimelineInfo m_TimelineInfo;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Action_PlayTimelineV2), Member = "GetTimelinePlayback")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 32)]
	protected override void OnExecute()
	{
	}

	[CalledBy(Type = typeof(Action_PlayTimelineV2), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private TimelinePlayback GetTimelinePlayback()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	private void OnTimelineComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "op_Implicit")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public Action_PlayTimelineV2()
	{
	}
}
