using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetBaseAiWaypointPath : TLD_Action
{
	public BBParameter<GameObject> path;

	public BBParameter<bool> disableScanForTargets;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_SetBaseAiWaypointPath), Member = "DoWork")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_Action), Member = "get_agent")]
	[CalledBy(Type = typeof(Action_SetBaseAiWaypointPath), Member = "OnExecute")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SetBaseAiWaypointPath()
	{
	}
}
