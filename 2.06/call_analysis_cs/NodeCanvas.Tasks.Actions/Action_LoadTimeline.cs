using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.AddressableAssets;

namespace NodeCanvas.Tasks.Actions;

public class Action_LoadTimeline : Action_Timeline
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
	[Calls(Type = typeof(AssetReferenceTimeline), Member = "LoadTimeline")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	protected override void ExecuteTimelineAction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetReferenceTimeline), Member = "get_IsLoaded")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDoneLoading(AssetReferenceTimeline timeline)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_LoadTimeline()
	{
	}
}
