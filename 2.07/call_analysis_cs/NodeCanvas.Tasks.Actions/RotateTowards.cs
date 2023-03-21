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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 17)]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public RotateTowards()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
