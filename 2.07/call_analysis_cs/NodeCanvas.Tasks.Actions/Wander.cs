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

	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "IsMoving")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Wander), Member = "DoWander")]
	[CallsUnknownMethods(Count = 5)]
	protected override void OnUpdate()
	{
	}

	[CalledBy(Type = typeof(Wander), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 33)]
	[CalledBy(Type = typeof(Wander), Member = "OnUpdate")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "SetDestination")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallsDeduplicatedMethods(Count = 10)]
	private void DoWander()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnPause()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(NavMeshAgent), Member = "ResetPath")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "StopMovingImmediate")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
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
