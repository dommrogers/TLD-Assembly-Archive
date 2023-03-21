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
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(NavMeshPath), Member = "ClearCorners")]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 19)]
	protected override bool OnCheck()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public PathExists()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
