using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

public class Action_HuntedBearWander : ActionTask
{
	public Vector3 posToWanderTo;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_HuntedBearWander()
	{
	}
}
