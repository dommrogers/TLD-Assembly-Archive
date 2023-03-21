using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions;

public class Patrol : ActionTask<NavMeshAgent>
{
	public enum PatrolMode
	{
		Progressive,
		Random
	}

	public BBParameter<List<GameObject>> targetList;

	public BBParameter<PatrolMode> patrolMode;

	public BBParameter<float> speed;

	public BBParameter<float> keepDistance;

	private int index;

	private Vector3? lastRequest;

	private BipedMoveAgent bma;

	private List<BipedSyncPoint> targetSyncPointList;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_speed")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(NavMeshAgent), Member = "get_remainingDistance")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_stoppingDistance")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "IsMoving")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "SetDestination")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	protected override void OnUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnPause()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NavMeshAgent), Member = "ResetPath")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "StopMovingImmediate")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnStop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 8)]
	public override void OnDrawGizmosSelected()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Patrol()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
