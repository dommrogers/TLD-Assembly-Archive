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
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Action_PlayTimelineV2), Member = "GetTimelinePlayback")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 33)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(Action_PlayTimelineV2), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public Action_PlayTimelineV2()
	{
	}
}
