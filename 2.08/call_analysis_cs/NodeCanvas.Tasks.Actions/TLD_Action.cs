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
		[CalledBy(Type = typeof(Action_SetBaseAiWaypointPath), Member = "DoWork")]
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(Action_ForceAIToAttackPlayer), Member = "DoWork")]
		[CalledBy(Type = typeof(Action_SetBearPatrolPointsOfInterest), Member = "DoWork")]
		[CalledBy(Type = typeof(Action_SetBaseAiSpeedOverride), Member = "DoWork")]
		[CalledBy(Type = typeof(Action_SetBaseAiSpeedOverride), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetBaseAiCanScanForTargets), Member = "DoWork")]
		[CalledBy(Type = typeof(Action_SetBaseAiTarget), Member = "DoWork")]
		[CalledBy(Type = typeof(Action_SetBaseAiCanScanForTargets), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetWanderPosAfterStruggle), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetBaseAIFleeDestination), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetBaseAIFeeding), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetBaseAIState), Member = "OnExecute")]
		[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
		[Calls(Type = typeof(Task), Member = "get_agent")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 13)]
		[CalledBy(Type = typeof(Action_SetBaseAIStateFollowWaypoint), Member = "OnExecute")]
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
