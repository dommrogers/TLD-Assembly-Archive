using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_UnlockSnowShelter : ActionTask
{
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_UnlockSnowShelter()
	{
	}
}
