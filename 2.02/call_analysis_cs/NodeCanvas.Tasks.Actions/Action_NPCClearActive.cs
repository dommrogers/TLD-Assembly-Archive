using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_NPCClearActive : ActionTask
{
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(NPC), Member = "ClearActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_NPCClearActive()
	{
	}
}
