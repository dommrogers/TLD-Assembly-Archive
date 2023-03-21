using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_PlayTimelineOnPlayer : Action_PlayTimeline
{
	public BBParameter<bool> m_ShouldStowItemInHands;

	public BBParameter<PlayerControlMode> m_PlayerControlMode;

	protected override string TimelineActionName
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Action_PlayTimeline), Member = "BuildTimelineInfo")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	protected override void ExecuteTimelineAction()
	{
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnTimelineComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Action_PlayTimeline), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public Action_PlayTimelineOnPlayer()
	{
	}
}
