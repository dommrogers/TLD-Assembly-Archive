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
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 49)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_speed")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_stoppingDistance")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_remainingDistance")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "IsMoving")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "SetDestination")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	protected override void OnUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnPause()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BipedMoveAgent), Member = "StopMovingImmediate")]
	[Calls(Type = typeof(NavMeshAgent), Member = "ResetPath")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	protected override void OnStop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 9)]
	public override void OnDrawGizmosSelected()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public Patrol()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
