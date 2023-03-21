using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

public class Action_BearHuntRedux : ActionTask
{
	[Calls(Type = typeof(BearHuntRedux), Member = "Begin")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_BearHuntRedux()
	{
	}
}
