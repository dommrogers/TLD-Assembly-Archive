using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class RotateTowards : ActionTask<Transform>
{
	public BBParameter<GameObject> target;

	public BBParameter<float> speed;

	public BBParameter<float> angleDifference;

	public BBParameter<Vector3> upVector;

	public bool waitActionFinish;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 17)]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public RotateTowards()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
