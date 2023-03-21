using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Tasks.Actions;

public class Action_UnloadTimeline : Action_Timeline
{
	protected override string TimelineActionName
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void ExecuteTimelineAction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_UnloadTimeline()
	{
	}
}
