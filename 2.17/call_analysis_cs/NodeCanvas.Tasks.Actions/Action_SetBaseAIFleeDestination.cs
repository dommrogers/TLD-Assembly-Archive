using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetBaseAIFleeDestination : TLD_Action
{
	public BBParameter<GameObject> target;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_Action), Member = "get_agent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SetBaseAIFleeDestination()
	{
	}
}
