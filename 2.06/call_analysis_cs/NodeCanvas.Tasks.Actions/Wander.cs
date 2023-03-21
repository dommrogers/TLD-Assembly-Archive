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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "IsMoving")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Wander), Member = "DoWander")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Wander), Member = "DoWander")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "IsMoving")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "SetDestination")]
	[CalledBy(Type = typeof(Wander), Member = "OnExecute")]
	[CalledBy(Type = typeof(Wander), Member = "OnUpdate")]
	[CallsUnknownMethods(Count = 12)]
	private void DoWander()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected override void OnPause()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NavMeshAgent), Member = "ResetPath")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "StopMovingImmediate")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnStop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public Wander()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
