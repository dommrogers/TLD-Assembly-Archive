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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void ExecuteTimelineAction()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_UnloadTimeline()
	{
	}
}
