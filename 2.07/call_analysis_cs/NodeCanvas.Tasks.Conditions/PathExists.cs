using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Conditions;

public class PathExists : ConditionTask<NavMeshAgent>
{
	public BBParameter<Vector3> targetPosition;

	public BBParameter<List<Vector3>> savePathAs;

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(NavMeshPath), Member = "ClearCorners")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public PathExists()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
