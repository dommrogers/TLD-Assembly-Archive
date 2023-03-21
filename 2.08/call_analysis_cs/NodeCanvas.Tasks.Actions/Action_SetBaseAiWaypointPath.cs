using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetBaseAiWaypointPath : TLD_Action
{
	public BBParameter<GameObject> path;

	public BBParameter<bool> disableScanForTargets;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Action_SetBaseAiWaypointPath), Member = "DoWork")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TLD_Action), Member = "get_agent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetWaypoints")]
	[CalledBy(Type = typeof(Action_SetBaseAiWaypointPath), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 3)]
	private void DoWork()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_SetBaseAiWaypointPath()
	{
	}
}
