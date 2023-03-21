using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetBearPatrolPointsOfInterest : TLD_Action
{
	public List<BaseAi.PointOfInterest> pointsOfInterest;

	public BBParameter<bool> randomizeOrder;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_SetBearPatrolPointsOfInterest), Member = "DoWork")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CalledBy(Type = typeof(Action_SetBearPatrolPointsOfInterest), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TLD_Action), Member = "get_agent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetPointsOfInterest")]
	[CallsUnknownMethods(Count = 1)]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SetBearPatrolPointsOfInterest()
	{
	}
}
