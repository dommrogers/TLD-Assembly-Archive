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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(NavMeshPath), Member = "ClearCorners")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 21)]
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
