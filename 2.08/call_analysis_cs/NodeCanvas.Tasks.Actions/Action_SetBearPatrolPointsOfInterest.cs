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
	[Calls(Type = typeof(TLD_Action), Member = "get_agent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(Type = typeof(BaseAi), Member = "SetPointsOfInterest")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 1)]
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
