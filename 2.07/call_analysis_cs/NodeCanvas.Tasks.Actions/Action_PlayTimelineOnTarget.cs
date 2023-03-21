using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_PlayTimelineOnTarget : Action_PlayTimeline
{
	public BBParameter<GameObject> m_Target;

	public BBParameter<string> m_MissionIdentifierTarget;

	protected override string TimelineActionName
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Action_PlayTimelineOnTarget), Member = "GetTimelinePlayback")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Action_PlayTimeline), Member = "BuildTimelineInfo")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnSelf")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 4)]
	protected override void ExecuteTimelineAction()
	{
	}

	[CalledBy(Type = typeof(Action_PlayTimelineOnTarget), Member = "ExecuteTimelineAction")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	private TimelinePlayback GetTimelinePlayback()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[DeduplicatedMethod]
	private void OnTimelineComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_PlayTimeline), Member = ".ctor")]
	public Action_PlayTimelineOnTarget()
	{
	}
}
