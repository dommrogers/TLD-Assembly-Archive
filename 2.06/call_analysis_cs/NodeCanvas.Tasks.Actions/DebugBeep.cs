using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class DebugBeep : ActionTask
{
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DebugBeep()
	{
	}
}
