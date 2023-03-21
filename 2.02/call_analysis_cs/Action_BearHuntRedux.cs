using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

public class Action_BearHuntRedux : ActionTask
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "Begin")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_BearHuntRedux()
	{
	}
}
