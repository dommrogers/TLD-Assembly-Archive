using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class MoveAway : ActionTask<Transform>
{
	public BBParameter<GameObject> target;

	public BBParameter<float> speed;

	public BBParameter<float> stopDistance;

	public bool waitActionFinish;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Vector3), Member = "MoveTowards")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 21)]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public MoveAway()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
