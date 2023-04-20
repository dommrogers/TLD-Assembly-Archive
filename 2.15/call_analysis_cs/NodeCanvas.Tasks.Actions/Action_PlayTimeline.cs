using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.Playables;

namespace NodeCanvas.Tasks.Actions;

public abstract class Action_PlayTimeline : Action_Timeline
{
	public BBParameter<bool> m_SkipDisableCrouch;

	public BBParameter<Animator> m_BindingAnimator;

	public BBParameter<string> m_BindingTrackName;

	public BBParameter<GameObject> m_SyncBone;

	public BBParameter<DirectorWrapMode> m_WrapMode;

	public BBParameter<float> m_TimeToSyncPlayerToSyncBone;

	public BBParameter<float> m_TimeToTransitionOut;

	public BBParameter<float> m_DesiredFov;

	public BBParameter<bool> m_UnloadAfterPlay;

	protected TimelinePlayback.TimelineInfo m_TimelineInfo;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_PlayTimeline), Member = "BuildTimelineInfo")]
	protected override void ExecuteTimelineAction()
	{
	}

	[CalledBy(Type = typeof(Action_PlayTimeline), Member = "ExecuteTimelineAction")]
	[CalledBy(Type = typeof(Action_PlayTimelineOnPlayer), Member = "ExecuteTimelineAction")]
	[CalledBy(Type = typeof(Action_PlayTimelineOnTarget), Member = "ExecuteTimelineAction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[CallsUnknownMethods(Count = 1)]
	protected void BuildTimelineInfo()
	{
	}

	[CalledBy(Type = typeof(Action_PlayTimelineOnPlayer), Member = ".ctor")]
	[CalledBy(Type = typeof(Action_PlayTimelineOnTarget), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	protected Action_PlayTimeline()
	{
	}
}
