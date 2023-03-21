using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.AddressableAssets;

namespace NodeCanvas.Tasks.Actions;

public abstract class Action_Timeline : ActionTask
{
	public AssetReferenceTimeline m_TimelineReference;

	protected override string info
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	protected abstract string TimelineActionName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract void ExecuteTimelineAction();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected Action_Timeline()
	{
	}
}
