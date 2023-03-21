using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetBaseAIFleeDestination : TLD_Action
{
	public BBParameter<GameObject> target;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TLD_Action), Member = "get_agent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 5)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_SetBaseAIFleeDestination()
	{
	}
}
