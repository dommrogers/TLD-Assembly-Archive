using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_UnlockSnowShelter : ActionTask
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_UnlockSnowShelter()
	{
	}
}
