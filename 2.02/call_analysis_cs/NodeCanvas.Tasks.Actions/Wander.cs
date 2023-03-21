using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions;

public class Wander : ActionTask<NavMeshAgent>
{
	public BBParameter<float> speed;

	public BBParameter<float> keepDistance;

	public BBParameter<float> minWanderDistance;

	public BBParameter<float> maxWanderDistance;

	public bool repeat;

	private BipedMoveAgent bma;

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Wander), Member = "DoWander")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BipedMoveAgent), Member = "IsMoving")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "IsMoving")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Wander), Member = "DoWander")]
	[CallsUnknownMethods(Count = 9)]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Wander), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Wander), Member = "OnExecute")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "SetDestination")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void DoWander()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnPause()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NavMeshAgent), Member = "ResetPath")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "StopMovingImmediate")]
	protected override void OnStop()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public Wander()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
