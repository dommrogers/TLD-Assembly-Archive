using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.AddressableAssets;

namespace NodeCanvas.Tasks.Actions;

public abstract class Action_Timeline : ActionTask
{
	public AssetReferenceTimeline m_TimelineReference;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	protected abstract string TimelineActionName
	{
		[CallerCount(Count = 101261)]
		[DeduplicatedMethod]
		get;
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	protected abstract void ExecuteTimelineAction();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected Action_Timeline()
	{
	}
}
