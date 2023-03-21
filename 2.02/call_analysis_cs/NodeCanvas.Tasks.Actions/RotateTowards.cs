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
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 27)]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public RotateTowards()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
