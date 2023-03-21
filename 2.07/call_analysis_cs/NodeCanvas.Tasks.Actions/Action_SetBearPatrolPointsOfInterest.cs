using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetBearPatrolPointsOfInterest : TLD_Action
{
	public List<BaseAi.PointOfInterest> pointsOfInterest;

	public BBParameter<bool> randomizeOrder;

	[Calls(Type = typeof(Action_SetBearPatrolPointsOfInterest), Member = "DoWork")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CalledBy(Type = typeof(Action_SetBearPatrolPointsOfInterest), Member = "OnExecute")]
	[Calls(Type = typeof(TLD_Action), Member = "get_agent")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetPointsOfInterest")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SetBearPatrolPointsOfInterest()
	{
	}
}
