using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_NPCClearActive : ActionTask
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "ClearActive")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_NPCClearActive()
	{
	}
}
