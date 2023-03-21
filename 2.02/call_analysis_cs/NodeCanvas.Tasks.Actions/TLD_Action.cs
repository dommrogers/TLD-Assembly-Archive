using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class TLD_Action : ActionTask
{
	public BBParameter<bool> agentIsMissionObject;

	public BBParameter<string> agentMissionObjectIdentifier;

	protected new Component agent
	{
		[CalledBy(Type = typeof(Action_SetBaseAIState), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetBaseAIFeeding), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetBaseAIFleeDestination), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetWanderPosAfterStruggle), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetBaseAIStateFollowWaypoint), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetBaseAiTarget), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetBaseAiTarget), Member = "DoWork")]
		[CalledBy(Type = typeof(Action_SetBaseAiWaypointPath), Member = "DoWork")]
		[CalledBy(Type = typeof(Action_SetBaseAiCanScanForTargets), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetBaseAiCanScanForTargets), Member = "DoWork")]
		[CalledBy(Type = typeof(Action_SetBaseAiSpeedOverride), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetBaseAiSpeedOverride), Member = "DoWork")]
		[CalledBy(Type = typeof(Action_SetBearPatrolPointsOfInterest), Member = "DoWork")]
		[CalledBy(Type = typeof(Action_ForceAIToAttackPlayer), Member = "DoWork")]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[Calls(Type = typeof(Task), Member = "get_agent")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TLD_Action()
	{
	}
}
