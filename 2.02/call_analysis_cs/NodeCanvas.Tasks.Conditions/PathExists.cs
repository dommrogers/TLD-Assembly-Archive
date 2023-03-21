using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Conditions;

public class PathExists : ConditionTask<NavMeshAgent>
{
	public BBParameter<Vector3> targetPosition;

	public BBParameter<List<Vector3>> savePathAs;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(NavMeshPath), Member = "ClearCorners")]
	[CallsUnknownMethods(Count = 16)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public PathExists()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
