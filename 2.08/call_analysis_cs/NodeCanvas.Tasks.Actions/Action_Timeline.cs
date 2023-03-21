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
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	protected abstract string TimelineActionName { get; }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	protected abstract void ExecuteTimelineAction();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected Action_Timeline()
	{
	}
}
