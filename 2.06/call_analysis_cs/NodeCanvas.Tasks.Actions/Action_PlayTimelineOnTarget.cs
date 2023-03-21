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

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnSelf")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Action_PlayTimeline), Member = "BuildTimelineInfo")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_PlayTimelineOnTarget), Member = "GetTimelinePlayback")]
	protected override void ExecuteTimelineAction()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Action_PlayTimelineOnTarget), Member = "ExecuteTimelineAction")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private TimelinePlayback GetTimelinePlayback()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	private void OnTimelineComplete()
	{
	}

	[Calls(Type = typeof(Action_PlayTimeline), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public Action_PlayTimelineOnTarget()
	{
	}
}
