using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetBaseAIStateFollowWaypoint : TLD_Action
{
	public BBParameter<GameObject> path;

	public BBParameter<bool> disableScanForTargets;

	public BBParameter<bool> doOverride;

	public BBParameter<float> overrideSpeed;

	public BBParameter<BaseAi.WaypointCompletionBehaviouir> waypointCompletionBehaviouir;

	public BBParameter<AiMode> nextState;

	[Calls(Type = typeof(BaseAi), Member = "SetWaypoints")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(BaseAi), Member = "SetSpeedOverride")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_Action), Member = "get_agent")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Action_SetBaseAIStateFollowWaypoint()
	{
	}
}
