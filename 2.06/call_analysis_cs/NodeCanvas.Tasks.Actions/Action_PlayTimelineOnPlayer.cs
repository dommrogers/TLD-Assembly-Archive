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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Action_PlayTimeline), Member = "BuildTimelineInfo")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[CallsUnknownMethods(Count = 12)]
	protected override void ExecuteTimelineAction()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[DeduplicatedMethod]
	private void OnTimelineComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Action_PlayTimeline), Member = ".ctor")]
	public Action_PlayTimelineOnPlayer()
	{
	}
}
