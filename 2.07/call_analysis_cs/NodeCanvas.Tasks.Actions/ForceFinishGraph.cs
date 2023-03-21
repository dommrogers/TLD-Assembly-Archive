using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Actions;

public class ForceFinishGraph : ActionTask
{
	public CompactStatus finishStatus;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public ForceFinishGraph()
	{
	}
}
