using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetBaseAiTarget : TLD_Action
{
	public BBParameter<GameObject> target;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(TLD_Action), Member = "get_agent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TLD_Action), Member = "get_agent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SetBaseAiTarget()
	{
	}
}
